using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.Production
{
    class OutputReq
    {
        int reqCode;
        int workOrderCode;
        string PMCode;
        string oprCode;
        string MMCode;
        string mCodeName;
        int amount;
        string unit;
        string reqDate;
        int eCode;
        string reqStatus;

        public OutputReq()
        {
        }

        public OutputReq(int reqCode, string mMCode, string mCodeName, 
            int amount, string unit, string reqDate, int eCode)
        {
            this.reqCode = reqCode;
            MMCode = mMCode;
            this.mCodeName = mCodeName;
            this.amount = amount;
            this.unit = unit;
            this.eCode = eCode;
            this.reqDate = reqDate;
        }

        public int ReqCode { get => reqCode; set => reqCode = value; }
        public int WorkOrderCode { get => workOrderCode; set => workOrderCode = value; }
        public string PMCode1 { get => PMCode; set => PMCode = value; }
        public string OprCode { get => oprCode; set => oprCode = value; }
        public string MMCode1 { get => MMCode; set => MMCode = value; }
        public string MCodeName { get => mCodeName; set => mCodeName = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Unit { get => unit; set => unit = value; }
        public int ECode { get => eCode; set => eCode = value; }
        public string ReqDate { get => reqDate; set => reqDate = value; }
        public string ReqStatus { get => reqStatus; set => reqStatus = value; }

        public void OutputReqGridView(List<OutputReq> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].reqCode.ToString(),
                    list[i].MMCode,
                    list[i].mCodeName,
                    list[i].amount.ToString(),
                    list[i].unit,
                    list[i].reqDate,
                    list[i].eCode.ToString()
                });
            }
        }
    }
}
