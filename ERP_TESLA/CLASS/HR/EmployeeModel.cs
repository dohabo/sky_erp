using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TESLA.Model
{
    class EmployeeModel
    {
        private int eCode;
        private string eName;
        private string departure;
        private string grade;
        private string inDate;
        private string address;
        private string telNum;
        private string email;
        private string birth;

        public int ECode { get => eCode; set => eCode = value; }
        public string EName { get => eName; set => eName = value; }
        public string Departure { get => departure; set => departure = value; }
        public string Grade { get => grade; set => grade = value; }
        public string InDate { get => inDate; set => inDate = value; }
        public string Address { get => address; set => address = value; }
        public string TelNum { get => telNum; set => telNum = value; }
        public string Email { get => email; set => email = value; }
        public string Birth { get => birth; set => birth = value; }
    }
}
