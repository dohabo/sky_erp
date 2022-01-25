using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.ETC
{
    class BarCode
    {
        int pCode;
        int cCode;
        string mCode;
        string mCodeName;
        int amount;

        public BarCode(int pCode, int cCode, string mCode, int amount)
        {
            this.pCode = pCode;
            this.cCode = cCode;
            this.mCode = mCode;
            this.amount = amount;
        }

        public BarCode(int pCode, int cCode, string mCode, string mCodeName, int amount)
        {
            this.pCode = pCode;
            this.cCode = cCode;
            this.mCode = mCode;
            this.mCodeName = mCodeName;
            this.amount = amount;
        }

        public int PCode { get => pCode; set => pCode = value; }
        public int CCode { get => cCode; set => cCode = value; }
        public string MCode { get => mCode; set => mCode = value; }
        public string MCodeName { get => mCodeName; set => mCodeName = value; }
        public int Amount { get => amount; set => amount = value; }

        public void qrGridView(List<BarCode> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].pCode.ToString(),
                    list[i].cCode.ToString(),
                    list[i].mCode.ToString(),
                    list[i].amount.ToString()
                }); ;
            }
        }

        public void qrGridViews(List<BarCode> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].pCode.ToString(),
                    list[i].cCode.ToString(),
                    list[i].mCode.ToString(),
                    list[i].mCodeName.ToString(),
                    list[i].amount.ToString()
                }); ;
            }
        }
    }
}
