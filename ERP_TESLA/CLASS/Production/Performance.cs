using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TESLA.CLASS.Production
{
    class Performance
    {
        int workOrderCode;
        int orderAmount;
        int perAmount;
        int passAmount;
        int failAmount;
        int workRemainder;
        double failRate;
        string oprCode;
        string manHour;
        int eCode;



        public Performance(int workOrderCode, int orderAmount, int perAmount, int passAmount, int failAmount, int workRemainder, double failRate, string oprCode, string manHour, int eCode)
        {
            this.workOrderCode = workOrderCode;
            this.orderAmount = orderAmount;
            this.perAmount = perAmount;
            this.passAmount = passAmount;
            this.failAmount = failAmount;
            this.workRemainder = workRemainder;
            this.failRate = failRate;
            this.oprCode = oprCode;
            this.manHour = manHour;
            this.eCode = eCode;
        }

        public Performance(int workOrderCode, int orderAmount, int perAmount, int passAmount, int failAmount, int workRemainder, double failRate, string oprCode, int eCode)
        {
            this.workOrderCode = workOrderCode;
            this.orderAmount = orderAmount;
            this.perAmount = perAmount;
            this.passAmount = passAmount;
            this.failAmount = failAmount;
            this.workRemainder = workRemainder;
            this.failRate = failRate;
            this.oprCode = oprCode;
            this.eCode = eCode;
        }

        public int WorkOrderCode { get => workOrderCode; set => workOrderCode = value; }
        public int OrderAmount { get => orderAmount; set => orderAmount = value; }
        public int PerAmount { get => perAmount; set => perAmount = value; }
        public int PassAmount { get => passAmount; set => passAmount = value; }
        public int FailAmount { get => failAmount; set => failAmount = value; }
        public int WorkRemainder { get => workRemainder; set => workRemainder = value; }
        public double FailRate { get => failRate; set => failRate = value; }
        public string OprCode { get => oprCode; set => oprCode = value; }
        public string ManHour { get => manHour; set => manHour = value; }
        public int ECode { get => eCode; set => eCode = value; }

    }
}
