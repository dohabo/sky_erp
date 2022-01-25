using ERP_TESLA.CLASS.Cost;
using ERP_TESLA.CLASS.Standard;
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

namespace ERP_TESLA.UI.Cost
{
    public partial class CostCalculUI : UserControl
    {
        Printing printing = new Printing();
        ExcelFunc exl = new ExcelFunc();
        GridView gridview = new GridView();
        ProductCost productcost = new ProductCost();
        BOM bom = new BOM();

        public CostCalculUI()
        {
            InitializeComponent();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewCostList, "원가 계산 내역", dtpicFrom, dtpicTo);
        }

        private void btnCostPreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialCost, pdocCost, 0, 1);
        }

        private void btnCostPrinting_Click(object sender, EventArgs e)
        {
            if (pdialCost.ShowDialog() == DialogResult.OK)
            {
                pdocCost.Print();
            }
        }

        private void pdocCost_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "원가 계산 내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewCostList, cnt, pageNo);
        }

        private void btnsetToday_Click(object sender, EventArgs e)
        {
            string today = string.Format("{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtpicFrom.Text = today;
            dtpicTo.Text = today;
        }

        private void btnsetWeek_Click(object sender, EventArgs e)
        {
            string monday = (DateTime.Today.AddDays
                (Convert.ToInt32(DayOfWeek.Monday) - Convert.ToInt32(DateTime.Today.DayOfWeek))).ToString();
            string friday = (DateTime.Today.AddDays
                (Convert.ToInt32(DayOfWeek.Friday) - Convert.ToInt32(DateTime.Today.DayOfWeek))).ToString();
            dtpicFrom.Text = monday;
            dtpicTo.Text = friday;
        }

        private void btnsetMonth_Click(object sender, EventArgs e)
        {
            string monthFrom = string.Format("{0}-{1}-01", DateTime.Now.Year, DateTime.Now.Month);
            string monthTo = string.Format("{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month,
                (DateTime.DaysInMonth((DateTime.Now.Year), (DateTime.Now.Month))).ToString());
            dtpicFrom.Text = monthFrom;
            dtpicTo.Text = monthTo;
        }

        private void btnsetYear_Click(object sender, EventArgs e)
        {
            string yearFrom = string.Format("{0}-01-01", DateTime.Now.Year);
            string yearTo = string.Format("{0}-12-31", DateTime.Now.Year);
            dtpicFrom.Text = yearFrom;
            dtpicTo.Text = yearTo;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgviewCostList.Rows.Clear();

            Dictionary<string, string> search = new Dictionary<string, string>();
            search.Add("mcode", tboxMCode.Text);

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
                {"enddate", dtpicFrom.Text, dtpicTo.Text}
            };

            List<ProductCost> productCost = OraMgr.Instance.selectMCodeCost(searchCondition, searchDate);
            if (productCost.Count < 1)
            {
                MessageBox.Show("검색 조건에 해당하는 내역이 없습니다.");
            }
            productcost.mcodeCostGridView(productCost, dtgviewCostList);
        }

        private void btnCostCal_Click(object sender, EventArgs e)
        {
            string[,] searchDate = new string[,]
            {
                {"confirmdate", dtpicFrom.Text, dtpicTo.Text}
            };

            int materialCost = 0;
            int failCost = 0;
            int labourCost = 0;

            for (int i = 0; i < dtgviewCostList.RowCount; i++)
            {
                string mcode = dtgviewCostList.Rows[i].Cells[colMCode.Index].Value.ToString();
                // 재료비, 불량금액 계산
                List<BOM> bomLis = 
                    OraMgr.Instance.selectCMBOM(mcode);
                
                for (int j = 0; j < bomLis.Count; j++)
                {
                    materialCost += 
                        OraMgr.Instance.selectBuyingCost(bomLis[j].Cmcode, searchDate) * bomLis[j].Amount * 
                            int.Parse(dtgviewCostList.Rows[i].Cells[colPassAmount.Index].Value.ToString());
                    failCost +=
                        OraMgr.Instance.selectBuyingCost(bomLis[j].Cmcode, searchDate) * bomLis[j].Amount *
                            int.Parse(dtgviewCostList.Rows[i].Cells[colFailAmount.Index].Value.ToString());
                }
                dtgviewCostList.Rows[i].Cells[colMaterialCost.Index].Value = materialCost;
                dtgviewCostList.Rows[i].Cells[colFailCost.Index].Value = failCost;

                // 노무비 계산
                labourCost = OraMgr.Instance.selectOperationCost(mcode) * 11000 * 
                    int.Parse(dtgviewCostList.Rows[i].Cells[colPassAmount.Index].Value.ToString());
                dtgviewCostList.Rows[i].Cells[colLaborCost.Index].Value = labourCost;
            }
        }
    }
}
