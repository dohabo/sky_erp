using ERP_TESLA.CLASS.Production;
using ERP_TESLA.CLASS.Standard;
using ERP_TESLA.DAO;
using ERP_TESLA.Utility;
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
    public partial class ProductPlanUI : UserControl
    {
        public ProductPlanUI()
        {
            InitializeComponent();

            //dtgviewPPlanAdd.Columns["dataGridViewTextBoxColumn7"].DefaultCellStyle.Format = "d";
            //dtgviewPPlanAdd.Columns["dataGridViewTextBoxColumn8"].DefaultCellStyle.Format = "d";
        }

        private void ProductPlanUI_Load(object sender, EventArgs e)
        {
            Date getdate = new Date();
            dtpicRegisterFrom.Text = getdate.getDateThisMonthFrom(dtpicRegisterFrom);
            dtpicRegisterTo.Text = getdate.getDateThisMonthTo(dtpicRegisterTo);
            dtpicTATFrom.Text = getdate.getDateThisMonthFrom(dtpicTATFrom);
            dtpicTATTo.Text = getdate.getDateThisMonthTo(dtpicTATTo);

        }

        private void btnPPlanAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("생산계획 등록 하시겠습니까?", "생산계획 등록 확인", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                for (int i = 0; i < dtgviewPPlanAdd.RowCount-1; i++)
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
            }
            else
            {
                MessageBox.Show("생산계획 등록 취소");
            }
        }

        // 제일 앞에 번호 매기기
        private void dtgviewOrder_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dtgviewOrder.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dtgviewPPlanAdd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dtgviewPPlanAdd.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            //dtgviewPPlanAdd.Rows[e.RowIndex].Cells[7].Value = DateTime.Now;

            //if (dtgviewPPlanAdd.Rows[e.RowIndex].Cells[1].Value != null)
            //{
            //    string mCode = dtgviewPPlanAdd.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    List<Material> list = OraMgr.Instance.selectMaterial(mCode);
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        dtgviewPPlanAdd.Rows[i].Cells[2].Value = list[i].MName;
            //        dtgviewPPlanAdd.Rows[i].Cells[3].Value = list[i].Standard;
            //    }
            //}

        }

        private void uiSymbolButton4_Click(object sender, EventArgs e)
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
