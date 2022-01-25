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
        string regDate;

        public PPlan(int proPlanCode, string mCode, int amount, string pTarget, int eCode, string regDate)
        {
            this.proPlanCode = proPlanCode;
            this.mCode = mCode;
            this.amount = amount;
            this.pTarget = pTarget;
            this.eCode = eCode;
            this.regDate = regDate;
        }

        public PPlan(string mCode, int amount, string pTarget, int eCode, string regDate)
        {
            this.mCode = mCode;
            this.amount = amount;
            this.pTarget = pTarget;
            this.eCode = eCode;
            this.regDate = regDate;
        }

        public int ProPlanCode { get => proPlanCode; set => proPlanCode = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public int Amount { get => amount; set => amount = value; }
        public string PTarget { get => pTarget; set => pTarget = value; }
        public int ECode { get => eCode; set => eCode = value; }
        public string RegDate { get => regDate; set => regDate = value; }
    }
}
