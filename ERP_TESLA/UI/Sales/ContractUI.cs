using ERP_TESLA.DAO;
using ERP_TESLA.Utility;
using ERP_TESLA.Utility.Fuction;
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
using System.Data.OleDb;
using ERP_TESLA.PoPUP;
using ERP_TESLA.Utility.Method;
using ERP_TESLA.Model;

namespace ERP_TESLA.UI.Sales
{
    public partial class ContractUI : UserControl
    {
        ExcelFunc exl = new ExcelFunc();
        Printing printing = new Printing();
        ContractModel contractmodel = new ContractModel();
        public ContractUI()
        {
            InitializeComponent();
        }
        private void ContractUI_Load(object sender, EventArgs e)
        {
            Date getdate = new Date();
            dtpicpInFrom.Text = getdate.getDateThisMonthFrom(dtpicpInFrom);
            dtpicpInTo.Text = getdate.getDateThisMonthTo(dtpicpInTo);
            List<ContractModel> contract = OraMgr.Instance.selectContract();
            contractmodel.ContractdataGridView(contract, dtgviewcMgtDtl);
        }
        #region 조회 파트
        // (주문 번호 조회)
        private void btnsOrdCode_Click(object sender, EventArgs e)
        {
            OrderPopup orderPopup = new OrderPopup();
            orderPopup.Show();
        }
        // 계약 조회 
        private void btnsConSch_Click(object sender, EventArgs e)
        {
            //dtgviewcMgtDtl.Rows.Clear();

            //Dictionary<string, string> search = new Dictionary<string, string>();
            //search.Add("sOrderCode", tboxsOrdCode.Text);

            //string[,] searchDate = new string[,]
            //{
            //    {"porderdate", dtpicpInFrom.Text, dtpicpInTo.Text},
            //};

            //List<TPOrder> tporder = OraMgr.Instance.selectTPOrder(searchCondition, searchDate);
            //if (tporder.Count < 1)
            //{
            //    MessageBox.Show("검색 조건에 해당하는 내역이 없습니다.");
            //}
            //tp.POrderAllGridView(tporder, dtgviewOrderList);
        }
        #endregion
        
        #region 등록파트

        private void btnComCode_Click(object sender, EventArgs e)
        {
            CompanyPopup companyPopup = new CompanyPopup();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeePopup employeePopup = new EmployeePopup();
        }
        private void btnsConAdd_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("입고 등록 하시겠습니까?", "입고등록 확인", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                ContractModel contractModel = new ContractModel(
                    dtPicOrderDate.Text,
                    int.Parse(tboxComCode.Text),
                    int.Parse(tboxEmployee.Text),
                    tboxMCode.Text,
                    int.Parse(tboxAmount.Text),
                    dtpicEndDate.Text,
                    int.Parse(tboxPrice.Text),
                    int.Parse(tboxSupPrice.Text),
                    int.Parse(tboxVAT.Text),
                    int.Parse(tboxSumPrice.Text));
                OraMgr.Instance.insertContract(contractModel);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tableLayoutPanel4.Controls.Clear();
        }
        #endregion

        #region 기본옵션
        // 엑셀 버튼
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewcMgtDtl, "계약 내역", dtpicpInFrom, dtpicpInTo);
        }
        // 미리보기 버튼
        private void btnsConPreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialInput, pdocInput, 0, 1);
        }
        // 인쇄 버튼 
        private void btnsConPrinting_Click(object sender, EventArgs e)
        {
            if (pdialInput.ShowDialog() == DialogResult.OK)
            {
                pdocInput.Print();
            }
        }

        private void pdocInput_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "계약 내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewcMgtDtl, cnt, pageNo);
        }
        #endregion

        private void tboxPrice_TextChanged(object sender, EventArgs e)
        {
            if(tboxAmount.Text != null && tboxPrice.Text != null)
            {
                int supPrice = int.Parse(tboxAmount.Text) * int.Parse(tboxPrice.Text);
                tboxSupPrice.Text = supPrice.ToString();
            }
        }

        private void tboxSupPrice_TextChanged(object sender, EventArgs e)
        {
            if(tboxSupPrice.Text != null)
            {
                tboxVAT.Text = (int.Parse(tboxSupPrice.Text) * 0.1).ToString();
            }
        }

        private void tboxVAT_TextChanged(object sender, EventArgs e)
        {
            if(tboxSupPrice.Text != null && tboxVAT != null)
            {
                tboxSumPrice.Text = (float.Parse(tboxSupPrice.Text) + float.Parse(tboxVAT.Text)).ToString();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgviewcMgtDtl.RowCount; i++)
            {
                if (dtgviewcMgtDtl.Rows[i].Cells[colConfirm.Index].Value != null)
                {
                    ContractModel contract = new ContractModel(
                        int.Parse(dtgviewcMgtDtl.Rows[i].Cells[colSOrder.Index].Value.ToString()),
                        dtgviewcMgtDtl.Rows[i].Cells[colSOrderDate.Index].Value.ToString(),
                        int.Parse(dtgviewcMgtDtl.Rows[i].Cells[colCCode.Index].Value.ToString()),
                        int.Parse(dtgviewcMgtDtl.Rows[i].Cells[colECode.Index].Value.ToString()),
                        dtgviewcMgtDtl.Rows[i].Cells[colMCode.Index].Value.ToString(),
                        int.Parse(dtgviewcMgtDtl.Rows[i].Cells[colAmount.Index].Value.ToString()),
                        dtgviewcMgtDtl.Rows[i].Cells[colEndDate.Index].Value.ToString(),
                        int.Parse(dtgviewcMgtDtl.Rows[i].Cells[colPrice.Index].Value.ToString()),
                        int.Parse(dtgviewcMgtDtl.Rows[i].Cells[colSupplyPrice.Index].Value.ToString()),
                        int.Parse(dtgviewcMgtDtl.Rows[i].Cells[colVat.Index].Value.ToString()),
                        int.Parse(dtgviewcMgtDtl.Rows[i].Cells[colSumPrice.Index].Value.ToString())
                        );

                    OraMgr.Instance.updateContract(contract);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
