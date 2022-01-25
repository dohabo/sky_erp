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
    /// name         : 매입 관리
    /// function     : 입고 처리 완료된 아이템들에 대해 확정하는 화면
    ///                확정 처리된 항목에 대해서만 원가 계산 가능
    /// date of prep : 2022. 01. 03
    /// date of upd  : 
    /// </summary>
    public partial class PurchaseMgtUI : UserControl
    {
        ExcelFunc exl = new ExcelFunc();
        Input input_ = new Input();
        Printing printing = new Printing();
        TextBox_ textbox = new TextBox_();
        public PurchaseMgtUI()
        {
            InitializeComponent();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewInputList, "입고 내역",dtpicpInFrom, dtpicpInTo);
        }

        private void PurchaseMgtUI_Load(object sender, EventArgs e)
        {
            Date getdate = new Date();
            dtpicpInFrom.Text = getdate.getDateThisMonthFrom(dtpicpInFrom);
            dtpicpInTo.Text = getdate.getDateThisMonthTo(dtpicpInTo);

            string[] confirm = new string[] { "확정","미확정"};
            cbboxStatus.Items.AddRange(confirm);
        }

        private void btnAllCheck_Click(object sender, EventArgs e)
        {
            if(dtgviewInputList.Rows.Count > 0)
            {
                for(int i = 0; i < dtgviewInputList.RowCount; i++)
                {
                    if (dtgviewInputList.Rows[i].Cells[colConfirm.Index].Value != null)
                    {
                        dtgviewInputList.Rows[i].Cells[colConfirm.Index].Value = null;
                    }
                    else
                    {
                        dtgviewInputList.Rows[i].Cells[colConfirm.Index].Value = true;
                    }
                }
            }
        }

        private void btnSumPrice_Click(object sender, EventArgs e)
        {
            int sumPrice = 0;
            if (dtgviewInputList.Rows.Count > 0)
            {
                for (int i = 0; i < dtgviewInputList.RowCount; i++)
                {
                    if (dtgviewInputList.Rows[i].Cells[colConfirm.Index].Value != null)
                    {
                        sumPrice += int.Parse(dtgviewInputList.Rows[i].Cells[colSumPrice.Index].Value.ToString());
                    }
                }
                tboxSumPrice.Text = sumPrice.ToString();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgviewInputList.RowCount; i++)
            {
                if (dtgviewInputList.Rows[i].Cells[colConfirm.Index].Value != null)
                {
                    Input input = new Input(
                        int.Parse(dtgviewInputList.Rows[i].Cells[colPOrder.Index].Value.ToString()),
                        dtgviewInputList.Rows[i].Cells[colMCode.Index].Value.ToString(),
                        dtgviewInputList.Rows[i].Cells[colInDate.Index].Value.ToString(),
                        int.Parse(dtgviewInputList.Rows[i].Cells[colAmount.Index].Value.ToString())
                        );
                    OraMgr.Instance.updateInputConfirm(input);

                    Buying buying = new Buying(
                        dtgviewInputList.Rows[i].Cells[colConfirmDate.Index].Value.ToString(),
                        int.Parse(dtgviewInputList.Rows[i].Cells[colPOrder.Index].Value.ToString()),
                        int.Parse(dtgviewInputList.Rows[i].Cells[colCCode.Index].Value.ToString()),
                        dtgviewInputList.Rows[i].Cells[colMCode.Index].Value.ToString(),
                        int.Parse(dtgviewInputList.Rows[i].Cells[colAmount.Index].Value.ToString()),
                        int.Parse(dtgviewInputList.Rows[i].Cells[colPrice.Index].Value.ToString()),
                        int.Parse(dtgviewInputList.Rows[i].Cells[colSupplyPrice.Index].Value.ToString()),
                        int.Parse(dtgviewInputList.Rows[i].Cells[colVat.Index].Value.ToString()),
                        int.Parse(dtgviewInputList.Rows[i].Cells[colSumPrice.Index].Value.ToString())
                        );
                    OraMgr.Instance.insertBuying(buying);
                }
            }
        }

        private void btnChangeConfirmDate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgviewInputList.RowCount; i++)
            {
                dtgviewInputList.Rows[i].Cells[colConfirmDate.Index].Value = tboxConfirmDate.Text;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgviewInputList.Rows.Clear();

            Dictionary<string, string> search = new Dictionary<string, string>();
            search.Add("pcode", tboxPCode.Text);
            search.Add("mcode", tboxMCode.Text);
            search.Add("ccode", tboxCCode.Text);

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
                {"indate", dtpicpInFrom.Text, dtpicpInTo.Text}
            };
            List<Input> input = new List<Input>();
            int grdviewCount = 0;
            if (cbboxStatus.Text == "미확정")
            {
                input = OraMgr.Instance.selectNoConfirmedInput(searchCondition, searchDate);
                grdviewCount = int.Parse(input.Count.ToString());
                MessageBox_.Instance.grdviewCount(grdviewCount);
                input_.noInputGridView(input, dtgviewInputList);
            }
            else if (cbboxStatus.Text == "확정")
            {
                input = OraMgr.Instance.selectConfirmedInput(searchCondition, searchDate);
                grdviewCount = int.Parse(input.Count.ToString());
                MessageBox_.Instance.grdviewCount(grdviewCount);
                input_.confirmedInputGridView(input, dtgviewInputList);
            }
            
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialInput, pdocInput, 0, 1);
        }

        private void btnPrinting_Click(object sender, EventArgs e)
        {
            if (pdialInput.ShowDialog() == DialogResult.OK)
            {
                pdocInput.Print();
            }
        }

        private void pdocInput_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "구매 발주 내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewInputList, cnt, pageNo);
        }

        private void tboxSumPrice_TextChanged(object sender, EventArgs e)
        {
            textbox.comma(tboxSumPrice);
        }

        private void btncCodeSearch_Click(object sender, EventArgs e)
        {
            CompanyPOP company = new CompanyPOP();
            company.ShowDialog();
            tboxCCode.Text = company.Ccode;
        }

        private void btnmCodeSearch_Click(object sender, EventArgs e)
        {
            MaterialPOP material = new MaterialPOP();
            material.ShowDialog();
            tboxMCode.Text = material.Mcode;

        }
    }
}
