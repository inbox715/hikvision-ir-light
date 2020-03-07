using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Text;


namespace ir_camera_control
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            if (userName == "") { userName = "admin"; }


            Console.WriteLine("Enter password:");
            string pass = Console.ReadLine();
            if (pass == "") { pass = "admin"; }


            Console.WriteLine("Enter ip:");
            string ip = Console.ReadLine();
            if (ip == "") { ip = "192.168.1.66"; }


            Console.WriteLine("IR_status");
            string IR = Console.ReadLine();

            if (IR == "1")
            {
                IR = "night";
            }
            else
            {
                IR = "day";

            }





            var Cre = new NetworkCredential(userName, pass);


            var request = WebRequest.Create("http://" + ip + "/ISAPI/image/channels/1/IrcutFilter");
            request.Method = "PUT";


            Stream dataStream;

            string postData = "<IrcutFilter xmlns=\"http://www.hikvision.com/ver20/XMLSchema\" version=\"2.0\"><IrcutFilterType>" + IR + "</IrcutFilterType><nightToDayFilterLevel>2</nightToDayFilterLevel></IrcutFilter>";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/xml";
            request.ContentLength = byteArray.Length;
            dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();


            request.Credentials = Cre;

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusCode);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }


            Console.ReadKey();

        }
    }
}
