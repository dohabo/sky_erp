using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TESLA.CLASS.Standard
{
    class Company
    {
        int cCode;
        string cName;
        string ceoName;
        string regNum;
        string address;
        string telNum;

        public Company(int cCode, string cName, string ceoName, string regNum, string address, string telNum)
        {
            this.cCode = cCode;
            this.cName = cName;
            this.ceoName = ceoName;
            this.regNum = regNum;
            this.address = address;
            this.telNum = telNum;
        }

        public Company(string cName, string ceoName, string regNum, string address, string telNum)
        {
            this.cName = cName;
            this.ceoName = ceoName;
            this.regNum = regNum;
            this.address = address;
            this.telNum = telNum;
        }


        public int CCode { get => cCode; set => cCode = value; }
        public string CName { get => cName; set => cName = value; }
        public string CeoName { get => ceoName; set => ceoName = value; }
        public string RegNum { get => regNum; set => regNum = value; }
        public string Address { get => address; set => address = value; }
        public string TelNum { get => telNum; set => telNum = value; }
    }
}
