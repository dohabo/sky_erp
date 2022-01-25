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

namespace ERP_TESLA.UI.Sales
{
    public partial class SalesPlanUI : UserControl
    {
        ExcelFunc exl = new ExcelFunc();
        Printing printing = new Printing();
        public SalesPlanUI()
        {
            InitializeComponent();
            Date getdate = new Date();
            dtpicpInFrom.Text = getdate.getDateThisMonthFrom(dtpicpInFrom);
            dtpicpInTo.Text = getdate.getDateThisMonthTo(dtpicpInTo);
        }
        #region 조회
        private void btnmCodeSch_Click(object sender, EventArgs e)
        {

        }
        private void btnSalesPlanSch_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region 기본기능
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewSalesPlan, "판매 계획", dtpicpInFrom, dtpicpInTo);
        }

        private void btnSalesPlanPreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialInput, pdocInput, 0, 1);
        }

        private void btnSalesPlanPrinting_Click(object sender, EventArgs e)
        {
            if (pdialInput.ShowDialog() == DialogResult.OK)
            {
                pdocInput.Print();
            }
        }
        private void pdocInput_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "판매 계획 내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewSalesPlan, cnt, pageNo);
        }
        #endregion 
        #region 삭제/추가
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region 등록
        private void btnProdName_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnsConAdd_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
