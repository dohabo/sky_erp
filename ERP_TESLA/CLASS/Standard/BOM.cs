using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.Standard
{
    class BOM
    {
        string pmcode;
        string pmname;
        string pmstandrd;
        string pmunit;
        string cmcode;
        string cmname;
        string cmstandrd;
        string cmunit;
        int amount;

        public string Pmcode { get => pmcode; set => pmcode = value; }
        public string Pmname { get => pmname; set => pmname = value; }
        public string Pmstandrd { get => pmstandrd; set => pmstandrd = value; }
        public string Pmunit { get => pmunit; set => pmunit = value; }
        public string Cmcode { get => cmcode; set => cmcode = value; }
        public string Cmname { get => cmname; set => cmname = value; }
        public string Cmstandrd { get => cmstandrd; set => cmstandrd = value; }
        public string Cmunit { get => cmunit; set => cmunit = value; }
        public int Amount { get => amount; set => amount = value; }

        public BOM()
        {
        }

        public BOM(string pmcode, string pmname, string cmcode, 
            string cmname, int amount, string cmstandrd, 
            string cmunit)
        {
            this.pmcode = pmcode;
            this.pmname = pmname;
            this.cmcode = cmcode;
            this.cmname = cmname;
            this.amount = amount;
            this.cmstandrd = cmstandrd;
            this.cmunit = cmunit;
        }

        public BOM(string pmcode, string cmcode, int amount)
        {
            this.pmcode = pmcode;
            this.cmcode = cmcode;
            this.amount = amount;
        }

        public BOM(string pmcode, string pmname, string pmstandrd, string pmunit)
        {
            this.pmcode = pmcode;
            this.pmname = pmname;
            this.pmstandrd = pmstandrd;
            this.pmunit = pmunit;
        }

        public BOM(string cmcode, string cmname, string cmstandrd, string cmunit, int amount)
        {
            this.cmcode = cmcode;
            this.cmname = cmname;
            this.cmstandrd = cmstandrd;
            this.cmunit = cmunit;
            this.amount = amount;
        }

        public void pbomGridView(List<BOM> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].pmcode,
                    list[i].pmname,
                    list[i].pmstandrd,
                    list[i].pmunit
                });
            }
        }
        public void cbomGridView(List<BOM> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].cmcode,
                    list[i].cmname,
                    list[i].cmstandrd,
                    list[i].cmunit,
                    list[i].amount.ToString()
                });
            }
        }
        public void rcbomGridView(List<BOM> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].pmcode,
                    list[i].pmname,
                    list[i].cmcode,
                    list[i].cmname,
                    list[i].amount.ToString(),
                    list[i].cmstandrd,
                    list[i].cmunit
                });
            }
        }
    }
}
