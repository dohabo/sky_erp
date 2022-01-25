using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TESLA.CLASS.Production
{
    class SelectPPlan
    {
        int proPlanCode;
        string mCode;
        string mName;
        string unit;
        int amount;
        string pTarget;
        string regDate;
        int eCode;

        public SelectPPlan(int proPlanCode, string mCode, string mName, string unit, int amount, string pTarget, string regDate, int eCode)
        {
            this.proPlanCode = proPlanCode;
            this.mCode = mCode;
            this.mName = mName;
            this.unit = unit;
            this.amount = amount;
            this.pTarget = pTarget;
            this.regDate = regDate;
            this.eCode = eCode;
        }

        public int ProPlanCode { get => proPlanCode; set => proPlanCode = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public string MName { get => mName; set => mName = value; }
        public string Unit { get => unit; set => unit = value; }
        public int Amount { get => amount; set => amount = value; }
        public string PTarget { get => pTarget; set => pTarget = value; }
        public string RegDate { get => regDate; set => regDate = value; }
        public int ECode { get => eCode; set => eCode = value; }
    }
}
