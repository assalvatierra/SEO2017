#LIS Rpi Device service
#created : 3/19/2018
#Version : v1.0
#
# handles the following
# -Temperature logging and update
# -Fan control using relay based on temp 
# -Get Device settings on interval
# -Get Control schedules for I/O on internal
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

#initialize global variables
DEVICEID = 1
URL= 'http://192.168.1.6:25980/Smsservice.asmx/'
url = 'http://192.168.1.6:25980/Smsservice.asmx/rpi_getAllDevice'

#pin config
ledpin = 23
fanpin = 24
DHT22 = 0

#constants
answer = "y"
time_s = 0.5
tempLimit = 26

#load pin setup initialize
GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(ledpin,GPIO.OUT)
GPIO.setup(fanpin,GPIO.OUT)


#startof Program

def main():
    print("LIS Rpi Device")
    print("----------------")
    getDeviceList()
    
    print("Data logging start...")
    print("-----------------")
    while True:
        try:
            setLog()
            print("-----------------")
            time.sleep(5)
        except (EOFError, SystemExit, KeyboardInterrupt):
            #mqttc.disconnect()
            sys.exit()
#endof main()
    

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
    iomap = get(URL + 'rpi_getVersionMap?VersionId='+versionId).json()['Table']
    
    print('----- IO MAP -----')

    for io in iomap:
        print('Component: '  + io['ComponentName'])
        print('PinNo: '  + str(io['PinNo']))
        ledpin = 23
        fanpin = 24
        DHT22 = 18
        
#end of getMapping

    
#startof setLog        
def setLog():
    
    temp = 25.6
    humidity =54.7
    light = 0
    fan = 0
    water = 0
    
    #reading from dht22 sensor
    humidity22, temp22 = Adafruit_DHT.read_retry(22, DHT22) #22 is the sensor type, 18 is the GPIO pin number (not physical pin number)

    if temp22 is not None:
        if (int(temp22) >= tempLimit):
            GPIO.output(fanpin, GPIO.HIGH)
            GPIO.output(ledpin, GPIO.HIGH)
        else:
            GPIO.output(ledpin, GPIO.LOW)
            GPIO.output(fanpin, GPIO.LOW)
        temp22 = "temp,c=" + str(temp22)
        
    if humidity22 is not None:
        humidity22 = "rel_hum,p=" + str(humidity22)
        
    print(temp22)
    print(humidity22)
    #update data
    temp = temp22
    humidity = humidity22
    
    #prepare data and send to server
    #"Temp":34.1,"Humidity":50,"Light":0,"Fan":0,"Water":0
    data = '{"Temp":'+ str(temp) +',"Humidity":'+ str(humidity) +',"Light":'+ str(light) +',"Fan":'+ str(fan) +',"Water":'+ str(water) +'}'

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
#endof setLog

#call main() to run program
main()

#endof Program
