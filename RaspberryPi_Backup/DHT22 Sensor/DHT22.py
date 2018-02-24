#Temperature and Humidity Sensor logging with Cayenne web app
#Date edited: 2/24/2018
#By: Jahdiel Villosa

#Description
#   Read ambient temperature and humidity from DHT-22 sensor
#   and send the data to the Cayene web application. When a
#   certain temperature is met, LED output will trigger either
#   ON/OFF. Note: Steady internet connection is required.

import paho.mqtt.client as mqtt
import time
import sys
import Adafruit_DHT
import RPi.GPIO as GPIO

#Initialize Values
#IO PIN CONFIGURATION
GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(25,GPIO.OUT) #set LED pin output to pin GPIO25 

time.sleep(30) #Sleep to allow wireless to connect before starting MQTT

#Cayenne web application device credentials
username = "202ca240-190f-11e8-aeac-8375e928efd4"
password = "60786ebfc3844de63267b5abcee4ff546a6c5af5"
clientid = "f66b84d0-1936-11e8-b59c-db84183bf26b"

#print(Adafruit_DHT.read_retry(Adafruit_DHT.DHT22, 24)) #try reading from sensor

#Main Program Start

#connect to web app
mqttc = mqtt.Client(client_id=clientid)
mqttc.username_pw_set(username, password=password)
mqttc.connect("mqtt.mydevices.com", port=1883, keepalive=60)
mqttc.loop_start()

topic_dht22_temp = "v1/" + username + "/things/" + clientid + "/data/3"
topic_dht22_humidity = "v1/" + username + "/things/" + clientid + "/data/4"

while True:
    try:
        #get reading from sensor
        humidity22, temp22 = Adafruit_DHT.read_retry(22, 24) #22 is the sensor type, 24 is the GPIO pin number (not physical pin number)

        #handle reading data
        if temp22 is not None:
            #control LED based on temperature limit
            if (int(temp22) >= 24):
                GPIO.output(ledpin, GPIO.HIGH)
            else:
                GPIO.output(ledpin, GPIO.LOW)

            #display and send data    
            temp22 = "temp,c=" + str(temp22)
            print(temp22)   #display on console
            mqttc.publish(topic_dht22_temp, payload=temp22, retain=True) #send temperature data to web app
        if humidity22 is not None:
            humidity22 = "rel_hum,p=" + str(humidity22)
            print(temp22)   #display on console
            mqttc.publish(topic_dht22_humidity, payload=humidity22, retain=True) #send humidity data to web app

        time.sleep(5)   #set idle time for sensor before acquiring data again
    except (EOFError, SystemExit, KeyboardInterrupt):
        mqttc.disconnect()
        sys.exit()
