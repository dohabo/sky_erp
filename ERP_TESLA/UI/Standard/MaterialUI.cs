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
    public partial class MaterialUI : UserControl
    {
        public MaterialUI()
        {
            InitializeComponent();
        }

        private void MaterialUI_Load(object sender, EventArgs e)
        {
            // combobox
            cbboxmClass.Items.Add("원자재");
            cbboxmClass.Items.Add("제품");

            initMaterialListView();

        }

        // tabcontrol 전환 시
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            initMaterialListView();
        }

        // 품목 코드 검색 시
        private void btnmCodeSearch_Click(object sender, EventArgs e)
        {
            string mCode = tboxmCodeSearch.Text;
            initMaterialListView(mCode);
        }

        // 등록
        private void btnMaterialAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("등록 완료");

            string mCode = tboxmCode.Text;
            string mClass = cbboxmClass.SelectedItem.ToString();
            string mName = tboxmName.Text;
            string unit = tboxunit.Text;
            string standard = tboxstandard.Text;
            int price = int.Parse(tboxprice.Text);

            Material material = new Material(mCode, mClass, mName, unit, standard, price);
            OraMgr.Instance.insertMaterial(material);
        }

        // 새로고침
        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxmCode.Clear();
            cbboxmClass.Clear();
            tboxmName.Clear();
            tboxunit.Clear();
            tboxstandard.Clear();
            tboxprice.Clear();
        }

        //  회사 정보 보여주는 메소드
        void initMaterialListView()
        {
            dtgviewMaterialList.Rows.Clear();
            List<Material> list = OraMgr.Instance.selectMaterial();
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewMaterialList.Rows.Add(new string[]
                {
                        list[i].MCode.ToString(),
                        list[i].MClass.ToString(),
                        list[i].MName.ToString(),
                        list[i].Unit.ToString(),
                        list[i].Standard.ToString(),
                        list[i].Price.ToString()
                });
            }
        }

        void initMaterialListView(string mCode)
        {
            dtgviewMaterialList.Rows.Clear();
            List<Material> list = OraMgr.Instance.selectMaterial(mCode);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewMaterialList.Rows.Add(new string[]
                {
                        list[i].MCode.ToString(),
                        list[i].MClass.ToString(),
                        list[i].MName.ToString(),
                        list[i].Unit.ToString(),
                        list[i].Standard.ToString(),
                        list[i].Price.ToString()
                });
            }
        }

        // 한 행 선택 시 데이터 값 textbox에 뿌려주기
        private void dtgviewMaterialList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = dtgviewMaterialList.CurrentRow.Index;
            tboxmCodeShow.Text = dtgviewMaterialList.Rows[rowIndex].Cells[0].Value.ToString();
            tboxmClassShow.Text = dtgviewMaterialList.Rows[rowIndex].Cells[1].Value.ToString();
            tboxmNameShow.Text = dtgviewMaterialList.Rows[rowIndex].Cells[2].Value.ToString();
            tboxunitShow.Text = dtgviewMaterialList.Rows[rowIndex].Cells[3].Value.ToString();
            tboxstandardShow.Text = dtgviewMaterialList.Rows[rowIndex].Cells[4].Value.ToString();
            tboxpriceShow.Text = dtgviewMaterialList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        // 삭제
        private void btnMaterialDelete_Click(object sender, EventArgs e)
        {     
            DialogResult dialogResult = MessageBox.Show("품목 정보를 삭제하시겠습니까?", "Inform", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                OraMgr.Instance.deleteMaterial(tboxmCodeShow.Text);
                initMaterialListView();
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
        }
        
        // 수정
        private void btnMaterialUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("품목 정보를 수정하시겠습니까?", "Inform", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                string mCode = tboxmCodeShow.Text;
                string mClass = tboxmClassShow.Text;
                string mName = tboxmNameShow.Text;
                string unit = tboxunitShow.Text;
                string standard = tboxstandardShow.Text;
                int price = int.Parse(tboxpriceShow.Text);

                Material material = new Material(mCode, mClass, mName, unit, standard, price);
                OraMgr.Instance.updateMaterial(material);
                initMaterialListView();
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
        }

    }
}
