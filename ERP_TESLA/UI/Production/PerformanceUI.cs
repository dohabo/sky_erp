using ERP_TESLA.CLASS.Production;
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

namespace ERP_TESLA.UI.Production
{
    public partial class PerformanceUI : UserControl
    {
        public PerformanceUI()
        {
            InitializeComponent();
        }

        ExcelFunc exl = new ExcelFunc();
        Printing printing = new Printing();

        private void PerformanceUI_Load(object sender, EventArgs e)
        {

            GridView gridview = new GridView();
            gridview.gridViewStyleSet(dtgviewPerformce);
            gridview.gridViewStyleSet(dtgviewPerformceAdd);

            initPerListView();
        }

        // 검색
        private void btnPerformceSearch_Click(object sender, EventArgs e)
        {
            string workOrderCode = tboxworkOrderCode.Text;
            string eCode = tobxeCode.Text;
            string oprCode = tboxoperCode.Text;

            // OraMgr.Instance.selectPerformce(workOrderCode, eCode);
            // Console.ReadKey(); -- 사용자가 누른 키 한 문자 정보를 리턴하는 메서드 ( 이해 필요 )
            initPerListView(workOrderCode, eCode, oprCode);

            tboxworkOrderCode.Clear();
            tobxeCode.Clear();

        }

        // 탭 전환 시
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            initPerListView();
        }

        // 탭 2 - 실적 등록 클릭 시
        private void btnPerformceAdd_Click(object sender, EventArgs e)
        {
            // 데이터 유효성 검사
            foreach (DataGridViewRow rw in this.dtgviewPerformceAdd.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("데이터를 넣어주십시오.");
                        return;
                    }
                }
            }

            if (MessageBox.Show("작업실적 등록 하시겠습니까?", "작업실적 등록 확인", MessageBoxButtons.YesNo)
               == DialogResult.Yes)
            {
                for (int i = 0; i < dtgviewPerformceAdd.RowCount; i++)
                {
                   Performance per =
                        new Performance(
                            int.Parse(dtgviewPerformceAdd.Rows[i].Cells[1].Value.ToString()),
                            int.Parse(dtgviewPerformceAdd.Rows[i].Cells[2].Value.ToString()),
                            int.Parse(dtgviewPerformceAdd.Rows[i].Cells[3].Value.ToString()),
                            int.Parse(dtgviewPerformceAdd.Rows[i].Cells[4].Value.ToString()),
                            int.Parse(dtgviewPerformceAdd.Rows[i].Cells[5].Value.ToString()),
                            int.Parse(dtgviewPerformceAdd.Rows[i].Cells[6].Value.ToString()),
                            double.Parse(dtgviewPerformceAdd.Rows[i].Cells[7].Value.ToString()),
                            dtgviewPerformceAdd.Rows[i].Cells[8].Value.ToString(),
                            int.Parse(dtgviewPerformceAdd.Rows[i].Cells[9].Value.ToString())
                                );
                    OraMgr.Instance.insertPer(per);
                }
            }
            else
            {
                MessageBox.Show("작업실적 등록 취소");
            }
        }
        // 탭 2 - 추가
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtgviewPerformceAdd.RowCount += 1;
        }

        // 탭 2 - 삭제
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo)
              == DialogResult.Yes)
            {
                foreach (DataGridViewRow dgr in dtgviewPerformceAdd.SelectedRows)
                {
                    if (!dgr.IsNewRow)
                    {
                        dtgviewPerformceAdd.Rows.Remove(dgr);
                    }
                }
            }
            else
            {
                MessageBox.Show("삭제 취소");
            }
        }

        // 탭2 - 새로고침
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("새로고침 하시겠습니까?", "새로고침 확인", MessageBoxButtons.YesNo)
            == DialogResult.Yes)
            {
                dtgviewPerformceAdd.Rows.Clear();
            }
            else
            {
                MessageBox.Show("새로고침 취소");
            }
        }

        // 탭 2 - 열 추가 시 번호 생성
        private void dtgviewPerformceAdd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dtgviewPerformceAdd.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        // 작업실적 조회
        void initPerListView(string workOrderCode, string eCode, string oprCode)
        {
            dtgviewPerformce.Rows.Clear();
            List<Performance> list = OraMgr.Instance.selectPerformce(workOrderCode, eCode, oprCode);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewPerformce.Rows.Add(new string[]
                {

                    (i+1).ToString(),
                    list[i].WorkOrderCode.ToString(),
                    list[i].OrderAmount.ToString(),
                    list[i].PerAmount.ToString(),
                    list[i].PassAmount.ToString(),
                    list[i].FailAmount.ToString(),
                    list[i].WorkRemainder.ToString(),
                    list[i].FailRate.ToString(),
                    list[i].OprCode.ToString(),
                    list[i].ManHour.ToString(),
                    list[i].ECode.ToString()
            });
            }
        }

        void initPerListView()
        {
            string workOrderCode = "";
            string eCode = "";
            string oprCode = "";

            initPerListView(workOrderCode, eCode, oprCode);
        }

        // 인쇄 
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewPerformce, "작업실적 내역"); 

        }

        private void btnPerformcePreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialPer, pdocPer, 0, 1);

        }

        private void btnPerformcePrinting_Click(object sender, EventArgs e)
        {
            if (pdialPer.ShowDialog() == DialogResult.OK)
            {
                pdocPer.Print();
            }
        }

        private void pdocPer_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "작업실적 내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewPerformce, cnt, pageNo);
        }

       
    }
}
