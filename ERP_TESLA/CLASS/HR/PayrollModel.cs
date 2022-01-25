using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.Model.HR
{
    class PayrollModel
    {
        int eCode;
        string eName;
        string departure;
        string grade;
        int attendYear;
        int attendMonth;
        string payMentDate;
        int workingDays;
        int payMentStandard;
        int payMenttotal;

        public PayrollModel()
        {
        }

        public PayrollModel(int eCode, string eName, string departure, string grade, int attendYear, int attendMonth, string payMentDate, int workingDays, int payMentStandard, int payMenttotal)
        {
            this.eCode = eCode;
            this.eName = eName;
            this.departure = departure;
            this.grade = grade;
            this.attendYear = attendYear;
            this.attendMonth = attendMonth;
            this.payMentDate = payMentDate;
            this.workingDays = workingDays;
            this.payMentStandard = payMentStandard;
            this.payMenttotal = payMenttotal;
        }

        public int ECode { get => eCode; set => eCode = value; }
        public string EName { get => eName; set => eName = value; }
        public string Departure { get => departure; set => departure = value; }
        public string Grade { get => grade; set => grade = value; }
        public int AttendYear { get => attendYear; set => attendYear = value; }
        public int AttendMonth { get => attendMonth; set => attendMonth = value; }
        public string PayMentDate { get => payMentDate; set => payMentDate = value; }
        public int WorkingDays { get => workingDays; set => workingDays = value; }
        public int PayMentStandard { get => payMentStandard; set => payMentStandard = value; }
        public int PayMenttotal { get => payMenttotal; set => payMenttotal = value; }

        public void PayrollGridView(List<PayrollModel> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].eCode.ToString(),
                    list[i].eName,
                    list[i].departure,
                    list[i].grade,
                    list[i].attendYear.ToString(),
                    list[i].attendMonth.ToString(),
                    list[i].payMentDate,
                    list[i].workingDays.ToString(),
                    list[i].payMentStandard.ToString(),
                    list[i].payMenttotal.ToString()
                });
            }
        }
    }
}
