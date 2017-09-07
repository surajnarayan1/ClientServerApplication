using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


using System.Net.Sockets;
using Newtonsoft.Json;
using System.IO;

namespace ClientServer
{
  public  class ClientSide
    {
      
        static void Main(string[] args)
        {

            Person person = new Person();
           
            Console.WriteLine("Enter the First name ");
            person.name.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Middle name ");
            person.name.MiddleName= Console.ReadLine();
            Console.WriteLine("Enter the LastName name ");
            person.name.LastName = Console.ReadLine();

            Console.WriteLine("Enter the Adhar NUMBER ");
            person.AdhaarNumber = Console.ReadLine();
            Console.WriteLine("Enter the email id ");
            person.EmailID = Console.ReadLine();
            


            //seralization of object


            var data = JsonConvert.SerializeObject(person);
            TcpClient tcpclient = new TcpClient();
            tcpclient.Connect("172.16.14.125",545);
            ASCIIEncoding ascii = new ASCIIEncoding();
            byte[] bb = ascii.GetBytes(data);

            NetworkStream stm = tcpclient.GetStream();
            stm.Write(bb, 0, bb.Length);
           











        }
       
    }
}
