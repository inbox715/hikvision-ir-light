import requests
from requests.auth import HTTPDigestAuth

x= requests.put('http://192.168.1.66/ISAPI/image/channels/1/IrcutFilter',
data='<IrcutFilter xmlns="http://www.hikvision.com/ver20/XMLSchema" version="2.0"><IrcutFilterType>night</IrcutFilterType><nightToDayFilterLevel>4</nightToDayFilterLevel><nightToDayFilterTime>5</nightToDayFilterTime></IrcutFilter>', auth=HTTPDigestAuth('admin', '8024912mM'))

print(x.content)