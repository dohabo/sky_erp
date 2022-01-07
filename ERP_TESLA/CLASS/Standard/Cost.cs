using ERP_TESLA.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.Standard
{
    class Cost
    {
        string mCode;
        int price;

        public Cost()
        {
        }

        public Cost(string mCode, int price)
        {
            this.mCode = mCode;
            this.price = price;
        }

        public Cost(int price)
        {
            this.price = price;
        }

        public string MCode { get => mCode; set => mCode = value; }
        public int Price { get => price; set => price = value; }

        public void priceInfo(DataGridView dtgviewName, int cost)
        {
            for (int i = 0; i < dtgviewName.Rows.Count; i++)
            {
                if (dtgviewName.Rows[i].Cells[0].Value != null)
                {
                    string mcode = dtgviewName.Rows[i].Cells[0].Value.ToString();
                    List<Cost> priceInfo = OraMgr.Instance.selectPriceInfo(mcode);
                    dtgviewName.Rows[i].Cells[cost].Value = priceInfo[0].price;
                }
            }
        }
    }
}
