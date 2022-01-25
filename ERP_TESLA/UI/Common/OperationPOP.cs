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
    public partial class OperationPOP : Form
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
        string operationcode;

        public string Operationcode { get => operationcode; set => operationcode = value; }

        public OperationPOP()
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

        private void OperationPOP_Load(object sender, EventArgs e)
        {
            Utility.Method.GridView gridview = new Utility.Method.GridView();
            gridview.gridViewStyleSet(dtgviewOpr);

            initMatListView(start, end);
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
            if (dtgviewOpr.Rows.Count == 10)
            {
                start += 10;
                end += 10;
                initMatListView(start, end);
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
                initMatListView(start, end);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgviewOpr.Rows.Count; i++)
            {
                if (dtgviewOpr.Rows[i].Cells[0].Value != null)
                {
                    this.operationcode = dtgviewOpr.Rows[i].Cells[colOperationCode.Index].Value.ToString();
                }
            }
            this.Close();
        }

        void initMatListView(int start, int end)
        {
            dtgviewOpr.Rows.Clear();
            List<Operation> list = OraMgr.Instance.selectPOPoperation(start, end);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewOpr.Rows.Add(new string[]
                {
                    null,
                    list[i].OprCode.ToString(),
                    list[i].OprName.ToString(),
                    list[i].OprDescription.ToString(),
                    list[i].OprManHour.ToString()

                });
            }
        }

        private void dtgviewOpr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dtgviewOpr.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["CheckBoxColumn"].Value = !Convert.ToBoolean(row.Cells["CheckBoxColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["CheckBoxColumn"].Value = false;
                    }
                }
            }
        }
    }
}
