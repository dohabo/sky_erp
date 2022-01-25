using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.PoPUP
{
    public partial class sOrderPopup : Form
    {
        public sOrderPopup()
        {
            InitializeComponent();           
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);// startposition: 폼 안 
        }

    }
}
