using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.WarePurchase
{
    class POrderDetail
    {
        int pCode;
        string mCode;
        string mName;
        string standard;
        int amount;
        string unit;
        string inDueDate;
        int price;
        int supplyPrice;
        int vat;
        int sumPrice;

        public POrderDetail()
        {
        }

        public POrderDetail(string mCode, string mName, string standard, 
            int amount, string unit, string inDueDate, int price, int supplyPrice, int vat, int sumPrice)
        {
            this.mCode = mCode;
            this.mName = mName;
            this.standard = standard;
            this.amount = amount;
            this.unit = unit;
            this.inDueDate = inDueDate;
            this.price = price;
            this.supplyPrice = supplyPrice;
            this.vat = vat;
            this.sumPrice = sumPrice;
        }

        public POrderDetail(int pCode, string mCode, string mName, string standard, int amount, 
            string unit, string inDueDate, int price, int supplyPrice, int vat, int sumPrice)
        {
            this.pCode = pCode;
            this.mCode = mCode;
            this.mName = mName;
            this.standard = standard;
            this.amount = amount;
            this.unit = unit;
            this.inDueDate = inDueDate;
            this.price = price;
            this.supplyPrice = supplyPrice;
            this.vat = vat;
            this.sumPrice = sumPrice;
        }

        public POrderDetail(string mCode, int amount, 
            string inDueDate, int price, int supplyPrice, int vat, int sumPrice)
        {
            this.mCode = mCode;
            this.amount = amount;
            this.inDueDate = inDueDate;
            this.price = price;
            this.supplyPrice = supplyPrice;
            this.vat = vat;
            this.sumPrice = sumPrice;
        }

        public string MCode { get => mCode; set => mCode = value; }
        public string MName { get => mName; set => mName = value; }
        public string Standard { get => standard; set => standard = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Unit { get => unit; set => unit = value; }
        public string InDueDate { get => inDueDate; set => inDueDate = value; }
        public int Price { get => price; set => price = value; }
        public int SupplyPrice { get => supplyPrice; set => supplyPrice = value; }
        public int VAT { get => vat; set => vat = value; }
        public int SumPrice { get => sumPrice; set => sumPrice = value; }
        public int PCode { get => pCode; set => pCode = value; }

        public void POrderDetailGridView(List<POrderDetail> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].mCode,
                    list[i].mName,
                    list[i].standard,
                    list[i].amount.ToString(),
                    list[i].unit,
                    list[i].inDueDate,
                    list[i].price.ToString(),
                    list[i].supplyPrice.ToString(),
                    list[i].VAT.ToString(),
                    list[i].sumPrice.ToString()
                });
            }
        }
    }
}
