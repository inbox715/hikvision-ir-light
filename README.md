# hikvision-ir-light
# hikvision isapi commands test
# using ISAPI for switch camera to night and day
# with  python and c#
change user and pass to your camera user pass
if give internal error 500 realated to your camera 
for solve 
step1:
send reqest: to camera like this : "http://user:pass@CameraIp/ISAPI/image/channels/1/IrcutFilter"
you must recived some code like blow 

```xml
<IrcutFilter xmlns="http://www.hikvision.com/ver20/XMLSchema" version="2.0">
  <IrcutFilterType>day</IrcutFilterType>
  <nightToDayFilterLevel>4</nightToDayFilterLevel>
  <nightToDayFilterTime>5</nightToDayFilterTime>
</IrcutFilter>
```
copy code to python and repalce with "data" content

now code working
