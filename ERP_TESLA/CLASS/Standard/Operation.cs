using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TESLA.CLASS.Standard
{
    class Operation
    {
        string oprCode;
        string oprName;
        string oprDescription;

        public Operation(string oprCode, string oprName, string oprDescription)
        {
            this.oprCode = oprCode;
            this.oprName = oprName;
            this.oprDescription = oprDescription;
        }

        public Operation(string oprName, string oprDescription)
        {
            this.oprName = oprName;
            this.oprDescription = oprDescription;
        }

        public string OprCode { get => oprCode; set => oprCode = value; }
        public string OprName { get => oprName; set => oprName = value; }
        public string OprDescription { get => oprDescription; set => oprDescription = value; }
    }
}
