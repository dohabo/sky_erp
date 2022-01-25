using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TESLA.CLASS.Production
{
    class WOrder
    {
        int workOrderCode;
        int proPlanCode;
        string orderDate;
        string endDate;
        int cCode;
        string mCode;
        string mName;
        int amount;
        string workStatus;

        public WOrder(int proPlanCode, string orderDate, string endDate, int cCode, string mCode, string mName, int amount, string workStatus, int workOrderCode)
        {
            this.proPlanCode = proPlanCode;
            this.orderDate = orderDate;
            this.endDate = endDate;
            this.cCode = cCode;
            this.mCode = mCode;
            this.mName = mName;
            this.amount = amount;
            this.workStatus = workStatus;
            this.workOrderCode = workOrderCode;
        }

        public WOrder(int proPlanCode, string orderDate, string endDate, int cCode, string mCode, string mName, int amount, string workStatus)
        {
            this.proPlanCode = proPlanCode;
            this.orderDate = orderDate;
            this.endDate = endDate;
            this.cCode = cCode;
            this.mCode = mCode;
            this.mName = mName;
            this.amount = amount;
            this.workStatus = workStatus;
        }

        public WOrder(int proPlanCode, string orderDate, int cCode, string endDate, int amount, string workStatus)
        {
            this.proPlanCode = proPlanCode;
            this.orderDate = orderDate;
            this.cCode = cCode;
            this.endDate = endDate;
            this.amount = amount;
            this.workStatus = workStatus;
        }


        public int WorkOrderCode { get => workOrderCode; set => workOrderCode = value; }
        public int ProPlanCode { get => proPlanCode; set => proPlanCode = value; }
        public string OrderDate { get => orderDate; set => orderDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public int CCode { get => cCode; set => cCode = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public string MName { get => mName; set => mName = value; }
        public int Amount { get => amount; set => amount = value; }
        public string WorkStatus { get => workStatus; set => workStatus = value; }
    }
}
