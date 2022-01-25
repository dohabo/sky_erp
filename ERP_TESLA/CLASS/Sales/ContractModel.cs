using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.Model
{
    class ContractModel
    {
        int sOrderCode;
        string sOrderDate;
        int cCode;       
        int manager;
        string mCode;
        string mCodeName;
        string unit;
        int amount;
        string deliveryDate;       
        int price;
        int supplyPrice;
        int vat;
        int sumPrice;
        string salesStatus;

        public ContractModel()
        {
        }

        public ContractModel(int sOrderCode, string sOrderDate, int cCode, 
            int manager, string mCode, int amount, string deliveryDate, 
            int price, int supplyPrice, int vat, int sumPrice)
        {
            this.sOrderCode = sOrderCode;
            this.sOrderDate = sOrderDate;
            this.cCode = cCode;
            this.manager = manager;
            this.mCode = mCode;
            this.amount = amount;
            this.deliveryDate = deliveryDate;
            this.price = price;
            this.supplyPrice = supplyPrice;
            this.vat = vat;
            this.sumPrice = sumPrice;
        }

        public ContractModel(int sOrderCode, string sOrderDate, int cCode, 
            int manager, string mCode, string deliveryDate, int price, 
            int supplyPrice, int vat, int sumPrice)
        {
            this.sOrderCode = sOrderCode;
            this.sOrderDate = sOrderDate;
            this.cCode = cCode;
            this.manager = manager;
            this.mCode = mCode;
            this.deliveryDate = deliveryDate;
            this.price = price;
            this.supplyPrice = supplyPrice;
            this.vat = vat;
            this.sumPrice = sumPrice;
        }

        public ContractModel(int sOrderCode, string sOrderDate, int cCode, 
            int manager, string mCode, string unit, int amount, 
            string deliveryDate, int price, int supplyPrice, int vat, int sumPrice)
        {
            this.sOrderCode = sOrderCode;
            this.sOrderDate = sOrderDate;
            this.cCode = cCode;
            this.manager = manager;
            this.mCode = mCode;
            this.unit = unit;
            this.amount = amount;
            this.deliveryDate = deliveryDate;
            this.price = price;
            this.supplyPrice = supplyPrice;
            this.vat = vat;
            this.sumPrice = sumPrice;
        }

        public ContractModel(string sOrderDate, int cCode, int manager, 
            string mCode, int amount, 
            string deliveryDate, int price, int supplyPrice, int vat, int sumPrice)
        {
            this.sOrderDate = sOrderDate;
            this.cCode = cCode;
            this.manager = manager;
            this.mCode = mCode;
            this.amount = amount;
            this.deliveryDate = deliveryDate;
            this.price = price;
            this.supplyPrice = supplyPrice;
            this.vat = vat;
            this.sumPrice = sumPrice;
        }

        public ContractModel(int sOrderCode, string sOrderDate, int cCode, 
            int manager, string mCode, string mCodeName, string unit, 
            int amount, string deliveryDate, int price, int supplyPrice, int vat, int sumPrice, string salesStatus)
        {
            this.sOrderCode = sOrderCode;
            this.sOrderDate = sOrderDate;
            this.cCode = cCode;
            this.manager = manager;
            this.mCode = mCode;
            this.mCodeName = mCodeName;
            this.unit = unit;
            this.amount = amount;
            this.deliveryDate = deliveryDate;
            this.price = price;
            this.supplyPrice = supplyPrice;
            this.vat = vat;
            this.sumPrice = sumPrice;
            this.salesStatus = salesStatus;
        }

        public int SOrderCode { get => sOrderCode; set => sOrderCode = value; }
        public string SOrderDate { get => sOrderDate; set => sOrderDate = value; }
        public int CCode { get => cCode; set => cCode = value; }
        public int Manager { get => manager; set => manager = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public string MCodeName { get => mCodeName; set => mCodeName = value; }
        public string Unit { get => unit; set => unit = value; }
        public int Amount { get => amount; set => amount = value; }
        public string DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public int Price { get => price; set => price = value; }
        public int SupplyPrice { get => supplyPrice; set => supplyPrice = value; }
        public int Vat { get => vat; set => vat = value; }
        public int SumPrice { get => sumPrice; set => sumPrice = value; }

        public void ContractdataGridView(List<ContractModel> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                bool check = false;
                if(list[i].salesStatus.ToString() == "1")
                {
                    check = true;
                }
                dtgview.Rows.Add(new string[]
                {
                    check.ToString(),
                    list[i].sOrderCode.ToString(),
                    list[i].sOrderDate.ToString(),
                    list[i].cCode.ToString(),
                    list[i].manager.ToString(),
                    list[i].mCode.ToString(),
                    list[i].mCodeName.ToString(),
                    list[i].unit.ToString(),
                    list[i].amount.ToString(),
                    list[i].deliveryDate.ToString(),
                    list[i].price.ToString(),
                    list[i].supplyPrice.ToString(),
                    list[i].vat.ToString(),
                    list[i].sumPrice.ToString()
                }); ; ;
            }
        }
    }
}
