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
        int oprManHour;
        string oprDescription;

        public Operation(string oprCode, string oprName, int oprManHour, string oprDescription)
        {
            this.oprCode = oprCode;
            this.oprName = oprName;
            this.oprManHour = oprManHour;
            this.oprDescription = oprDescription;
        }
        public Operation(string oprCode, string oprName, string oprDescription, int oprManHour)
        {
            this.oprCode = oprCode;
            this.oprName = oprName;
            this.oprManHour = oprManHour;
            this.oprDescription = oprDescription;
        }

        public string OprCode { get => oprCode; set => oprCode = value; }
        public string OprName { get => oprName; set => oprName = value; }
        public string OprDescription { get => oprDescription; set => oprDescription = value; }
        public int OprManHour { get => oprManHour; set => oprManHour = value; }
    }
}
