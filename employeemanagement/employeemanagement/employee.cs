using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace employeemanagement
{
    public class employee
    {
        public Int32 empid { get; set; }
        public string initials {get; set;}
        public string surname{ get; set; }
        public string name { get; set; }
        public string  mobile { get; set; }
        public string curraddress { get; set; }
        public string currdesignation { get; set; }
        public Int32 currsalarypkg { get; set; }
        public string department { get; set; }
    }
}