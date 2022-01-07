using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.WarePurchase
{
    class TPOrder
    {
        int pCode;          //POrder
        int cCode;          //POrder
        string mCode;       //POrderDetail
        string mName;
        string standard;
        int amount;         //POrderDetail
        string unit;
        int price;          //POrderDetail
        int supplyPrice;    //POrderDetail
        int vat;            //POrderDetail
        int sumPrice;       //POrderDetail
        int eCode;          //POrder
        string pStatus;     //POrderDetail
        string pOrderDate;  //POrder
        string pOrderDateFrom;  //POrder
        string pOrderDateTo;  //POrder
        string inDueDate;   //POrderDetail
        string inDueDateFrom;   //POrderDetail
        string inDueDateTo;   //POrderDetail

        public TPOrder()
        {
        }

        public TPOrder(int pCode, int cCode, string mCode, string mName)
        {
            this.pCode = pCode;
            this.cCode = cCode;
            this.mCode = mCode;
            this.mName = mName;
        }

        public TPOrder(int pCode, int cCode, string mCode, int eCode, string pStatus,
            string pOrderDateFrom, string pOrderDateTo, string inDueDateFrom, string inDueDateTo)
        {
            this.pCode = pCode;
            this.pOrderDateFrom = pOrderDateFrom;
            this.pOrderDateTo = pOrderDateTo;
            this.cCode = cCode;
            this.mCode = mCode;
            this.inDueDateFrom = inDueDateFrom;
            this.inDueDateTo = inDueDateTo;
            this.eCode = eCode;
            this.pStatus = pStatus;
        }

        public TPOrder(int pCode, string pOrderDate, int cCode, string mCode, string mName, 
            string standard, int amount, string unit, string inDueDate, int price, int supplyPrice, 
            int vat, int sumPrice, int eCode, string pStatus)
        {
            this.pCode = pCode;
            this.cCode = cCode;
            this.mCode = mCode;
            this.mName = mName;
            this.standard = standard;
            this.amount = amount;
            this.unit = unit;
            this.price = price;
            this.supplyPrice = supplyPrice;
            this.vat = vat;
            this.sumPrice = sumPrice;
            this.eCode = eCode;
            this.pStatus = pStatus;
            this.pOrderDate = pOrderDate;
            this.inDueDate = inDueDate;
        }

        public int PCode { get => pCode; set => pCode = value; }
        public int CCode { get => cCode; set => cCode = value; }
        public int ECode { get => eCode; set => eCode = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public string MName { get => mName; set => mName = value; }
        public string Standard { get => standard; set => standard = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Unit { get => unit; set => unit = value; }
        public int Price { get => price; set => price = value; }
        public int SupplyPrice { get => supplyPrice; set => supplyPrice = value; }
        public int SumPrice { get => sumPrice; set => sumPrice = value; }
        public string PStatus { get => pStatus; set => pStatus = value; }
        public int VAT { get => vat; set => vat = value; }
        public string POrderDateFrom { get => pOrderDateFrom; set => pOrderDateFrom = value; }
        public string POrderDateTo { get => pOrderDateTo; set => pOrderDateTo = value; }
        public string InDueDateFrom { get => inDueDateFrom; set => inDueDateFrom = value; }
        public string InDueDateTo { get => inDueDateTo; set => inDueDateTo = value; }
        public string POrderDate { get => pOrderDate; set => pOrderDate = value; }
        public string InDueDate { get => inDueDate; set => inDueDate = value; }

        public void POrderAllGridView(List<TPOrder> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].pCode.ToString(),
                    list[i].POrderDate,
                    list[i].CCode.ToString(),
                    list[i].mCode,
                    list[i].mName,
                    list[i].standard,
                    list[i].amount.ToString(),
                    list[i].unit,
                    list[i].InDueDate,
                    list[i].price.ToString(),
                    list[i].supplyPrice.ToString(),
                    list[i].VAT.ToString(),
                    list[i].sumPrice.ToString(),
                    list[i].eCode.ToString(),
                    list[i].PStatus
                });
            }
        }
        public void POrderPNumGridView(List<TPOrder> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].pCode.ToString(),
                    list[i].CCode.ToString(),
                    list[i].mCode,
                    list[i].mName
                });
            }
        }
    }
}
