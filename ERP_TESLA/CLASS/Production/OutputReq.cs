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
        string pCodeName;
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

        public OutputReq(int workOrderCode, string pMCode, string oprCode, string mMCode, int amount, string reqDate, int eCode, string reqStatus)
        {
            this.workOrderCode = workOrderCode;
            PMCode = pMCode;
            this.oprCode = oprCode;
            MMCode = mMCode;
            this.amount = amount;
            this.reqDate = reqDate;
            this.eCode = eCode;
            this.reqStatus = reqStatus;
        }

        public OutputReq(int reqCode, int workOrderCode, string pMCode, string pCodeName, string oprCode, string mMCode, string mCodeName, int amount, string reqDate, int eCode, string reqStatus)
        {
            this.reqCode = reqCode;
            this.workOrderCode = workOrderCode;
            PMCode = pMCode;
            this.pCodeName = pCodeName;
            this.oprCode = oprCode;
            MMCode = mMCode;
            this.mCodeName = mCodeName;
            this.amount = amount;
            this.reqDate = reqDate;
            this.eCode = eCode;
            this.reqStatus = reqStatus;
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
        public string PCodeName { get => pCodeName; set => pCodeName = value; }

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
