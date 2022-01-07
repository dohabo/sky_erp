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
    public partial class WarehouseUI : UserControl
    {
        public WarehouseUI()
        {
            InitializeComponent();
        }
        private void WarehouseUI_Load(object sender, EventArgs e)
        {
            initWarehouseListView();
        }

        // 등록
        private void btnWarehouseAdd_Click(object sender, EventArgs e)
        {
            string wName = tboxwName.Text;
            string wDescription = tboxwDescription.Text;

            Warehouse warehouse = new Warehouse(wName, wDescription);
            OraMgr.Instance.insertWarehouse(warehouse);
            initWarehouseListView();
        }

        // 수정
        private void btnWarehouseUpdate_Click(object sender, EventArgs e)
        {
            int wCode = int.Parse(tboxwCode.Text);
            string wName = tboxwName.Text;
            string wDescription = tboxwDescription.Text;

            Warehouse warehouse = new Warehouse(wCode, wName, wDescription);
            OraMgr.Instance.updateWarehouse(warehouse);

            initWarehouseListView();
        }

        // 삭제
        private void btnWarehouseDelete_Click(object sender, EventArgs e)
        {
            int wCode = int.Parse(tboxwCode.Text);
            OraMgr.Instance.deleteWarehouse(wCode);

            initWarehouseListView();
        }

        // gridview 열 클릭 시
        private void dtgviewWarehouseList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = dtgviewWarehouseList.CurrentRow.Index;
            tboxwCode.Text = dtgviewWarehouseList.Rows[rowIndex].Cells[0].Value.ToString();
            tboxwName.Text = dtgviewWarehouseList.Rows[rowIndex].Cells[1].Value.ToString();
            tboxwDescription.Text = dtgviewWarehouseList.Rows[rowIndex].Cells[2].Value.ToString();
        }

        // 새로고침
        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxwCode.Text = "자동 설정";
            tboxwName.Clear();
            tboxwDescription.Clear();
        }

        // 창고 코드 검색 시
        private void btnwCodeSearch_Click(object sender, EventArgs e)
        {
            int wCode = int.Parse(tboxwCodeSearch.Text);
            initWarehouseListView(wCode);
        }

        //  창고 정보 보여주는 메소드
        void initWarehouseListView()
        {
            dtgviewWarehouseList.Rows.Clear();
            List<Warehouse> list = OraMgr.Instance.selectWarehouse();
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewWarehouseList.Rows.Add(new string[]
                {
                        list[i].WCode.ToString(),
                        list[i].WName.ToString(),
                        list[i].WDescription.ToString()
                });
            }
        }

        void initWarehouseListView(int wCode)
        {
            dtgviewWarehouseList.Rows.Clear();
            List<Warehouse> list = OraMgr.Instance.selectWarehouse(wCode);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewWarehouseList.Rows.Add(new string[]
                {
                        list[i].WCode.ToString(),
                        list[i].WName.ToString(),
                        list[i].WDescription.ToString()
                });
            }
        }

    }
}
