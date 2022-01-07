using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.WarePurchase
{
    class Stock
    {
        string mClass;
        string mCode;
        string mName;
        int amount;
        string unit;
        string standard;
        int wCode;

        public Stock()
        {
        }

        public Stock(string mClass, string mCode, string mName, 
            int amount, string unit, string standard, int wCode)
        {
            this.mClass = mClass;
            this.mCode = mCode;
            this.mName = mName;
            this.amount = amount;
            this.unit = unit;
            this.standard = standard;
            this.wCode = wCode;
        }

        public string MClass { get => mClass; set => mClass = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public string MName { get => mName; set => mName = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Standard { get => standard; set => standard = value; }
        public int WCode { get => wCode; set => wCode = value; }

        public void stockAllGridView(List<Stock> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].mClass,
                    list[i].mCode,
                    list[i].mName,
                    list[i].amount.ToString(),
                    list[i].unit,
                    list[i].standard,
                    list[i].wCode.ToString()
                });
            }
        }
    }
}
