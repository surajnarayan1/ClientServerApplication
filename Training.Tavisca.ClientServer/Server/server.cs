using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Net.Sockets;
using ClientServer;




namespace Server
{
   public class Server
    {
        public void response()
        { 
            try
            {
                IPAddress ipAdress = IPAddress.Parse("172.16.14.125");
                TcpListener myList = new TcpListener(ipAdress, 545);
                myList.Start();
                TcpClient tcpclient = myList.AcceptTcpClient();
                NetworkStream serverStream = tcpclient.GetStream();
                byte[] bb = new byte[tcpclient.ReceiveBufferSize];
                int bytes = serverStream.Read(bb, 0, tcpclient.ReceiveBufferSize);
                string str = Encoding.ASCII.GetString(bb, 0, bytes);
                var data = JsonConvert.DeserializeObject<Person>(str);
                Console.WriteLine(data.EmailID);
                Console.Read();

            }
            


            catch(Exception ee)
            {
                Console.Write(ee);
            }
            

        }



    }
}
