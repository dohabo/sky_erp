using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.Cost
{
    class ProductCost
    {
        string mcode;
        string mname;
        string standard;
        int passamount;
        int failamount;
        string enddateFrom;
        string enddateTo;

        public ProductCost()
        {
        }

        public ProductCost(string mcode, string mname, string standard, int passamount, int failamount)
        {
            this.mcode = mcode;
            this.mname = mname;
            this.standard = standard;
            this.passamount = passamount;
            this.failamount = failamount;
        }

        public void mcodeCostGridView(List<ProductCost> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].mcode,
                    list[i].mname,
                    list[i].standard,
                    list[i].passamount.ToString(),
                    list[i].failamount.ToString(),
                });
            }
        }
    }
}
