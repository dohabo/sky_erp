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
    /// <summary>
    /// name         : BOM
    /// function     : BOM 추가 삭제, 역전개, 정전개 가능한 화면
    /// date of prep : 2022. 01. 07
    /// date of upd  : 
    /// note         : 
    /// </summary>
    public partial class BOMUI : UserControl
    {
        Material material = new Material();
        BOM bom = new BOM();
        public BOMUI()
        {
            InitializeComponent();
        }

        private void btnCMCode_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            dtgviewRCBOMList.Rows.Clear();
            string CMCode = tboxCMCode.Text;
            List<BOM> bomList = OraMgr.Instance.selectRCBOM(CMCode);
            bom.rcbomGridView(bomList, dtgviewRCBOMList);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnMaterialAdd_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == dirBOM)
            {

            }
            
        }

        private void btnRowAdd_Click(object sender, EventArgs e)
        {
            dtgviewBOMAdd.RowCount += 1;
        }

        private void dtgviewBOMAdd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            material.materialInfo(dtgviewBOMAdd,colMCode.Index, 
                colMName.Index, colStandard.Index, colUnit.Index);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            dtgviewBOMAdd.Rows.Clear();
        }

        private void btnBOMAdd_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< dtgviewBOMAdd.RowCount; i++)
            {
                BOM bom = new BOM(
                    tboxPMCodeAdd.Text,
                    dtgviewBOMAdd.Rows[i].Cells[colMCode.Index].Value.ToString(),
                    int.Parse(dtgviewBOMAdd.Rows[i].Cells[colAmount.Index].Value.ToString())
                );
                OraMgr.Instance.insertBOM(bom);
            }
            dtgviewBOMAdd.Rows.Clear();
            MessageBox.Show("BOM 등록이 완료 되었습니다.");
        }

        private void btnPMCode_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            dtgviewPBOMList.Rows.Clear();
            string PMCode = tboxPMCode.Text;
            List<BOM> bomList = OraMgr.Instance.selectPBOM(PMCode);
            bom.pbomGridView(bomList, dtgviewPBOMList);
        }

        private void dtgviewPBOMList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BOMseach();
        }

        void BOMseach()
        {
            dtgviewCBOMList.Rows.Clear();
            int rowNum = dtgviewPBOMList.SelectedRows[0].Index;
            string PMCode = dtgviewPBOMList.Rows[rowNum].Cells[colPMCode.Index].Value.ToString();
            List<BOM> bomList = OraMgr.Instance.selectCBOM(PMCode);
            bom.cbomGridView(bomList, dtgviewCBOMList);
        }

        private void BOMUI_Load(object sender, EventArgs e)
        {
        }

        private void dtgviewCBOMList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtgviewCBOMList.RowCount += 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgviewCBOMList.SelectedRows.Count > 0)
            {
                int rowNum = dtgviewPBOMList.SelectedRows[0].Index;
                string PMCode = dtgviewPBOMList.Rows[rowNum].Cells[colPMCode.Index].Value.ToString();

                for (int i = 0; i < dtgviewCBOMList.SelectedRows.Count; i++)
                {
                    int cNum = dtgviewCBOMList.SelectedRows[i].Index;
                    string CMCode = dtgviewCBOMList.Rows[cNum].Cells[colCMode.Index].Value.ToString();
                    OraMgr.Instance.deleteBOM(PMCode, CMCode);
                }
                MessageBox.Show("선택한 BOM이 삭제 되었습니다.");
                BOMseach();
            }
            else
            {
                MessageBox.Show("BOM 목록에 삭제 할 항목을 선택 후 버튼을 클릭 하세요.");
                return;
            }
        }
    }
}
