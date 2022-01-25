using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.HR
{
    class Employee
    {
        int ecode;
        string ename;
        string departure;
        string grade;

        public Employee(string departure)
        {
            this.departure = departure;
        }

        public Employee()
        {
        }

        public Employee(int ecode, string ename, string departure)
        {
            this.ecode = ecode;
            this.ename = ename;
            this.departure = departure;
        }

        public Employee(int ecode, string ename, string departure, string grade)
        {
            this.ecode = ecode;
            this.ename = ename;
            this.departure = departure;
            this.grade = grade;
        }

        public string Departure { get => departure; set => departure = value; }
        public int Ecode { get => ecode; set => ecode = value; }
        public string Ename { get => ename; set => ename = value; }
        public string Grade { get => grade; set => grade = value; }

        public void employeeGridView(List<Employee> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].ecode.ToString(),
                    list[i].ename,
                    list[i].departure
                });
            }
        }
    }
}
