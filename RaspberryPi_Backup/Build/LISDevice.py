# LIS Rpi Device service
# created : 3/19/2018
# Version : v1.0
#
# Handles the following
# -Temperature logging and update
# -Fan control using relay based on temp 
# -Get Device settings on interval
# -Get Control schedules for I/O on internal
# -Set settings on tempmax,tempmin,lights,fan
#   
import Adafruit_DHT 
import time
import sys
import RPi.GPIO as GPIO
from requests import get
import json
from pprint import pprint
from datetime import datetime
import requests
from decimal import Decimal

#initialize global variables
DEVICEID = 1
URL= 'http://192.168.1.6:25980/Smsservice.asmx/'
url = 'http://192.168.1.6:25980/Smsservice.asmx/rpi_getAllDevice'

#pin config
DHT22  = 18

tempfan_max = 20
tempfan_min = 21
fanpin = 22   #socket01  
lightpin = 23
waterpin = 24 #socket02


#constants
answer = "y"
time_s = 0.5
tempmax = 28
tempmin = 20


#load pin setup initialize
GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(tempfan_max,GPIO.OUT)
GPIO.setup(tempfan_min,GPIO.OUT)
GPIO.setup(fanpin,GPIO.OUT)
GPIO.setup(lightpin,GPIO.OUT)
GPIO.setup(waterpin,GPIO.OUT)

#startof Program

def main():
    print("LIS Rpi Device")
    print("----------------")
    global DHT22
    
    getDeviceList()
    testpin()
    getControls()
    print("Data logging start...")
    print("-----------------")
    while True:
        try:
            setLog()
            print("-----------------")
        except (EOFError, SystemExit, KeyboardInterrupt):
            #mqttc.disconnect()
            sys.exit()
#endof main()
def testpin():
    
    global tempfan_max
    global tempfan_min
    global fanpin 
    global lightpin 
    global waterpin
    
    time.sleep(0.5)
    print("Testing tempfan_max: " + str(tempfan_max))
    GPIO.output(tempfan_max, GPIO.HIGH)
    time.sleep(0.5)
    GPIO.output(tempfan_max, GPIO.LOW)
    

    #time.sleep(0.2)
    print("Testing tempfan_min: " + str(tempfan_min))
    GPIO.output(tempfan_min, GPIO.HIGH)
    time.sleep(0.5)
    GPIO.output(tempfan_min, GPIO.LOW)
    
    #time.sleep(0.2)
    print("Testing fanpin: " + str(fanpin))
    GPIO.output(fanpin, GPIO.HIGH)
    time.sleep(0.5)
    GPIO.output(fanpin, GPIO.LOW)
    
    #time.sleep(0.2)
    print("Testing lightpin: " + str(lightpin))
    GPIO.output(lightpin, GPIO.HIGH)
    time.sleep(0.5)
    GPIO.output(lightpin, GPIO.LOW)
    
    #time.sleep(0.2)
    print("Testing waterpin: " + str(waterpin))
    GPIO.output(waterpin, GPIO.HIGH)
    time.sleep(0.5)
    GPIO.output(waterpin, GPIO.LOW)
    
    time.sleep(0.5)
#end of test
    
def getDeviceList():
    all_message = get(URL + 'rpi_getDevice?deviceId='+str(DEVICEID)).json()['Table']
    #print('Json Devices Raw: ') 
    #print(all_message)
    #print(' ') 
    print('Connecting to server')

    for message in all_message:
        print('Rpi Id: '  + str(message['Id']))
        print('Description: ' + message['Description'])
        print('Version: ' + str(message['RpiVersionId']))
        getMapping(str(message['RpiVersionId']))

        print(' ')
#endof getDeviceList

#startof getMapping
def getMapping(versionId):
    global DHT22
    global fanpin
    global tempfan_max
    global tempfan_min
    global lightpin 
    global waterpin
    
    iomap = get(URL + 'rpi_getVersionMap?VersionId='+versionId).json()['Table']
    
    print('----- IO MAP -----')

    for io in iomap:
        print('Component: '  + io['ComponentName'])
        print('PinNo: '  + str(io['PinNo']))
        
        if (io['ComponentName'] == 'DHT22'):
            DHT22 = int(io['PinNo'])
            #print('DHT22 VALUE:' + str(DHT22))
        
        if (io['ComponentName'] == 'TempFan_Max'):
            tempfan_min = int(io['PinNo'])
            #print('TempFan VALUE:' + str(TempFan))

        if (io['ComponentName'] == 'TempFan_Min'):
            tempfan_min = int(io['PinNo'])
            #print('TempFan VALUE:' + str(TempFan))
        
        if (io['ComponentName'] == 'Light'):
            lightpin = int(io['PinNo'])
            #print('Light VALUE:' + str(lightpin))
        
        if (io['ComponentName'] == 'Socket01'):
            fanpin = int(io['PinNo'])
            #print('Socket01 VALUE:' + str(fanpin))
        
        if (io['ComponentName'] == 'Socket02'):
            waterpin = int(io['PinNo'])
            #print('Socket02 VALUE:' + str(waterpin))
        

        
#end of getMapping

#startof getMapping
def getControls():
    global tempmax
    global tempmin
    global lightpin
    global fanpin
    global waterpin
    
    iomap = get(URL + 'rpi_getLatestControl?deviceId='+str(DEVICEID)).json()['Table']
    
    print('----- Control MAP -----')

    for io in iomap:
        print('Schedule: '  + io['DtSchedule'])
        print('data: '  + io['Data'])
        
        today = datetime.now().strftime('%d/%m/%Y %H:%M:%S')
        schedule = str(io['DtSchedule'])
        print('Today: '  + today)
        print('Schedule: '  + schedule)
       
        controlmap = json.loads(io['Data'])
            
        #for control in controlmap:
        print('tempmax: ' + str(controlmap['TempMax']))
        print('tempmin: ' + str(controlmap['TempMin']))
        print('light: ' + str(controlmap['Light']))
        print('socket01: ' + str(controlmap['Socket01']))
        print('socket02: ' + str(controlmap['Socket02']))
        tempmax = controlmap['TempMax']
        tempmin = controlmap['TempMin']

        if (controlmap['Light'] == 1):
            GPIO.output(lightpin, GPIO.HIGH)
        else:
            GPIO.output(lightpin, GPIO.LOW)
        
        if (controlmap['Socket01'] == 1):
            GPIO.output(fanpin, GPIO.HIGH)
        else:
            GPIO.output(fanpin, GPIO.LOW)
        
        if (controlmap['Socket02'] == 1):
            GPIO.output(waterpin, GPIO.HIGH)
        else:
            GPIO.output(waterpin, GPIO.LOW)
        
        
    print('')
#end of getMapping

timer = 0    
#startof setLog        
def setLog():
    #fromGlobal
    global DHT22
    global tempmax
    global tempmin
    global timer
    
    global tempfan_max
    global tempfan_min
    global lightpin
    global fanpin
    global waterpin
    
    temp = 25.6
    humidity =54.7
    light = 0
    fan = 0
    water = 0
    
    print('DHT22: ' + str(DHT22))
    print('time: ' + str(timer))
    #reading from dht22 sensor
    humidity22, temp22 = Adafruit_DHT.read_retry(22, DHT22) #22 is the sensor type, 18 is the GPIO pin number (not physical pin number)

    if temp22 is not None:
        if (int(temp22) >= tempmax):
            GPIO.output(tempfan_max, GPIO.HIGH)
        else:
            GPIO.output(tempfan_max, GPIO.LOW)
            
        if (int(temp22) <= tempmin):
            GPIO.output(tempfan_min, GPIO.HIGH)
            
        else:
            GPIO.output(tempfan_min, GPIO.LOW)
            
        #temp22 = "temp,c=" + str(temp22)
    else:
        temp22 = 0
        
    if humidity22 is not None:
        humidity22 = humidity22
        #humidity22 = "rel_hum,p=" + str(humidity22)
    else:
        humidity22 = 0
        
    print(round(Decimal(temp22),1))
    print(round(Decimal(humidity22),1))
    #update data
    temp = round(Decimal(temp22),1)
    humidity = round(Decimal(humidity22),1)
    
    if(timer == 10):
        #get pin status
        lightPinStatus = GPIO.input(lightpin)
        fanPinStatus = GPIO.input(fanpin)
        waterPinStatus = GPIO.input(waterpin)
        
        #prepare data and send to server
        #"Temp":34.1,"Humidity":50,"Light":0,"Fan":0,"Water":0
        data = '{"Temp":'+ str(temp) +',"Humidity":'+ str(humidity) +',"Light":'+ str(lightPinStatus) +',"Fan":'+ str(fanPinStatus) +',"Water":'+ str(waterPinStatus) +'}'
        print(data)
        #get current date and time
        myDT = str(datetime.now().strftime('%d/%m/%Y %H:%M:%S'))
        
        #sent http request 
        print(myDT)
        message = get(URL + "rpi_setDataLog?deviceId="+ str(DEVICEID)+"&data="+data+"&dtLog="+ str(datetime.strptime(myDT,'%d/%m/%Y %H:%M:%S')))

        #check http response code
        #print(message.status_code)
        if (message.status_code == 200):
            print("insert log successful")
        else:
            print("insert log failed") 
        timer = 0 #reset timer
        time.sleep(6)
        getControls() #get setting updates on server
    else:
        time.sleep(6)
        timer = timer + 1 #increment time
#endof setLog

#call main() to run program
main()

#endof Program
