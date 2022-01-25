using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.UI
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }

        private void loginOK_Click(object sender, EventArgs e)
        {
            Close();
        }
        public string id()
        {
            string idNum = user.Text;
            return idNum;
        }

        private void loginCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
