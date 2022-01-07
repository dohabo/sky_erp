using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.WarePurchase
{
    class InOut
    {
        string inout;
        string mClass;
        int number;
        string mCode;
        string mName;
        int amount;
        int wcode;
        string unit;
        string date;
        int price;
        int supplyPrice;
        int vat;
        int sumPrice;

        public InOut()
        {
        }

        public InOut(string inout, string mClass, int number, string mCode, string mName, 
            int amount, int wcode,string unit, string date, int price, int supplyPrice, 
            int vat, int sumPrice)
        {
            this.inout = inout;
            this.mClass = mClass;
            this.number = number;
            this.mCode = mCode;
            this.mName = mName;
            this.amount = amount;
            this.wcode = wcode;
            this.unit = unit;
            this.date = date;
            this.price = price;
            this.supplyPrice = supplyPrice;
            this.vat = vat;
            this.sumPrice = sumPrice;
        }

        public string MClass { get => mClass; set => mClass = value; }
        public int Number { get => number; set => number = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public string MName { get => mName; set => mName = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Date { get => date; set => date = value; }
        public int Price { get => price; set => price = value; }
        public int SupplyPrice { get => supplyPrice; set => supplyPrice = value; }
        public int Vat { get => vat; set => vat = value; }
        public int SumPrice { get => sumPrice; set => sumPrice = value; }

        public void inOutGridView(List<InOut> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].inout,
                    list[i].mClass,
                    list[i].number.ToString(),
                    list[i].mCode,
                    list[i].mName,
                    list[i].amount.ToString(),
                    list[i].wcode.ToString(),
                    list[i].unit,
                    list[i].date,
                    list[i].price.ToString(),
                    list[i].SupplyPrice.ToString(),
                    list[i].vat.ToString(),
                    list[i].sumPrice.ToString()
                });
            }
        }
    }
}
