using ERP_TESLA.CLASS.Standard;
using ERP_TESLA.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.UI.Standard
{
    public partial class OperationUI : UserControl
    {
        public OperationUI()
        {
            InitializeComponent();
        }
        private void OperationUI_Load(object sender, EventArgs e)
        {
            initOperationListView();
        }

        // 등록
        private void btnOperationAdd_Click(object sender, EventArgs e)
        {
            string oprCode = tboxoprCode.Text;
            string oprName = tboxoprName.Text;
            int oprManHour = int.Parse(tboxmanHour.Text);
            string oprDescription = tboxoprDescription.Text;

            Operation operation = new Operation(oprCode, oprName, oprManHour, oprDescription);
            OraMgr.Instance.insertOperation(operation);

            initOperationListView();
        }

        // 수정
        private void btnOperationUpdate_Click(object sender, EventArgs e)
        {
            string oprCode = tboxoprCode.Text;
            string oprName = tboxoprName.Text;
            int oprManHour = int.Parse(tboxmanHour.Text);
            string oprDescription = tboxoprDescription.Text;

            Operation operation = new Operation(oprCode, oprName, oprManHour, oprDescription);
            OraMgr.Instance.updateOperation(operation);

            initOperationListView();
        }

        // 삭제
        private void btnOperationDelete_Click(object sender, EventArgs e)
        {
            OraMgr.Instance.deleteOperation(tboxoprCode.Text);
            initOperationListView();
        }

        // 새로고침
        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxoprCode.Clear();
            tboxoprName.Clear();
            tboxoprDescription.Clear();
        }

        // gridview 열 클릭 시
        private void dtgviewOpeartionList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = dtgviewOpeartionList.CurrentRow.Index;
            tboxoprCode.Text = dtgviewOpeartionList.Rows[rowIndex].Cells[0].Value.ToString();
            tboxoprName.Text = dtgviewOpeartionList.Rows[rowIndex].Cells[1].Value.ToString();
            tboxmanHour.Text = dtgviewOpeartionList.Rows[rowIndex].Cells[2].Value.ToString();
            tboxoprDescription.Text = dtgviewOpeartionList.Rows[rowIndex].Cells[3].Value.ToString();

        }

        // 공정번호 검색 시
        private void btnoperCodeSearch_Click(object sender, EventArgs e)
        {
            string oprCode = tboxoperCodeSearch.Text;
            initOperationListView(oprCode);
        }

        //  공정 정보 보여주는 메소드
        void initOperationListView()
        {
            dtgviewOpeartionList.Rows.Clear();
            List<Operation> list = OraMgr.Instance.selectOperation();
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewOpeartionList.Rows.Add(new string[]
                {
                        list[i].OprCode.ToString(),
                        list[i].OprName.ToString(),
                        list[i].OprManHour.ToString(),
                        list[i].OprDescription.ToString()
                });
            }
        }

        void initOperationListView(string oprCode)
        {

            dtgviewOpeartionList.Rows.Clear();
            List<Operation> list = OraMgr.Instance.selectOperation(oprCode);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewOpeartionList.Rows.Add(new string[]
                {
                        list[i].OprCode.ToString(),
                        list[i].OprName.ToString(),
                        list[i].OprManHour.ToString(),
                        list[i].OprDescription.ToString()
                });
            }
        }

    }

}
