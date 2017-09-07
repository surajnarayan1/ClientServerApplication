using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientServer
{
    public class Person
    {
        public FullName name { get; set; }
        public string AdhaarNumber { get; set; }
        public string EmailID { get; set; }
        public Person()
            {
            name = new FullName();
            }
    }
}
