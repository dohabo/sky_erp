using ERP_TESLA.CLASS.WarePurchase;
using ERP_TESLA.DAO;
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
/// name         : 자재 관리
/// function     : 현재 재고 확인 및 재고 수불 현황 확인
/// date of prep : 2022. 01. 03
/// date of upd  : 
/// </summary>
    public partial class StockUI : UserControl
    {
        Printing printing = new Printing();
        ExcelFunc exl = new ExcelFunc();
        GridView gridview = new GridView();
        Stock stock = new Stock();
        InOutList intoutlist = new InOutList();
        public StockUI()
        {
            InitializeComponent();
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            if(dtgviewStockList.SelectedRows.Count < 1)
            {
                intoutlist.ShowDialog();
            }
            else
            {
                string mCode = dtgviewStockList.SelectedRows[0].Cells[colMName.Index].Value.ToString();
                intoutlist = new InOutList(mCode);
                intoutlist.ShowDialog();
            }
        }

        private void StockUI_Load(object sender, EventArgs e)
        {
            string[] MClassStatusContens = new string[] { "전체", "제품", "원자재" };
            cbboxMClass.Items.AddRange(MClassStatusContens);
            cbboxMClass.Text = "전체";
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewStockList, "재고 현황");
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialStock, pdocStock, 0, 1);
        }

        private void btnPrinting_Click(object sender, EventArgs e)
        {
            if (pdialStock.ShowDialog() == DialogResult.OK)
            {
                pdocStock.Print();
            }
        }

        private void pdocStock_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "재고 내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewStockList, cnt, pageNo);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgviewStockList.Rows.Clear();

            Dictionary<string, string> search = new Dictionary<string, string>();
            search.Add("mClass", cbboxMClass.Text);
            search.Add("mCode", tboxMCode.Text);
            search.Add("standard", tboxStandard.Text);
            search.Add("wCode", tboxWCode.Text);

            Dictionary<string, string> searchCondition = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> pair in search)
            {
                if (pair.Value != "")
                {
                    searchCondition.Add(pair.Key, pair.Value);
                }
            }

            List<Stock> stocklist = OraMgr.Instance.selectStock(searchCondition);
            stock.stockAllGridView(stocklist, dtgviewStockList);
        }

        private void btnmCodeSearch_Click(object sender, EventArgs e)
        {

        }

        private void btneCodeSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
