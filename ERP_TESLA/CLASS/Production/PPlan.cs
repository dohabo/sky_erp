using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TESLA.CLASS.Production
{
    class PPlan
    {
        int proPlanCode;
        string mCode;
        int amount;
        string pTarget;
        int eCode;
        string redDate;

        public PPlan(int proPlanCode, string mCode, int amount, string pTarget, int eCode, string redDate)
        {
            this.proPlanCode = proPlanCode;
            this.mCode = mCode;
            this.amount = amount;
            this.pTarget = pTarget;
            this.eCode = eCode;
            this.redDate = redDate;
        }

        public PPlan(string mCode, int amount, string pTarget, int eCode, string redDate)
        {
            this.mCode = mCode;
            this.amount = amount;
            this.pTarget = pTarget;
            this.eCode = eCode;
            this.redDate = redDate;
        }

        public int ProPlanCode { get => proPlanCode; set => proPlanCode = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public int Amount { get => amount; set => amount = value; }
        public string PTarget { get => pTarget; set => pTarget = value; }
        public int ECode { get => eCode; set => eCode = value; }
        public string RedDate { get => redDate; set => redDate = value; }
    }
}
