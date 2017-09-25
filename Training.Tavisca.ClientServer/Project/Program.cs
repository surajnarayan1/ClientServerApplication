using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            public void response()
            {

                IPAddress ipAdress = IPAddress.Parse("172.16.14.125");
                TcpListener myList = new TcpListener(ipAdress, 80);
                myList.Start();
                TcpClient tcpclient = myList.AcceptTcpClient();
                NetworkStream serverStream = tcpclient.GetStream();
                byte[] bb = new byte[tcpclient.ReceiveBufferSize];
                int bytes = serverStream.Read(bb, 0, tcpclient.ReceiveBufferSize);
                string str = Encoding.ASCII.GetString(bb, 0, bytes);
                var data = JsonConvert.DeserializeObject<Person>(str);
                Console.WriteLine(data.EmailID);



            }
        }
}
