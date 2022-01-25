using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;

namespace ERP_TESLA.PoPUP
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AddressPopup : Form
    {
        public string gstrZipCode = "";       
        public string gstrAddress1 = "";
        
        public AddressPopup()
        {
            InitializeComponent();
            
            webBrowser1.Navigate("https://iloveyouoooo.neocities.org");
            webBrowser1.ObjectForScripting = this;            
        }
        public void CallForm(object sZipCode, object sAddress1)
        {
            try
            {
                gstrZipCode = sZipCode.ToString();
                gstrAddress1 = sAddress1.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        



        #region "Message"
        public void Base_Message(Exception ex)
        {
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
        }

        public void Base_Message(string messgage)
        {
            MessageBox.Show(messgage, "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }

        #endregion
    }
}
