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
    public partial class EmployeePopup : Form
    {
        public EmployeePopup()
        {
            InitializeComponent();                      
        }
        public EmployeePopup(int x, int y) 
        {
            InitializeComponent();
            this.Location = new Point(x, y);
        }

        private void btnMovePre_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // select 값이 없으면 return; 있으면 textbox에 담고 폼 닫기
        }
    }
}
