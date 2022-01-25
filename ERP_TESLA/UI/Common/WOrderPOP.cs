using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.UI.Common
{
    public partial class WOrderPOP : Form
    {
        // Panel 이동 (윈도우에서 끌고 오기) - 1
#pragma warning disable CS0108
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x02;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg,
            int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
#pragma warning restore CS0108

        int start = 1;
        int end = 10;


        public WOrderPOP()
        {
            InitializeComponent();
        }

        // Panel 이동 (윈도우에서 끌고 오기) - 2
        private void pnTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {

        }

        private void btnMovePre_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
