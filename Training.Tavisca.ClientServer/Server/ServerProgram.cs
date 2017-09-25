using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using ClientServer;

namespace Server
{
    class ServerProgram
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.response();
            

        }
    }

}