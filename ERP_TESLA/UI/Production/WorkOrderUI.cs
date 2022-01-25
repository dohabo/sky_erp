using ERP_TESLA.CLASS.Production;
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
    public partial class WorkOrderUI : UserControl
    {
        public WorkOrderUI()
        {
            InitializeComponent();
        }

        ExcelFunc exl = new ExcelFunc();
        Printing printing = new Printing();
        Date getdate = new Date();
        GridView gridview = new GridView();
        DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();

        private void WorkOrderUI_Load(object sender, EventArgs e)
        {
            dtpicOrderFrom.Text = getdate.getDateThisMonthFrom(dtpicOrderFrom);
            dtpicOrderTo.Text = getdate.getDateThisMonthTo(dtpicOrderTo);
            dtpicCompleteFrom.Text = getdate.getDateThisMonthFrom(dtpicCompleteFrom);
            dtpicCompleteTo.Text = getdate.getDateThisMonthTo(dtpicCompleteTo);

            gridview.gridViewStyleSet(dtgviewPPlan);
            gridview.gridViewStyleSet(dtgviewWOrder);
            gridview.gridViewStyleSet(dtgviewWOrderAdd);

            initOrderListView(); // 보호 수준으로 끌고 올 수 없어서, 메소드 하나 더 만들어서 가져옴.
            initWOrderListView();

            // 콤보 박스 위치나 크기 변경
            dgvCmb.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            dgvCmb.HeaderText = "상태";
            dgvCmb.Items.Add("Y");
            dgvCmb.Items.Add("N");
            dtgviewWOrderAdd.Columns.Add(dgvCmb);

        }


        // 검색 클릭 시 
        private void btnWorkorderSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> search = new Dictionary<string, string>();

            search.Add("proPlanCode", tboxproPlanCode.Text);
            search.Add("mCode", tboxMCode.Text);
            search.Add("cCode", tboxCCode.Text);
            search.Add("workStaus", cboxWorkStatus.Text);

            Console.WriteLine(cboxWorkStatus.Text);

            Dictionary<string, List<string>> searchDate = new Dictionary<string, List<string>>();

            searchDate.Add("orderDate", new List<string> { dtpicOrderFrom.Text, dtpicOrderTo.Text });
            searchDate.Add("endDate", new List<string> { dtpicCompleteFrom.Text, dtpicCompleteTo.Text });

            OraMgr.Instance.selectWOrder(search, searchDate);
            // Console.ReadKey(); -- 사용자가 누른 키 한 문자 정보를 리턴하는 메서드 ( 이해 필요 )

            initWOrderListView(search, searchDate);

            tboxproPlanCode.Clear();
            tboxMCode.Clear();
            tboxCCode.Clear();
            cboxWorkStatus.Refresh();
        }

        // 생산 계획 ROW 선택 바뀔 때마다 동작
        private void dtgviewPPlan_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgviewPPlan.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dtgviewPPlan.SelectedRows.Count; i++)
                {
                    int pNum = dtgviewPPlan.SelectedRows[i].Index;
                    string proPlanSelected = dtgviewPPlan.Rows[pNum].Cells[colProplancode.Index].Value.ToString();

                    initWOrderListView(proPlanSelected);
                }
            }
        }

        // 참조 생성 클릭 시
        private void btnRefAdd_Click(object sender, EventArgs e)
        {
            if (dtgviewWOrder.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dtgviewWOrder.SelectedRows.Count; i++)
                {
                    int pNum = dtgviewWOrder.SelectedRows[i].Index;

                    dtgviewWOrderAdd.Rows.Add(
                        "",
                        dtgviewWOrder.Rows[pNum].Cells[colwOrderCode.Index].Value.ToString(),
                        dtgviewWOrder.Rows[pNum].Cells[col2proPlanCode.Index].Value.ToString(),
                        dtgviewWOrder.Rows[pNum].Cells[col2mCode.Index].Value.ToString(),
                        dtgviewWOrder.Rows[pNum].Cells[col2mName.Index].Value.ToString(),
                        "",
                        "",
                        "",
                        dtgviewWOrder.Rows[pNum].Cells[colcCode.Index].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("작업지시 목록에 해당 항목을 선택 후 버튼을 클릭 하세요.");
                return;
            }
        }

        // 수정
        private void btnWOrderUpdate_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("작업지시 상태를 변경하시겠습니까?", "작업지시 상태 변경 확인", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                for (int i = 0; i < dtgviewWOrder.RowCount; i++)
                {
                    string workStatus = dtgviewWOrder.Rows[i].Cells[8].Value.ToString();
                    string workOrderCode = dtgviewWOrder.Rows[i].Cells[9].Value.ToString();

                    OraMgr.Instance.updateWOrder(workStatus, workOrderCode);
                    initWOrderListView();
                }
            }
            else
            {
                MessageBox.Show("작업지시 상태 변경 취소");
            }
        }

        // 탭 바꿀 시
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            initWOrderListView();
        }


        // 탭 2 -등록
        private void btnWOrderAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("작업지시 등록 하시겠습니까?", "작업지시 등록 확인", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                for (int i = 0; i < dtgviewWOrderAdd.RowCount; i++)
                {
                    WOrder wOrder =
                        new WOrder(
                                int.Parse(dtgviewWOrderAdd.Rows[i].Cells[1].Value.ToString()),
                                dtgviewWOrderAdd.Rows[i].Cells[6].Value.ToString(),
                                int.Parse(dtgviewWOrderAdd.Rows[i].Cells[8].Value.ToString()),
                                dtgviewWOrderAdd.Rows[i].Cells[7].Value.ToString(),
                                int.Parse(dtgviewWOrderAdd.Rows[i].Cells[5].Value.ToString()),
                                dtgviewWOrderAdd.Rows[i].Cells[9].Value.ToString()
                                );
                    OraMgr.Instance.insertWOrder(wOrder);
                }
            }
            else
            {
                MessageBox.Show("작업지시 등록 취소");
            }
        }


        // 탭 2 - 추가
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            dtgviewWOrderAdd.RowCount += 1;
        }

        // 탭 2 - 삭제

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dtgviewWOrderAdd.SelectedRows)
            {
                if (!dgr.IsNewRow)
                {
                    dtgviewWOrderAdd.Rows.Remove(dgr);
                }
            }
        }

        // 탭 2 - 새로고침
        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgviewWOrderAdd.Rows.Clear();
        }

        // 탭 2 - 열이 생성될 때 번호 매겨지는 동작
        private void dtgviewWOrderAdd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dtgviewWOrderAdd.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        // 탭 2 - 오늘 날짜 표시
        private void dtgviewWOrderAdd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dtgviewWOrderAdd.Rows[e.RowIndex].Cells[6].Value = DateTime.Now.ToString("yyyy-MM-dd").ToString();
        }
   

        // 생산계획 조회
        void initOrderListView()
        {
            dtgviewPPlan.Rows.Clear();
            List<SelectPPlan> list = OraMgr.Instance.selectPPlan();
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewPPlan.Rows.Add(new string[]
                {

                    (i+1).ToString(),
                    list[i].ProPlanCode.ToString(),
                    list[i].MCode.ToString(),
                    list[i].MName.ToString(),
                    list[i].Unit.ToString(),
                    list[i].Amount.ToString(),
                    list[i].PTarget.ToString(),
                    list[i].RegDate.ToString(),
                    list[i].ECode.ToString()
                });
            }
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

                    (i+1).ToString(),
                    list[i].WorkOrderCode.ToString(),
                    list[i].ProPlanCode.ToString(),
                    list[i].MCode.ToString(),
                    list[i].MName.ToString(),
                    list[i].Amount.ToString(),
                    list[i].OrderDate.ToString(),
                    list[i].EndDate.ToString(),
                    list[i].CCode.ToString(),
                    list[i].WorkStatus.ToString()

            });
            }
        }

        void initWOrderListView(string proPlanSelected)
        {
            dtgviewWOrder.Rows.Clear();
            List<WOrder> list = OraMgr.Instance.selectWOrder(proPlanSelected);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewWOrder.Rows.Add(new string[]
                {

                    (i+1).ToString(),
                    list[i].WorkOrderCode.ToString(),
                    list[i].ProPlanCode.ToString(),
                    list[i].MCode.ToString(),
                    list[i].MName.ToString(),
                    list[i].Amount.ToString(),
                    list[i].OrderDate.ToString(),
                    list[i].EndDate.ToString(),
                    list[i].CCode.ToString(),
                    list[i].WorkStatus.ToString()
            });
            }
        }

        void initWOrderListView(Dictionary<string, string> search, Dictionary<string, List<string>> searchDate)
        {
            dtgviewWOrder.Rows.Clear();
            List<WOrder> list = OraMgr.Instance.selectWOrder(search, searchDate);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewWOrder.Rows.Add(new string[]
                {

                    (i+1).ToString(),
                    list[i].WorkOrderCode.ToString(),
                    list[i].ProPlanCode.ToString(),
                    list[i].MCode.ToString(),
                    list[i].MName.ToString(),
                    list[i].Amount.ToString(),
                    list[i].OrderDate.ToString(),
                    list[i].EndDate.ToString(),
                    list[i].CCode.ToString(),
                    list[i].WorkStatus.ToString()
            });
            }
        }



        // 인쇄
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewWOrder, "작업지시내역", dtpicOrderFrom, dtpicOrderTo);

        }

        private void btnWOrderPreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialWOrder, pdocWOrder, 0, 1);
        }

        private void btnWOrderPrinting_Click(object sender, EventArgs e)
        {
            if (pdialWOrder.ShowDialog() == DialogResult.OK)
            {
                pdocWOrder.Print();
            }
        }

        private void pdocWOrder_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "작업지시 내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewWOrder, cnt, pageNo);
        }

      

    }
}
