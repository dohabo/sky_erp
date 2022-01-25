using ERP_TESLA.CLASS.Standard;
using ERP_TESLA.DAO;
using ERP_TESLA.UI.Production;
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
    public partial class MaterialPOP : Form
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

        string mcode;

        int start = 1;
        int end = 10;

        string mClass = "";

        public string Mcode { get => mcode; set => mcode = value; }

        public MaterialPOP()
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

        private void MaterialPOP_Load(object sender, EventArgs e)
        {
            Utility.Method.GridView gridview = new Utility.Method.GridView();
            gridview.gridViewStyleSet(dtgviewMat);

            initMatListView(start, end, mClass);
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmCodeSearch_Click(object sender, EventArgs e)
        {
            mClass = cboxmClass.SelectedItem.ToString();
            start = 1;
            end = 10;
            initMatListView(start, end, mClass);
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            if (dtgviewMat.Rows.Count == 10)
            {
                start += 10;
                end += 10;                
                initMatListView(start, end, mClass);
            }
        }

        private void btnMovePre_Click(object sender, EventArgs e)
        {
            if (start < 2)
            {
                return;
            }
            else
            {
                start -= 10;
                end -= 10;
                initMatListView(start, end, mClass);
            }
        }

        void initMatListView(int start, int end, string mClass)
        {
            dtgviewMat.Rows.Clear();
            List<Material> list = OraMgr.Instance.selectPOPmaterial(start, end, mClass);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewMat.Rows.Add(new string[]
                {
                    null,
                    list[i].MCode.ToString(),
                    list[i].MClass.ToString(),
                    list[i].MName.ToString(),
                    list[i].Standard.ToString(),
                    list[i].Unit.ToString()

                });
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgviewMat.Rows.Count; i++)
            {
                if (dtgviewMat.Rows[i].Cells[0].Value != null)
                {
                    this.mcode = dtgviewMat.Rows[i].Cells[colMCode.Index].Value.ToString();
                }
            }
            this.Close();
        }
    }
}
