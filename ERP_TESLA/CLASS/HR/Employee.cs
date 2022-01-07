using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TESLA.CLASS.HR
{
    class Employee
    {
        string departure;

        public Employee(string departure)
        {
            this.departure = departure;
        }

        public string Departure { get => departure; set => departure = value; }
    }
}
