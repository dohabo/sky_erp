using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TESLA.CLASS.Production
{
    class MRP
    {
        int proPlanCode;
        string mCode;
        string mName;
        string unit;
        int amount;
        string requireDate;

        public MRP(int proPlanCode, string mCode, int amount, string requireDate)
        {
            this.proPlanCode = proPlanCode;
            this.mCode = mCode;
            this.amount = amount;
            this.requireDate = requireDate;
        }


        public MRP(int proPlanCode, string mCode, string mName, string unit, int amount, string requireDate)
        {
            this.proPlanCode = proPlanCode;
            this.mCode = mCode;
            this.mName = mName;
            this.unit = unit;
            this.amount = amount;
            this.requireDate = requireDate;
        }

        public int ProPlanCode { get => proPlanCode; set => proPlanCode = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public string MName { get => mName; set => mName = value; }
        public string Unit { get => unit; set => unit = value; }
        public int Amount { get => amount; set => amount = value; }
        public string RequireDate { get => requireDate; set => requireDate = value; }
    }
}
