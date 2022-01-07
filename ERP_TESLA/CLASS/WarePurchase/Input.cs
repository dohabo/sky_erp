using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.WarePurchase
{
    class Input
    {
        string confirmdate;
        int pCode;
        int cCode;
        string cName;
        string mCode;
        string mCodeName;
        string inDate;
        int amount;
        string unit;
        int price;
        int supplyPrice;
        int vat;
        int sumPrice;
        int wCode;
        int confirm;

        public Input()
        {
        }
        public Input(int pCode, string mCode, string inDate, int amount)
        {
            this.pCode = pCode;
            this.mCode = mCode;
            this.inDate = inDate;
            this.amount = amount;
        }

        public Input(int pCode, int cCode, string cName, string mCode,
            string mCodeName, string inDate, int amount, string unit, int price, int supplyPrice, int vat, int sumPrice)
        {
            this.pCode = pCode;
            this.cCode = cCode;
            this.cName = cName;
            this.mCode = mCode;
            this.mCodeName = mCodeName;
            this.InDate = inDate;
            this.amount = amount;
            this.unit = unit;
            this.price = price;
            this.supplyPrice = supplyPrice;
            this.vat = vat;
            this.sumPrice = sumPrice;
        }
        public Input(string confirmdate, int pCode, int cCode, string cName, string mCode,
            string mCodeName, string inDate, int amount, string unit, int price, int supplyPrice, int vat, int sumPrice)
        {
            this.confirmdate = confirmdate;
            this.pCode = pCode;
            this.cCode = cCode;
            this.cName = cName;
            this.mCode = mCode;
            this.mCodeName = mCodeName;
            this.InDate = inDate;
            this.amount = amount;
            this.unit = unit;
            this.price = price;
            this.supplyPrice = supplyPrice;
            this.vat = vat;
            this.sumPrice = sumPrice;
        }

        public Input(int pCode, int cCode, string mCode,
            string mCodeName, int amount, string inDate, int wCode)
        {
            this.pCode = pCode;
            this.cCode = cCode;
            this.mCode = mCode;
            this.mCodeName = mCodeName;
            this.amount = amount;
            this.inDate = inDate;
            this.wCode = wCode;
        }

        public Input(int pCode, int cCode, string mCode,
            int amount, string inDate, int wCode)
        {
            this.pCode = pCode;
            this.cCode = cCode;
            this.mCode = mCode;
            this.amount = amount;
            this.inDate = inDate;
            this.wCode = wCode;
        }

        public int PCode { get => pCode; set => pCode = value; }
        public int CCode { get => cCode; set => cCode = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public string MCodeName { get => mCodeName; set => mCodeName = value; }
        public int Amount { get => amount; set => amount = value; }
        public string InDate { get => inDate; set => inDate = value; }
        public int WCode { get => wCode; set => wCode = value; }
        public int Confirm { get => confirm; set => confirm = value; }

        public void confirmedInputGridView(List<Input> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    null,
                    list[i].confirmdate.ToString(),
                    list[i].pCode.ToString(),
                    list[i].CCode.ToString(),
                    list[i].cName.ToString(),
                    list[i].mCode.ToString(),
                    list[i].mCodeName.ToString(),
                    list[i].inDate.ToString(),
                    list[i].amount.ToString(),
                    list[i].unit.ToString(),
                    list[i].price.ToString(),
                    list[i].supplyPrice.ToString(),
                    list[i].vat.ToString(),
                    list[i].sumPrice.ToString()
                }); ;
            }
        }

        public void noInputGridView(List<Input> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    null,
                    null,
                    list[i].pCode.ToString(),
                    list[i].CCode.ToString(),
                    list[i].cName.ToString(),
                    list[i].mCode.ToString(),
                    list[i].mCodeName.ToString(),
                    list[i].inDate.ToString(),
                    list[i].amount.ToString(),
                    list[i].unit.ToString(),
                    list[i].price.ToString(),
                    list[i].supplyPrice.ToString(),
                    list[i].vat.ToString(),
                    list[i].sumPrice.ToString()
                }); ;
            }
        }
    }
}
