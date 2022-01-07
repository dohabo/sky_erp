using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TESLA.CLASS.Standard
{
    class Warehouse
    {
        int wCode;
        string wName;
        string wDescription;

        public Warehouse(int wCode, string wName, string wDescription)
        {
            this.wCode = wCode;
            this.wName = wName;
            this.wDescription = wDescription;
        }

        public Warehouse(string wName, string wDescription)
        {
            this.wName = wName;
            this.wDescription = wDescription;
        }

        public int WCode { get => wCode; set => wCode = value; }
        public string WName { get => wName; set => wName = value; }
        public string WDescription { get => wDescription; set => wDescription = value; }
    }
}
