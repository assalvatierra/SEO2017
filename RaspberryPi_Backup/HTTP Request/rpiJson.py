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
    print('Rpi Id: ' + str(message['Id']))
    print('Description: ' + message['Description'])
    print('Version: ' + message['Version'])
    
    urlData = 'http://192.168.8.113:25980/SmsService.asmx/rpi_getDataLog?deviceId=' + str(message['Id'])

    all_dataset = get(urlData).json()['Table']
    #print('Json Data Raw: ') 
    #print(all_dataset)
    print(' ') 
    print('Parsed Data log: ') 
        
    for dataset in all_dataset:
        print('Id: ' + str(dataset['Id']))
        print('Rpi: ' + str(dataset['RpiDeviceId']))
        print('Date: ' + dataset['DtRead'])
        
        #print('Data: ' + dataset['DataRead'])
        #data parsed
        data = json.loads(dataset['DataRead'])
        print('Temp: ' + str(data['Temp']))
        print('Humidity: ' + str(data['Humidity']))
        print('Light: ' + str(data['Light']))
        print('Fan: ' + str(data['Fan']))
        print('Water: ' + str(data['Water']))
        print(' ') #newline



