from requests import get
import json
from pprint import pprint

url = 'https://apex.oracle.com/pls/apex/raspberrypi/weatherstation/getlatestmeasurements/2696567'
all_stations = get(url).json()['items']
pprint(all_stations)
    
for station in all_stations:
    station_temp  = station['ground_temp']

    pprint("ground temp:" + str(station_temp))
