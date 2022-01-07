using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_TESLA.CLASS.WarePurchase
{
    class Buying
    {
        string confirmDate;
        int pCode;
        int cCode;
        string mCode;
        int amount;
        int price;
        int supplyPrice;
        int VAT;
        int sumPrice;

        public Buying(string confirmDate, int pCode, int cCode, string mCode, 
            int amount, int price, int supplyPrice, int vAT, int sumPrice)
        {
            this.confirmDate = confirmDate;
            this.pCode = pCode;
            this.cCode = cCode;
            this.mCode = mCode;
            this.amount = amount;
            this.price = price;
            this.supplyPrice = supplyPrice;
            VAT = vAT;
            this.sumPrice = sumPrice;
        }

        public string ConfirmDate { get => confirmDate; set => confirmDate = value; }
        public int PCode { get => pCode; set => pCode = value; }
        public int CCode { get => cCode; set => cCode = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Price { get => price; set => price = value; }
        public int SupplyPrice { get => supplyPrice; set => supplyPrice = value; }
        public int VAT1 { get => VAT; set => VAT = value; }
        public int SumPrice { get => sumPrice; set => sumPrice = value; }
    }
}
