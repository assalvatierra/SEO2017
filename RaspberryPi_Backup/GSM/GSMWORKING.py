import serial

import time
 
from curses import ascii

ser=serial.Serial('/dev/ttyUSB0', 115200)
ser.write(b"AT\r")
ser.write(b"AT\r")
ser.write(b"AT+CGREG=?\r")
ser.write(b"AT+CMGF=1\r")
ser.write(b'AT+CMGS=\"09279016517\"\r')
ser.write(b"Raspberry pi text test\r")
time.sleep(2)
ser.write(b'\x1a')
time.sleep(10)

time.sleep(10)
ser.write(b"AT+CMGL=\"ALL\"r\r")

#ser.write(ascii.ctrl('z').encode())
#ser.write(char.ConvertFromUtf32(26));
while True:
        response = ser.readline()
        print ("python printed:", response)


