using ERP_TESLA.CLASS.Production;
using ERP_TESLA.CLASS.WarePurchase;
using ERP_TESLA.DAO;
using ERP_TESLA.UI.Common;
using ERP_TESLA.Utility;
using ERP_TESLA.Utility.Fuction;
using ERP_TESLA.Utility.Method;
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
    /// name         : 자재 출고 관리
    /// function     : 자재 출고 요청된 아이템에 대해 출고 처리 해주는 화면
    ///                바코드를 이용해 출고 아이템 스캔하여 리스트업 가능
    /// date of prep : 2022. 01. 03
    /// date of upd  : 2022. 01. 08 바코드 스캔 기능 버튼 추가
    /// </summary>
    public partial class OutputUI : UserControl
    {
        GridView gridview = new GridView();
        OutputReq outputreq = new OutputReq();
        ExcelFunc exl = new ExcelFunc();
        public OutputUI()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgviewOutReqList.Rows.Clear();

            Dictionary<string, string> search = new Dictionary<string, string>();
            search.Add("reqCode", tboxReqCode.Text);
            search.Add("mCode2", tboxMCode.Text);
            search.Add("eCode", tboxECode.Text);

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
                {"reqDate", dtpicReqFrom.Text, dtpicReqTo.Text}
            };

            List<OutputReq> outputreqlist = OraMgr.Instance.selectOutputReq(searchCondition, searchDate);
            outputreq.OutputReqGridView(outputreqlist, dtgviewOutReqList);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgviewOutList.Rows.Clear();
        }

        private void btnRefAdd_Click(object sender, EventArgs e)
        {
            List<OutputReq> list = new List<OutputReq>();
            if (dtgviewOutReqList.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dtgviewOutReqList.SelectedRows.Count; i++)
                {
                    int cNum = dtgviewOutReqList.SelectedRows[i].Index;
                    OutputReq outputreq =
                        new OutputReq(
                                int.Parse(dtgviewOutReqList.Rows[cNum].Cells[0].Value.ToString()),
                                dtgviewOutReqList.Rows[cNum].Cells[1].Value.ToString(),
                                dtgviewOutReqList.Rows[cNum].Cells[2].Value.ToString(),
                                int.Parse(dtgviewOutReqList.Rows[cNum].Cells[3].Value.ToString()),
                                dtgviewOutReqList.Rows[cNum].Cells[4].Value.ToString(),
                                dtgviewOutReqList.Rows[cNum].Cells[5].Value.ToString(),
                                int.Parse(dtgviewOutReqList.Rows[cNum].Cells[6].Value.ToString())
                            );

                    list.Add(outputreq);
                }
                outputreq.OutputReqGridView(list, dtgviewOutList);
            }
            else
            {
                MessageBox.Show("자재출고요청 목록에 해당 항목을 선택 후 버튼을 클릭 하세요.");
                return;
            }
        }

        private void OutputUI_Load(object sender, EventArgs e)
        {
            Date getdate = new Date();
            dtpicReqFrom.Text = getdate.getDateThisMonthFrom(dtpicReqFrom);
            dtpicReqTo.Text = getdate.getDateThisMonthTo(dtpicReqTo);
            gridview.gridViewStyleSet(dtgviewOutReqList); // GridView 헤더, 셀 폰트 세팅
            gridview.gridViewStyleSet(dtgviewOutList); // GridView 헤더, 셀 폰트 세팅
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            dtgviewOutList.RowCount += 1;
        }

        private void btnChangeOutDate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgviewOutList.Rows.Count; i++)
            {
                dtgviewOutList.Rows[i].Cells[6].Value = tboxOutDate.Text;
            }
        }

        private void btnChangeWarehouse_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgviewOutList.Rows.Count; i++)
            {
                dtgviewOutList.Rows[i].Cells[7].Value = tboxWarehouse.Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string result = gridview.gridViewInputCheck(dtgviewOutList);
            if (result == "neededCheck")
            {
                return;
            }

            if (MessageBox.Show("출고 등록 하시겠습니까?", "출고등록 확인", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                for (int i = 0; i < dtgviewOutList.RowCount; i++)
                {
                    Output output =
                        new Output(
                                int.Parse(dtgviewOutList.Rows[i].Cells[0].Value.ToString()),
                                dtgviewOutList.Rows[i].Cells[1].Value.ToString(),
                                int.Parse(dtgviewOutList.Rows[i].Cells[3].Value.ToString()),
                                dtgviewOutList.Rows[i].Cells[5].Value.ToString(),
                                dtgviewOutList.Rows[i].Cells[6].Value.ToString(),
                                int.Parse(dtgviewOutList.Rows[i].Cells[7].Value.ToString()),
                                int.Parse(dtgviewOutList.Rows[i].Cells[8].Value.ToString())
                            );
                    OraMgr.Instance.insertOutput(output);
                }
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("출고 등록 취소");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewOutReqList, "출고요청 내역",dtpicReqFrom, dtpicReqTo);
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

        private void btnpOrderCodeSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
