using ERP_TESLA.CLASS.ETC;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ERP_TESLA.UI.Common
{
    public partial class EmployeePOP : Form
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

        string ecode;

        public EmployeePOP()
        {
            InitializeComponent();
        }

        int start = 1;
        int end = 10;

        public string Ecode { get => ecode; set => ecode = value; }

        // Panel 이동 (윈도우에서 끌고 오기) - 2
        private void pnTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void Employee_Load(object sender, EventArgs e)
        {
            Utility.Method.GridView gridview = new Utility.Method.GridView();
            gridview.gridViewStyleSet(dtgviewEmp);

            initEmpListView(start, end);
        }


        void initEmpListView(int start, int end)
        {
            dtgviewEmp.Rows.Clear();
            List<CLASS.HR.Employee> list = OraMgr.Instance.selectPOPemployee(start, end);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewEmp.Rows.Add(new string[]
                {
                    null,
                    list[i].Ecode.ToString(),
                    list[i].Ename.ToString(),
                    list[i].Departure.ToString(),
                    list[i].Grade.ToString()
                });
            }          
        }
        

        // 종료
        private void mainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 최소화
        private void mainMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                initEmpListView(start, end);
            }
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            if (dtgviewEmp.Rows.Count == 10)
            {
                start += 10;
                end += 10;
                initEmpListView(start, end);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgviewEmp.Rows.Count; i++)
            {
                if (dtgviewEmp.Rows[i].Cells[0].Value != null)
                {
                    this.ecode = dtgviewEmp.Rows[i].Cells[colECode.Index].Value.ToString();
                }
            }
            this.Close();
        }

        private void dtgviewEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dtgviewEmp.Rows)
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
