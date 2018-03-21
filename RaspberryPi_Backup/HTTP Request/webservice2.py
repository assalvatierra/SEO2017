import urllib.request

url = "http://httpbin.org/get"

response = urllib.request.urlopen(url).read()

print(response)
