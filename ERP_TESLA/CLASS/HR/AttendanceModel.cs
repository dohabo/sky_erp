using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.Model.HR
{
    class AttendanceModel
    {
        int eCode;
        string eName;
        string departure;
        string grade;
        int attendYear;
        int attendMonth;
        int vacationDays;
        int sickDays;
        int workingDays;

        public AttendanceModel(int eCode, string eName, string departure, string grade, int attendYear, int attendMonth, int vacationDays, int sickDays, int workingDays)
        {
            this.eCode = eCode;
            this.eName = eName;
            this.departure = departure;
            this.grade = grade;
            this.attendYear = attendYear;
            this.attendMonth = attendMonth;
            this.vacationDays = vacationDays;
            this.sickDays = sickDays;
            this.workingDays = workingDays;
        }

        public int ECode { get => eCode; set => eCode = value; }
        public string EName { get => eName; set => eName = value; }
        public string Departure { get => departure; set => departure = value; }
        public string Grade { get => grade; set => grade = value; }
        public int AttendYear { get => attendYear; set => attendYear = value; }
        public int AttendMonth { get => attendMonth; set => attendMonth = value; }
        public int VacationDays { get => vacationDays; set => vacationDays = value; }
        public int SickDays { get => sickDays; set => sickDays = value; }
        public int WorkingDays { get => workingDays; set => workingDays = value; }

        public void AttendanceGridView(List<AttendanceModel> list, DataGridView dtgview)
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
                    list[i].vacationDays.ToString(),
                    list[i].sickDays.ToString(),
                    list[i].workingDays.ToString()
                });
            }
        }
    }
}
