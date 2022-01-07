using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.WarePurchase
{
    class POrder
    {
        int pCode;
        string pOrderDate;
        int cCode;
        int eCode;

        public POrder(string pOrderDate, int cCode, int eCode)
        {
            this.pOrderDate = pOrderDate;
            this.cCode = cCode;
            this.eCode = eCode;
        }

        public POrder(int pCode, string pOrderDate, int cCode, int eCode)
        {
            this.pCode = pCode;
            this.pOrderDate = pOrderDate;
            this.cCode = cCode;
            this.eCode = eCode;
        }
        public int PCode { get => pCode; set => pCode = value; }
        public string POrderDate { get => pOrderDate; set => pOrderDate = value; }
        public int CCode { get => cCode; set => cCode = value; }
        public int ECode { get => eCode; set => eCode = value; }
    }
}
