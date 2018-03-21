#test web service from localhost 192.168.1.5
from requests import get
import json
from pprint import pprint

url = 'http://192.168.8.113:25980/Smsservice.asmx/rpi_getAllDevice'

all_message = get(url).json()['Table']
print('Json Devices Raw: ') 
print(all_message)
print(' ') 
print('Parsed Data: ') 
    
for message in all_message:
    print(message['Id'])
    print(message['Description'])

urlData = 'http://192.168.8.113:25980/SmsService.asmx/rpi_getDataLog?deviceId=1'

all_message2 = get(urlData).json()['Table']
print('Json Data Raw: ') 
print(all_message2)
print(' ') 
print('Parsed Data log: ') 
    
for message2 in all_message2:
    print(message2['Id'])
    print(message2['DtRead'])
    print(message2['DataRead'])
    print(message2['RpiDeviceId'])

