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
    public partial class SalesMgtUI : UserControl
    {
        ExcelFunc exl = new ExcelFunc();
        Printing printing = new Printing();
        public SalesMgtUI()
        {
            InitializeComponent();
        }
        private void SalesMgtUI_Load(object sender, EventArgs e)
        {
            Date getdate = new Date();
            dtpicpInFrom.Text = getdate.getDateThisMonthFrom(dtpicpInFrom);
            dtpicpInTo.Text = getdate.getDateThisMonthTo(dtpicpInTo);
        }
        // 제품 품번
        private void btnProduct_Click(object sender, EventArgs e)
        {

        }        
        // 조회 버튼
        private void btnSalesSch_Click(object sender, EventArgs e)
        {
            dtgviewSales.Rows.Clear();
        }
        // 엑셀 버튼
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewSales, "매출 내역", dtpicpInFrom, dtpicpInTo);
        }
        // 미리보기 버튼
        private void btnSalesPreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialInput, pdocInput, 0, 1);
        }
        // 인쇄 버튼
        private void btnSalesPrinting_Click(object sender, EventArgs e)
        {
            if (pdialInput.ShowDialog() == DialogResult.OK)
            {
                pdocInput.Print();
            }
        }
        // 인쇄 페이지 설정
        private void pdocInput_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "매출 내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewSales, cnt, pageNo);
        }

    }
}
