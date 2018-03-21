
#import requests, time

#r = requests.post('http://validate.jsontest.com/?json="key":"value"')
#print (r.status_code)
#print (r.content)
#test post web service from localhost 192.168.1.5
from requests import get
import json
from pprint import pprint
import requests
r = get('http://192.168.1.6:25980/SmsService.asmx/rpi_setDataLog?deviceId=1&data={"Temp":25.6,"Humidity":54.7,"Light":0,"Fan":0,"Water":0}&dtLog=3/13/2018 12:00:00')
print(r)
