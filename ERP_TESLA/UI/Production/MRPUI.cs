using ERP_TESLA.CLASS.Production;
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
using System.Windows.Media.Media3D;

namespace ERP_TESLA.UI.Production
{
    public partial class MRPUI : UserControl
    {
        public MRPUI()
        {
            InitializeComponent();
        }

        ExcelFunc exl = new ExcelFunc();
        Printing printing = new Printing();

        private void MRPUI_Load(object sender, EventArgs e)
        {
            Date getdate = new Date();
            dtpicRequestFrom.Text = getdate.getDateThisMonthFrom(dtpicRequestFrom);
            dtpicRequestTo.Text = getdate.getDateThisMonthTo(dtpicRequestTo);

            GridView gridview = new GridView();
            gridview.gridViewStyleSet(dtgviewPPlan);
            gridview.gridViewStyleSet(dtgviewMRPAdd);
            gridview.gridViewStyleSet(dtgviewMRP);

            initOrderListView();

            var search = new Dictionary<string, string>()
            {
                {"",""}
            };

            var searchDate = new Dictionary<string, List<string>>()
            {
                {"",new List<string> {"", "" } }
            };
            initMRPListView(search, searchDate);

        }

        // 검색
        private void btnMRUSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> search = new Dictionary<string, string>();

            search.Add("proPlanCode", tboxproPlanCode.Text);
            search.Add("mCode", tboxMCode.Text);

            Dictionary<string, List<string>> searchDate = new Dictionary<string, List<string>>();

            searchDate.Add("requiredate", new List<string> { dtpicRequestFrom.Text, dtpicRequestTo.Text });

            OraMgr.Instance.selectWOrder(search, searchDate);
            // Console.ReadKey(); -- 사용자가 누른 키 한 문자 정보를 리턴하는 메서드 ( 이해 필요 )

            initMRPListView(search, searchDate);

            tboxproPlanCode.Clear();
            tboxMCode.Clear();
        }

        // 참조생성 클릭
        private void btnRefAdd_Click(object sender, EventArgs e)
        {
            if (dtgviewMRP.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dtgviewMRP.SelectedRows.Count; i++)
                {
                    int pNum = dtgviewMRP.SelectedRows[i].Index;

                    dtgviewMRPAdd.Rows.Add(
                        "",
                        "", // dtgviewMRP.Rows[pNum].Cells[colproPlanCode.Index].Value.ToString(),
                        dtgviewMRP.Rows[pNum].Cells[colmCode.Index].Value.ToString(),
                        dtgviewMRP.Rows[pNum].Cells[colmName.Index].Value.ToString(),
                        dtgviewMRP.Rows[pNum].Cells[colunit.Index].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("작업지시 목록에 해당 항목을 선택 후 버튼을 클릭 하세요.");
                return;
            }
        }

        // 생산 계획 ROW 선택 바뀔 때마다 동작
        private void dtgviewPPlan_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgviewPPlan.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dtgviewPPlan.SelectedRows.Count; i++)
                {
                    int pNum = dtgviewPPlan.SelectedRows[i].Index;
                    string proPlanSelected = dtgviewPPlan.Rows[pNum].Cells[col2Proplancode.Index].Value.ToString();

                    initMRPListView(proPlanSelected);
                }
            }
        }

        // 탭 2 - 등록
        private void btnMRUAdd_Click(object sender, EventArgs e)
        {
            // 데이터 유효성 검사
            foreach (DataGridViewRow rw in this.dtgviewMRPAdd.Rows)
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

            if (MessageBox.Show("자재소요계획 등록 하시겠습니까?", "자재소요계획 등록 확인", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                for (int i = 0; i < dtgviewMRPAdd.RowCount; i++)
                {
                    MRP mru =
                        new MRP(
                            int.Parse(dtgviewMRPAdd.Rows[i].Cells[1].Value.ToString()),
                            dtgviewMRPAdd.Rows[i].Cells[2].Value.ToString(),
                            int.Parse(dtgviewMRPAdd.Rows[i].Cells[5].Value.ToString()),
                            dtgviewMRPAdd.Rows[i].Cells[6].Value.ToString()
                                );
                    OraMgr.Instance.insertMRU(mru);
                }
            }
            else
            {
                MessageBox.Show("자재소요계획 등록 취소");
            }
        }

        // 탭 2 - 새로고침
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("새로고침 하시겠습니까?", "새로고침 확인", MessageBoxButtons.YesNo)
              == DialogResult.Yes)
            {
                dtgviewMRPAdd.Rows.Clear();
            }
            else
            {
                MessageBox.Show("새로고침 취소");
            }
        }

        // 탭 2 - 삭제
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo)
               == DialogResult.Yes)
            {
                foreach (DataGridViewRow dgr in dtgviewMRPAdd.SelectedRows)
                {
                    if (!dgr.IsNewRow)
                    {
                        dtgviewMRPAdd.Rows.Remove(dgr);
                    }
                }
            }
            else
            {
                MessageBox.Show("삭제 취소");
            }


        }

        // 탭 2 - 추가
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtgviewMRPAdd.RowCount += 1;
        }

        // 탭 2 - 열 생성 시 번호 생성, 날짜 생성
        private void dtgviewMRPAdd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dtgviewMRPAdd.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            dtgviewMRPAdd.Rows[e.RowIndex].Cells[6].Value = DateTime.Now.ToString("yyyy-MM-dd").ToString();
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

        // MRP 조회
        void initMRPListView(string proPlanSelected)
        {
            dtgviewMRP.Rows.Clear();
            List<MRP> list = OraMgr.Instance.selectMRP(proPlanSelected);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewMRP.Rows.Add(new string[]
                {

                    (i+1).ToString(),
                    list[i].ProPlanCode.ToString(),
                    list[i].MCode.ToString(),
                    list[i].MName.ToString(),
                    list[i].Unit.ToString(),
                    list[i].Amount.ToString(),
                    "0",
                    "0",
                    list[i].RequireDate.ToString()
            });
            }
        }

        void initMRPListView(Dictionary<string, string> search, Dictionary<string, List<string>> searchDate)
        {
            dtgviewMRP.Rows.Clear();
            List<MRP> list = OraMgr.Instance.selectMRP(search, searchDate);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewMRP.Rows.Add(new string[]
                {

                    (i+1).ToString(),
                    list[i].ProPlanCode.ToString(),
                    list[i].MCode.ToString(),
                    list[i].MName.ToString(),
                    list[i].Unit.ToString(),
                    list[i].Amount.ToString(),
                    "0",
                    "0",
                    list[i].RequireDate.ToString()
            });
            }
        }

        // 인쇄
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewMRP, "자재소요계획 내역", dtpicRequestFrom, dtpicRequestTo);
        }

        private void btnMRPPreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialMRP, pdocMRP, 0, 1);

        }

        private void btnMRPPrinting_Click(object sender, EventArgs e)
        {
            if (pdialMRP.ShowDialog() == DialogResult.OK)
            {
                pdocMRP.Print();
            }
        }

        private void pdocMRP_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "자재소요계획 내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewMRP, cnt, pageNo);
        }

        private void btnmCodeSearch_Click(object sender, EventArgs e)
        {
            MaterialPOP material = new MaterialPOP();
            material.ShowDialog();
            tboxMCode.Text = material.Mcode;
        }
    }
}
