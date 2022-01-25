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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.UI.Production
{
    public partial class ProductPlanUI : UserControl
    {
        ExcelFunc exl = new ExcelFunc();
        Printing printing = new Printing();
        Date getdate = new Date();
        DateTimePicker datedtp = new DateTimePicker();
        Rectangle _Rectangle;

        public ProductPlanUI()
        {
            InitializeComponent();

            //dtgviewPPlanAdd.Columns["dataGridViewTextBoxColumn7"].DefaultCellStyle.Format = "d";
            //dtgviewPPlanAdd.Columns["dataGridViewTextBoxColumn8"].DefaultCellStyle.Format = "d";
            GridView gridview = new GridView();
            gridview.gridViewStyleSet(dtgviewPPlan);
            gridview.gridViewStyleSet(dtgviewPPlanAdd);

            // 달력
            dtgviewPPlanAdd.Controls.Add(datedtp);
            datedtp.Visible = false; // to hid datetimepicker
            datedtp.Format = DateTimePickerFormat.Custom;
            datedtp.Value = DateTime.Now;
            datedtp.CustomFormat = "yyyy-MM-dd";
            datedtp.TextChanged += new EventHandler(datedtp_TextChange);
        }

        private void ProductPlanUI_Load(object sender, EventArgs e)
        {
            dtpicRegisterFrom.Text = getdate.getDateThisMonthFrom(dtpicRegisterFrom);
            dtpicRegisterTo.Text = getdate.getDateThisMonthTo(dtpicRegisterTo);
            dtpicTATFrom.Text = getdate.getDateThisMonthFrom(dtpicTATFrom);
            dtpicTATTo.Text = getdate.getDateThisMonthTo(dtpicTATTo);


            initOrderListView();
        }

        // 등록

        private void btnPPlanAdd_Click(object sender, EventArgs e)
        {
            // 데이터 유효성 검사
            foreach (DataGridViewRow rw in this.dtgviewPPlanAdd.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show("데이터를 넣어주십시오.");
                        return;
                    }
                }
                
                // 날짜 형식 검사
                Regex regexDate = new Regex(@"^(19|20)\d{2}-(0[1-9]|1[012])-(0[1-9]|[12][0-9]|3[0-1])$"); // YYYY-MM-DD
                Match m = regexDate.Match(rw.Cells[5].Value.ToString());

                if (m.Success == false)
                {
                    MessageBox.Show("날짜 형식을 다시 입력해주세요.");
                    return;
                }
            }

            if (MessageBox.Show("생산계획 등록 하시겠습니까?", "생산계획 등록 확인", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                for (int i = 0; i < dtgviewPPlanAdd.RowCount; i++)
                {
                    PPlan pplan =
                        new PPlan(                              
                                dtgviewPPlanAdd.Rows[i].Cells[1].Value.ToString(),
                                int.Parse(dtgviewPPlanAdd.Rows[i].Cells[4].Value.ToString()),
                                dtgviewPPlanAdd.Rows[i].Cells[5].Value.ToString(),
                                int.Parse(dtgviewPPlanAdd.Rows[i].Cells[6].Value.ToString()),
                                dtgviewPPlanAdd.Rows[i].Cells[7].Value.ToString()    
                            );
                    OraMgr.Instance.insertPPlan(pplan);                   
                }
                initOrderListView();
            }
            else
            {
                MessageBox.Show("생산계획 등록 취소");
            }         
        }

     

        // 검색 버튼 클릭 시
        private void btnpPPlanSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> search = new Dictionary<string, string>();
            
            search.Add("proPlanCode", tboxproPlanCode.Text);
            search.Add("mCode", tboxMCode.Text);
            search.Add("eCode", tboxECode.Text);

            Dictionary<string, List<string>> searchDate = new Dictionary<string, List<string>>();

            searchDate.Add("regdate", new List<string>{dtpicRegisterFrom.Text, dtpicRegisterTo.Text});
            searchDate.Add("ptarget", new List<string>{dtpicTATFrom.Text, dtpicTATTo.Text});

            OraMgr.Instance.selectPPlan(search, searchDate);
            // Console.ReadKey(); -- 사용자가 누른 키 한 문자 정보를 리턴하는 메서드 ( 이해 필요 )

            initSearchOrderListView(search, searchDate);

            tboxproPlanCode.Clear();
            tboxMCode.Clear();
            tboxECode.Clear();

        }

        // 참조생성 클릭 시
        private void btnRefAdd_Click(object sender, EventArgs e)
        {

            Console.WriteLine("선택된 값: " + dtgviewPPlan.SelectedRows.Count);
            if (dtgviewPPlan.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dtgviewPPlan.SelectedRows.Count; i++)
                {
                    int pNum = dtgviewPPlan.SelectedRows[i].Index;

                    dtgviewPPlanAdd.Rows.Add(
                        i+1,
                        dtgviewPPlan.Rows[pNum].Cells[colMcode.Index].Value.ToString(),
                        dtgviewPPlan.Rows[pNum].Cells[colMname.Index].Value.ToString(),
                        dtgviewPPlan.Rows[pNum].Cells[colUnit.Index].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("생산 계획 목록에 해당 항목을 선택 후 버튼을 클릭 하세요.");
                return;
            }
        }

        // 새로고침 버튼
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("새로고침 하시겠습니까?", "새로고침 확인", MessageBoxButtons.YesNo)
               == DialogResult.Yes)
            {
                dtgviewPPlanAdd.Rows.Clear();
            }
            else
            {
                MessageBox.Show("새로고침 취소");
            }
        }

        // 추가 버튼
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtgviewPPlanAdd.RowCount += 1;
        }

        // 삭제 버튼
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo)
               == DialogResult.Yes)
            {
                foreach (DataGridViewRow dgr in dtgviewPPlanAdd.SelectedRows)
                {
                    if (!dgr.IsNewRow)
                    {
                        dtgviewPPlanAdd.Rows.Remove(dgr);
                    }
                }
            }
            else
            {
                MessageBox.Show("삭제 취소");
            }         
        }

        // 조회
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

        void initSearchOrderListView(Dictionary<string, string> search, Dictionary<string, List<string>> searchDate)
        {
            dtgviewPPlan.Rows.Clear();
            List<SelectPPlan> list = OraMgr.Instance.selectPPlan(search, searchDate);
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
                }) ;
            }
        }

        // 제일 앞에 번호 매기기
        private void dtgviewPPlanAdd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dtgviewPPlanAdd.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            //dtgviewPPlanAdd.Rows[e.RowIndex].Cells[7].Value = DateTime.Now;

            //if (dtgviewPPlanAdd.Rows[e.RowIndex].Cells[1].Value != null)
            //{
            //    string mCode = dtgviewPPlanAdd.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    List<Material> list = OraMgr.Instance.
            //    terial(mCode);
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        dtgviewPPlanAdd.Rows[i].Cells[2].Value = list[i].MName;
            //        dtgviewPPlanAdd.Rows[i].Cells[3].Value = list[i].Standard;
            //    }
            //}
        }

        // 오늘 날짜 표시
        private void dtgviewPPlanAdd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dtgviewPPlanAdd.Rows[e.RowIndex].Cells[7].Value = DateTime.Now.ToString("yyyy-MM-dd").ToString();
        }

        // 인쇄
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewPPlan, "생산계획내역", dtpicRegisterFrom, dtpicRegisterTo);

        }

        private void btnPPlanPreview_Click(object sender, EventArgs e)
        {
            printing.printPreview(sender, e, ppviewdialPPlan, pdocPPlan, 0, 1);

        }

        private void btnPPlanPrinting_Click(object sender, EventArgs e)
        {
            if (pdialPPlan.ShowDialog() == DialogResult.OK)
            {
                pdocPPlan.Print();
            }
        }

        private void pdocPPlan_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "생산계획내역";
            int cnt = 0; //전역변수 행의 개수를 셀것임.
            int pageNo = 1;//페이지 넘버를 담당하는 전역변수
            printing.printDoc(sender, e, title, dtgviewPPlan, cnt, pageNo);
        }

        // 달력 - 아직 시도 중 ... 다양한 오류 발생
        private void datedtp_TextChange(object sender, EventArgs e)
        {
            int column = dtgviewPPlanAdd.CurrentCell.ColumnIndex;
            string headertext = dtgviewPPlanAdd.Columns[column].HeaderText;

            for (int i = 0; i < dtgviewPPlanAdd.Rows.Count; i++)
            {
                if (headertext.Equals("생산목표일"))
                {
                    dtgviewPPlanAdd.CurrentCell.Value = datedtp.Text.ToString();
                    datedtp.Visible = false;
                }
                else
                {
                    datedtp.Visible = false;
                    return;
                }
                
            }
        }

        private void dtgviewPPlanAdd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = dtgviewPPlanAdd.CurrentCell.ColumnIndex;
            string headertext = dtgviewPPlanAdd.Columns[column].HeaderText;

            for (int i = 0; i < dtgviewPPlanAdd.Rows.Count; i++)
            {
                if (headertext.Equals("생산목표일"))
                {
                    // to datetimepicker location and size
                    _Rectangle = dtgviewPPlanAdd.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    datedtp.Size = new Size(_Rectangle.Width, _Rectangle.Height);
                    datedtp.Location = new Point(_Rectangle.X, _Rectangle.Y + 4);
                    datedtp.Visible = true; // show datetimepicker
                }
            }
        }

        private void dtgviewPPlanAdd_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            datedtp.Visible = false;
        }

        private void uiSymbolButton10_Click(object sender, EventArgs e)
        {
        }


        /*private void dtgviewPPlanAdd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != dtgviewPPlanAdd.NewRowIndex)
            {
                switch (e.ColumnIndex)
                {
                    case 7:
                        string strDate = e.Value.ToString();
                        DateTime dateTime;
                        try
                        {
                            dateTime = DateTime.ParseExact(strDate, "yyyyMMdd", null);
                            e.Value = dateTime.ToString("yyyy-MM-dd");
                        }
                        catch
                        {
                            e.Value = strDate;
                        }
                        break;
                }
            }
        }*/

    }
}
