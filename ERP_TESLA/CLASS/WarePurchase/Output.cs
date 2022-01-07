using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TESLA.CLASS.WarePurchase
{
    class Output
    {
        int reqCode;
        string mCode;
        int amount;
        string reqDate;
        string outDate;
        int wCode;
        int eCode;

        public Output(int reqCode, string mCode, int amount, 
            string reqDate, string outDate, int wCode, int eCode)
        {
            this.reqCode = reqCode;
            this.mCode = mCode;
            this.amount = amount;
            this.reqDate = reqDate;
            this.outDate = outDate;
            this.wCode = wCode;
            this.eCode = eCode;
        }

        public int ReqCode { get => reqCode; set => reqCode = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public int Amount { get => amount; set => amount = value; }
        public string ReqDate { get => reqDate; set => reqDate = value; }
        public string OutDate { get => outDate; set => outDate = value; }
        public int WCode { get => wCode; set => wCode = value; }
        public int ECode { get => eCode; set => eCode = value; }
    }
}
