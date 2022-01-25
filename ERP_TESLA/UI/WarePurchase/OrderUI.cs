using ERP_TESLA.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Font = System.Drawing.Font;
using ERP_TESLA.Utility.Fuction;
using ERP_TESLA.DAO;
using ERP_TESLA.CLASS.WarePurchase;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ERP_TESLA.Utility.Print;
using ERP_TESLA.Utility.Method;
using ERP_TESLA.CLASS.Standard;
using QRCoder;
using ERP_TESLA.CLASS.ETC;
using ERP_TESLA.UI.Common;

namespace ERP_TESLA.UI.WarePurchase
{
    /// <summary>
    /// name         : 구매 오더 등록
    /// function     : 생산에 필요한 자재를 구매하기 위한 오더 등록 화면
    ///                1개의 거래처에 N개의 Item 등록 가능
    /// date of prep : 2022. 01. 03
    /// date of upd  : 2022. 01. 08 - 바코드 생성 기능 버튼 추가
    /// </summary>
    public partial class OrderUI : UserControl
    {
        Printing printing = new Printing();
        ExcelFunc exl = new ExcelFunc();
        TPOrder tp = new TPOrder();
        GridView gridview = new GridView();
        Material material = new Material();
        ERP_TESLA.CLASS.Standard.Cost cost = new ERP_TESLA.CLASS.Standard.Cost();
        const string UC_NAME_MAIL = "Mail";
        public OrderUI()
        {
            InitializeComponent();
        }

        private void OrderUI_Load(object sender, EventArgs e)
        {
            Date getdate = new Date();
            dtpicpOrderFrom.Text = getdate.getDateThisMonthFrom(dtpicpOrderFrom);
            dtpicpOrderTo.Text = getdate.getDateThisMonthTo(dtpicpOrderTo);
            dtpicInDueDateFrom.Text = getdate.getDateThisMonthFrom(dtpicInDueDateFrom);
            dtpicInDueDateTo.Text = getdate.getDateThisMonthTo(dtpicInDueDateTo);

            string[] PStatusContens = new string[] { "완납", "미납", "분할입고" };
            cbboxPStatus.Items.AddRange(PStatusContens);

            dtgviewOrderAdd.RowCount = 1; // 발주 등록 GridView 1개로 고정

            //dtgviewOrderList 그리드뷰 관련
            gridview.gridViewStyleSet(dtgviewOrderList);
            int[] dtgviewOrderListNum = new int[] { 6, 9, 10, 11, 12 };
            gridview.gridViewNumberSet(dtgviewOrderList, dtgviewOrderListNum);
            int[] dtgviewOrderListDate = new int[] { 1, 8 };
            gridview.gridViewDateSet(dtgviewOrderList, dtgviewOrderListDate);

            //dtgviewOrderDetailAdd 그리드뷰 관련
            gridview.gridViewStyleSet(dtgviewOrderDetailAdd);
            int[] dtgviewOrderDetailAddNum = new int[] { 3, 6, 7, 8, 9 };
            gridview.gridViewNumberSet(dtgviewOrderDetailAdd, dtgviewOrderDetailAddNum);
            int[] dtgviewOrderDetailAddDate = new int[] { 5 };
            gridview.gridViewDateSet(dtgviewOrderDetailAdd, dtgviewOrderDetailAddDate);

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgviewOrderAdd.Rows.Clear();
            dtgviewOrderDetailAdd.Rows.Clear();
            dtgviewOrderAdd.RowCount = 1; // 발주 등록 GridView 1개로 고정
        }

        private void btnPOrderPrinting_Click(object sender, EventArgs e)
        {
            if (pdialPOrder.ShowDialog() == DialogResult.OK)
            {
                pdocPOrder.Print();
            }
        }

        private void printDocument1_PrintPage_POrder(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "구매 발주 내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewOrderList, cnt, pageNo);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewOrderList, "발주내역",dtpicpOrderFrom, dtpicpOrderTo);
        }

        private void btnPOrderPreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialPOrder, pdocPOrder, 0, 1);
        }

        private void btnRefAdd_Click(object sender, EventArgs e)
        {
            List<POrderDetail> list = new List<POrderDetail>();
            if (dtgviewOrderList.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dtgviewOrderList.SelectedRows.Count; i++)
                {
                    int cNum = dtgviewOrderList.SelectedRows[i].Index;
                    POrderDetail porderdetail =
                        new POrderDetail(dtgviewOrderList.Rows[cNum].Cells[3].Value.ToString(),
                            dtgviewOrderList.Rows[cNum].Cells[4].Value.ToString(),
                            dtgviewOrderList.Rows[cNum].Cells[5].Value.ToString(),
                            int.Parse(dtgviewOrderList.Rows[cNum].Cells[6].Value.ToString()),
                            dtgviewOrderList.Rows[cNum].Cells[7].Value.ToString(),
                            dtgviewOrderList.Rows[cNum].Cells[8].Value.ToString(),
                            int.Parse(dtgviewOrderList.Rows[cNum].Cells[9].Value.ToString()),
                            int.Parse(dtgviewOrderList.Rows[cNum].Cells[10].Value.ToString()),
                            int.Parse(dtgviewOrderList.Rows[cNum].Cells[11].Value.ToString()),
                            int.Parse(dtgviewOrderList.Rows[cNum].Cells[12].Value.ToString()));

                    list.Add(porderdetail);
                }
                POrderDetail p = new POrderDetail();
                p.POrderDetailGridView(list, dtgviewOrderDetailAdd);
            }
            else
            {
                MessageBox.Show("구매 목록에 해당 항목을 선택 후 버튼을 클릭 하세요.");
                return;
            }
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
            if (tporder.Count < 1)
            {
                MessageBox.Show("검색 조건에 해당하는 내역이 없습니다.");
            }
            tp.POrderAllGridView(tporder, dtgviewOrderList);
        }

        private void btnPOrderAdd_Click(object sender, EventArgs e)
        {
            string result = gridview.gridViewInputCheck(dtgviewOrderAdd);
            if (result == "neededCheck")
            {
                return;
            }
            gridview.gridViewInputCheck(dtgviewOrderDetailAdd);
            result = gridview.gridViewInputCheck(dtgviewOrderAdd);
            if (result == "neededCheck")
            {
                return;
            }

            if (MessageBox.Show("발주등록 하시겠습니까?", "발주등록 확인", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                POrder porder =
                        new POrder(
                            dtgviewOrderAdd.Rows[0].Cells[0].Value.ToString(),
                            int.Parse(dtgviewOrderAdd.Rows[0].Cells[1].Value.ToString()),
                            int.Parse(dtgviewOrderAdd.Rows[0].Cells[2].Value.ToString())
                        );
                OraMgr.Instance.insertPOrder(porder);

                for (int i = 0; i < dtgviewOrderDetailAdd.RowCount; i++)
                {
                    POrderDetail porderdetail =
                        new POrderDetail(
                                dtgviewOrderDetailAdd.Rows[i].Cells[0].Value.ToString(),
                                int.Parse(dtgviewOrderDetailAdd.Rows[i].Cells[3].Value.ToString()),
                                dtgviewOrderDetailAdd.Rows[i].Cells[5].Value.ToString(),
                                int.Parse(dtgviewOrderDetailAdd.Rows[i].Cells[6].Value.ToString()),
                                int.Parse(dtgviewOrderDetailAdd.Rows[i].Cells[7].Value.ToString()),
                                int.Parse(dtgviewOrderDetailAdd.Rows[i].Cells[8].Value.ToString()),
                                int.Parse(dtgviewOrderDetailAdd.Rows[i].Cells[9].Value.ToString())
                            );
                    OraMgr.Instance.insertPOrderDetail(porderdetail);
                }
                if (MessageBox.Show("발주서를 저장하시겠습니까?", "발주서 저장", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {

                }

                if (MessageBox.Show("발주 등록 완료. 발주서를 발송 하시겠습니까?", "발주서 발송", MessageBoxButtons.YesNo)
                 == DialogResult.Yes)
                {
                    EmailUI mail = new EmailUI();
                    mail.ShowDialog();
                }
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("발주 등록 취소");
            }
        }

        private void dtgviewOrderDetailAdd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            material.materialInfo(dtgviewOrderDetailAdd, 0,1, 2, 4);
            cost.priceInfo(dtgviewOrderDetailAdd, 6);

            int pcost = 0;
            int pammount = 0;
            for (int i = 0; i < dtgviewOrderDetailAdd.Rows.Count; i++)
            {
                if (dtgviewOrderDetailAdd.Rows[i].Cells[3].Value != null &&
                    dtgviewOrderDetailAdd.Rows[i].Cells[6].Value != null)
                {
                    pcost = int.Parse(dtgviewOrderDetailAdd.Rows[i].Cells[3].Value.ToString());
                    pammount = int.Parse(dtgviewOrderDetailAdd.Rows[i].Cells[6].Value.ToString());
                    int supplyPrice = pcost * pammount;

                    int vat = supplyPrice / 10;
                    int sumPrice = supplyPrice + vat;
                    dtgviewOrderDetailAdd.Rows[i].Cells[7].Value = supplyPrice;
                    dtgviewOrderDetailAdd.Rows[i].Cells[8].Value = vat;
                    dtgviewOrderDetailAdd.Rows[i].Cells[9].Value = sumPrice;
                }

                if (dtgviewOrderDetailAdd.Rows[i].Cells[5].Value != null)
                {
                    dtgviewOrderDetailAdd.Columns[5].DefaultCellStyle.Format = "d";
                }
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            dtgviewOrderDetailAdd.RowCount += 1;
        }

        private void btnQRcode_Click(object sender, EventArgs e)
        {
            List<BarCode> barcodeList = new List<BarCode>();
            for (int i = 0; i < dtgviewOrderList.SelectedRows.Count; i++)
            {
                int cNum = dtgviewOrderList.SelectedRows[i].Index;
                BarCode barcode =
                    new BarCode(
                            int.Parse(dtgviewOrderList.Rows[cNum].Cells[colPOrder.Index].Value.ToString()),
                            int.Parse(dtgviewOrderList.Rows[cNum].Cells[colCCOde.Index].Value.ToString()),
                            dtgviewOrderList.Rows[cNum].Cells[colMCode.Index].Value.ToString(),
                            int.Parse(dtgviewOrderList.Rows[cNum].Cells[colAmount.Index].Value.ToString())
                        );
                barcodeList.Add(barcode);
            }

            QRCodeUI qrcodeui = new QRCodeUI(barcodeList);
            qrcodeui.ShowDialog();

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

        private void btneCodeSearch_Click(object sender, EventArgs e)
        {
            EmployeePOP employee = new EmployeePOP();
            employee.ShowDialog();
            tboxECode.Text = employee.Ecode;
        }
    }
}
