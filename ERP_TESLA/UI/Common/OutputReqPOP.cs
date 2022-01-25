using ERP_TESLA.CLASS.Production;
using ERP_TESLA.DAO;
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
    public partial class OutputReqPOP : Form
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
        string reqcode;

        public string Reqcode { get => reqcode; set => reqcode = value; }

        public OutputReqPOP()
        {
            InitializeComponent();
        }

        private void OutputReqPOP_Load(object sender, EventArgs e)
        {
            Utility.Method.GridView gridview = new Utility.Method.GridView();
            gridview.gridViewStyleSet(dtgviewReqList);

            initReqListView(start, end);
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
            for (int i = 0; i < dtgviewReqList.Rows.Count; i++)
            {
                if (dtgviewReqList.Rows[i].Cells[0].Value != null)
                {
                    this.reqcode = dtgviewReqList.Rows[i].Cells[colReqCode.Index].Value.ToString();
                }
            }
            this.Close();
            
        }

        /// <summary>
        /// 여기서 부터 하기
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// 

        void initReqListView(int start, int end)
        {
            dtgviewReqList.Rows.Clear();
            List<OutputReq> list = OraMgr.Instance.selectPOPrequest(start, end);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewReqList.Rows.Add(new string[]
                {
                    null,
                    list[i].ReqCode.ToString(),
                    list[i].WorkOrderCode.ToString(),
                    list[i].PMCode1.ToString(),
                    list[i].PCodeName.ToString(),
                    list[i].MMCode1.ToString(),
                    list[i].MCodeName.ToString(),
                    list[i].OprCode.ToString(),
                    list[i].Amount.ToString(),
                    list[i].ReqDate.ToString(),
                    list[i].ReqStatus.ToString(),
                    list[i].ECode.ToString()
            });
            }
        }

        private void dtgviewReqList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dtgviewReqList.Rows)
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
