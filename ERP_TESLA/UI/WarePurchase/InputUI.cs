using ERP_TESLA.CLASS.Standard;
using ERP_TESLA.CLASS.WarePurchase;
using ERP_TESLA.DAO;
using ERP_TESLA.UI.Common;
using ERP_TESLA.Utility;
using ERP_TESLA.Utility.Fuction;
using ERP_TESLA.Utility.Method;
using ERP_TESLA.Utility.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.UI.WarePurchase
{
    /// <summary>
    /// name         : 자재 입고 관리
    /// function     : 자재 입고 처리
    ///                발주 내역이 존재해야 입고 처리 가능
    /// date of prep : 2022. 01. 03
    /// date of upd  : 
    /// </summary>
    public partial class InputUI : UserControl
    {
        Printing printing = new Printing();
        ExcelFunc exl = new ExcelFunc();
        TPOrder tp = new TPOrder();
        GridView gridview = new GridView();
        Material material = new Material();
        Input input = new Input();

        public InputUI()
        {
            InitializeComponent();
        }

        private void InputUI_Load(object sender, EventArgs e)
        {
            Date getdate = new Date();
            dtpicpOrderFrom.Text = getdate.getDateThisMonthFrom(dtpicpOrderFrom);
            dtpicpOrderTo.Text = getdate.getDateThisMonthTo(dtpicpOrderTo);
            dtpicInDueDateFrom.Text = getdate.getDateThisMonthFrom(dtpicInDueDateFrom);
            dtpicInDueDateTo.Text = getdate.getDateThisMonthTo(dtpicInDueDateTo);
            string[] PStatusContens = new string[] { "완납", "미납", "분할입고" };
            cbboxPStatus.Items.AddRange(PStatusContens);
            cbboxPStatus.Text = "미납";
            gridview.gridViewStyleSet(dtgviewOrderList); // GridView 헤더, 셀 폰트 세팅
            gridview.gridViewStyleSet(dtgviewInputAdd); // GridView 헤더, 셀 폰트 세팅
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewOrderList, "발주내역",dtpicpOrderFrom, dtpicpOrderTo);
        }

        private void btnpOrderSearch_Click(object sender, EventArgs e)
        {
            dtgviewOrderList.Rows.Clear();

            Dictionary<string, string> search = new Dictionary<string, string>();
            search.Add("pcode", tboxPCode.Text);
            search.Add("ccode", tboxCCode.Text);
            search.Add("pstatus", cbboxPStatus.Text);
            search.Add("mcode", tboxMCode.Text);
            search.Add("ecode", tboxECode.Text);

            Dictionary<string, string> searchCondition = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> pair in search)
            {
                if (pair.Value != "")
                {
                    searchCondition.Add(pair.Key, pair.Value);
                }
            }

            string[,] searchDate = new string[,]
            {
                {"porderdate", dtpicpOrderFrom.Text, dtpicpOrderTo.Text},
                {"induedate",dtpicInDueDateFrom.Text, dtpicInDueDateTo.Text}
            };

            List<TPOrder> tporder = OraMgr.Instance.selectTPOrder(searchCondition, searchDate);
            if(tporder.Count < 1)
            {
                MessageBox.Show("검색 조건에 해당하는 내역이 없습니다.");
            }
            tp.POrderAllGridView(tporder, dtgviewOrderList);
        }

        private void btnRefAdd_Click(object sender, EventArgs e)
        {
            List<TPOrder> list = new List<TPOrder>();
            if (dtgviewOrderList.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dtgviewOrderList.SelectedRows.Count; i++)
                {
                    int cNum = dtgviewOrderList.SelectedRows[i].Index;
                    TPOrder tporder =
                        new TPOrder(
                                int.Parse(dtgviewOrderList.Rows[cNum].Cells[0].Value.ToString()),
                                int.Parse(dtgviewOrderList.Rows[cNum].Cells[2].Value.ToString()),
                                dtgviewOrderList.Rows[cNum].Cells[3].Value.ToString(),
                                dtgviewOrderList.Rows[cNum].Cells[4].Value.ToString()
                            );

                    list.Add(tporder);
                }
                tp.POrderPNumGridView(list, dtgviewInputAdd);
            }
            else
            {
                MessageBox.Show("구매 목록에 해당 항목을 선택 후 버튼을 클릭 하세요.");
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgviewInputAdd.Rows.Clear();
        }

        private void printDocument1_PrintPage_POrder(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "구매 발주 내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewOrderList, cnt, pageNo);
        }

        private void btnPOrderPreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialInput, pdocInput, 0, 1);
        }

        private void btnPOrderPrinting_Click(object sender, EventArgs e)
        {

        }

        private void btnPOrderAdd_Click(object sender, EventArgs e)
        {
            string result = gridview.gridViewInputCheck(dtgviewInputAdd);
            if (result == "neededCheck")
            {
                return;
            }

            if (MessageBox.Show("입고 등록 하시겠습니까?", "입고등록 확인", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                for (int i = 0; i < dtgviewInputAdd.RowCount; i++)
                {
                    Input input =
                        new Input(
                                int.Parse(dtgviewInputAdd.Rows[i].Cells[0].Value.ToString()),
                                int.Parse(dtgviewInputAdd.Rows[i].Cells[1].Value.ToString()),
                                dtgviewInputAdd.Rows[i].Cells[2].Value.ToString(),
                                int.Parse(dtgviewInputAdd.Rows[i].Cells[4].Value.ToString()),
                                dtgviewInputAdd.Rows[i].Cells[5].Value.ToString(),
                                int.Parse(dtgviewInputAdd.Rows[i].Cells[6].Value.ToString())
                            );
                    OraMgr.Instance.insertInput(input);
                    OraMgr.Instance.updateStock(input);
                }
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("입고 등록 취소");
            }
        }

        private void btnChangeInDate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgviewInputAdd.Rows.Count; i++)
            {
                dtgviewInputAdd.Rows[i].Cells[5].Value = tboxInDate.Text;
            }
        }

        private void btnChangeWarehouse_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgviewInputAdd.Rows.Count; i++)
            {
                dtgviewInputAdd.Rows[i].Cells[6].Value = tboxWarehouse.Text;
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            dtgviewInputAdd.RowCount += 1;
        }

        private void btnQRcode_Click(object sender, EventArgs e)
        {
            List<Input> getinput = new List<Input>();
            QRCodeReaderUI qrreader = new QRCodeReaderUI();
            qrreader.ShowDialog();
            getinput = qrreader.Inputlist;
            for (int i = 0; i < getinput.Count; i++)
            {
                input.qrGridView(getinput, dtgviewInputAdd);
            }
        }

        private void btncCodeSearch_Click(object sender, EventArgs e)
        {
            CompanyPOP company = new CompanyPOP();
            company.ShowDialog();
            tboxCCode.Text = company.Ccode;
        }

        private void btneCodeSearch_Click(object sender, EventArgs e)
        {
            EmployeePOP employee = new EmployeePOP();
            employee.ShowDialog();
            tboxECode.Text = employee.Ecode;
        }

        private void btnmCodeSearch_Click(object sender, EventArgs e)
        {
            MaterialPOP material = new MaterialPOP();
            material.ShowDialog();
            tboxMCode.Text = material.Mcode;
        }
    }
}
