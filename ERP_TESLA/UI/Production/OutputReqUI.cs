using ERP_TESLA.CLASS.Production;
using ERP_TESLA.CLASS.Standard;
using ERP_TESLA.DAO;
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

namespace ERP_TESLA.UI.Production
{
    public partial class OutputReqUI : UserControl
    {
        public OutputReqUI()
        {
            InitializeComponent();
        }

        ExcelFunc exl = new ExcelFunc();
        Printing printing = new Printing();
        Date getdate = new Date();
        Utility.Method.GridView gridview = new Utility.Method.GridView();
        BOM bom = new BOM();


        private void OutputReqUI_Load(object sender, EventArgs e)
        {
            dtpicDdayFrom.Text = getdate.getDateThisMonthFrom(dtpicDdayFrom);
            dtpicDdayTo.Text = getdate.getDateThisMonthTo(dtpicDdayTo);

            gridview.gridViewStyleSet(dtgviewReq);
            gridview.gridViewStyleSet(dtgviewWOrder);
            gridview.gridViewStyleSet(dtgviewCBOMList);
            gridview.gridViewStyleSet(dtgviewReqList);

            // 작업지시조회
            initWOrderListView();

            var search = new Dictionary<string, string>()
            {
                {"",""}
            };

            var searchDate = new Dictionary<string, List<string>>()
            {
                {"",new List<string> {"", "" } }
            };
            initReqListView(search, searchDate);

        }

        // 탭 전환시 -- 동작이 안된다. 확인 필요!
        private void tabcontrol1_TabIndexChanged(object sender, EventArgs e)
        {
            initWOrderListView();

            var search = new Dictionary<string, string>()
            {
                {"",""}
            };

            var searchDate = new Dictionary<string, List<string>>()
            {
                {"",new List<string> {"", "" } }
            };
            initReqListView(search, searchDate);
        }

        // 탭1 - 검색 클릭 시
        private void btnReqSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> search = new Dictionary<string, string>();

            search.Add("workOrderCode", tboxworkOrderCode.Text);
            search.Add("mCode2", tboxMCode.Text);

            Dictionary<string, List<string>> searchDate = new Dictionary<string, List<string>>();

            searchDate.Add("reqDate", new List<string> { dtpicDdayFrom.Text, dtpicDdayTo.Text });


            tboxworkOrderCode.Clear();
            tboxMCode.Clear();

            initReqListView(search, searchDate);
        }

        // 탭 1 - 참조 생성
        private void btnRefAdd1_Click(object sender, EventArgs e)
        {
            if (dtgviewReqList.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dtgviewReqList.SelectedRows.Count; i++)
                {
                    int pNum = dtgviewReqList.SelectedRows[i].Index;

                    dtgviewReq.Rows.Add(
                        "",
                        dtgviewReqList.Rows[pNum].Cells[2].Value.ToString(),
                        dtgviewReqList.Rows[pNum].Cells[3].Value.ToString(),
                        dtgviewReqList.Rows[pNum].Cells[4].Value.ToString(),
                        dtgviewReqList.Rows[pNum].Cells[5].Value.ToString(),
                        dtgviewReqList.Rows[pNum].Cells[6].Value.ToString()
                        );
                }
            }
            else
            {
                MessageBox.Show("자재요청 목록에 해당 항목을 선택 후 버튼을 클릭 하세요.");
                return;
            }
        }

        // 탭 2 - 작업지시조회에서 각 열을 선택했을 시 동작
        private void dtgviewWOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgviewWOrder.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dtgviewWOrder.SelectedRows.Count; i++)
                {
                    // BOM 조회
                    dtgviewCBOMList.Rows.Clear();
                    int rowNum = dtgviewWOrder.SelectedRows[0].Index;
                    string PMCode = dtgviewWOrder.Rows[rowNum].Cells[colPMCode.Index].Value.ToString();
                    List<BOM> bomList = OraMgr.Instance.selectCBOM(PMCode);
                    bom.cbomGridView(bomList, dtgviewCBOMList);
                }
            }
        }

        // 탭 2 - 참조 생성
        private void btnRefAdd2_Click(object sender, EventArgs e)
        {
            if (dtgviewWOrder.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dtgviewCBOMList.RowCount; i++)
                {
                    int pNum = dtgviewCBOMList.Rows[i].Index;

                    dtgviewReq.Rows.Add(
                        dtgviewWOrder.SelectedRows[0].Cells[colwOrderCode.Index].Value.ToString(),
                        dtgviewWOrder.SelectedRows[0].Cells[colPMCode.Index].Value.ToString(),
                        dtgviewWOrder.SelectedRows[0].Cells[col2mName.Index].Value.ToString(),
                        dtgviewCBOMList.Rows[i].Cells[colCMode.Index].Value.ToString(),
                        dtgviewCBOMList.Rows[i].Cells[colCMName.Index].Value.ToString()
                        );
                }
            }
            else
            {
                MessageBox.Show("작업지시 해당 항목을 선택 후 버튼을 클릭 하세요.");
                return;
            }
        }

        // 탭 3 - 추가
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtgviewReq.RowCount += 1;
        }

        // 탭 3 - 삭제
        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo)
             == DialogResult.Yes)
            {
                foreach (DataGridViewRow dgr in dtgviewReq.SelectedRows)
                {
                    if (!dgr.IsNewRow)
                    {
                        dtgviewReq.Rows.Remove(dgr);
                    }
                }
            }
            else
            {
                MessageBox.Show("삭제 취소");
            }
        }

        // 탭 3 - 새로고침
        private void btnClear_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("새로고침 하시겠습니까?", "새로고침 확인", MessageBoxButtons.YesNo)
            == DialogResult.Yes)
            {
                dtgviewReq.Rows.Clear();
            }
            else
            {
                MessageBox.Show("새로고침 취소");
            }
        }

        // 탭 3 - 등록
        private void btnWOrderAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("자재출고 요청 하시겠습니까?", "자재출고 요청 확인", MessageBoxButtons.YesNo)
               == DialogResult.Yes)
            {
                for (int i = 0; i < dtgviewReq.RowCount; i++)
                {
                    OutputReq outputReq =
                        new OutputReq(
                                int.Parse(dtgviewReq.Rows[i].Cells[0].Value.ToString()),
                                dtgviewReq.Rows[i].Cells[1].Value.ToString(),
                                dtgviewReq.Rows[i].Cells[5].Value.ToString(),
                                dtgviewReq.Rows[i].Cells[3].Value.ToString(),
                                int.Parse(dtgviewReq.Rows[i].Cells[6].Value.ToString()),
                                dtgviewReq.Rows[i].Cells[7].Value.ToString(),
                                int.Parse(dtgviewReq.Rows[i].Cells[9].Value.ToString()),
                                dtgviewReq.Rows[i].Cells[8].Value.ToString()
                                );
                    OraMgr.Instance.insertOutputReq(outputReq);
                }
            }
            else
            {
                MessageBox.Show("자재출고 요청 취소");
            }

        }
        private void dtgviewReq_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dtgviewReq.Rows[e.RowIndex].Cells[7].Value = DateTime.Now.ToString("yyyy-MM-dd").ToString();
            dtgviewReq.Rows[e.RowIndex].Cells[8].Value = "N";
        }

        // 인쇄 및 엑셀
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewReqList, "자재출고내역", dtpicDdayFrom, dtpicDdayTo);

        }

        private void btnReqPreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialReq, pdocReq, 0, 1);
        }

        private void btnReqPrinting_Click(object sender, EventArgs e)
        {
            if (pdialReq.ShowDialog() == DialogResult.OK)
            {
                pdocReq.Print();
            }
        }

        private void pdocReq_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "자재출고 내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewWOrder, cnt, pageNo);
        }

        // 작업지시 조회
        void initWOrderListView()
        {
            dtgviewWOrder.Rows.Clear();
            List<WOrder> list = OraMgr.Instance.selectWOrder();
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewWOrder.Rows.Add(new string[]
                {
                    list[i].WorkOrderCode.ToString(),
                    list[i].MCode.ToString(),
                    list[i].MName.ToString(),
                    list[i].Amount.ToString(),
                    list[i].EndDate.ToString()
            });
            }
        }

        // 자재출고요청 조회
        void initReqListView(Dictionary<string, string> search, Dictionary<string, List<string>> searchDate)
        {
            dtgviewReqList.Rows.Clear();
            List<OutputReq> list = OraMgr.Instance.selectRequest(search, searchDate);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewReqList.Rows.Add(new string[]
                {
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

       
    }
}
