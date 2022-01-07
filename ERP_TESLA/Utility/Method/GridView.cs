using ERP_TESLA.CLASS.WarePurchase;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.Utility.Method
{
    class GridView
    {
        // 폰트 서식 세팅
        public void gridViewStyleSet(DataGridView dtgviewName)
        {
            dtgviewName.ColumnHeadersDefaultCellStyle.Font = new Font("굴림", 9);
            dtgviewName.DefaultCellStyle.Font = new Font("굴림", 8);
            dtgviewName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // 숫자 서식 세팅
        public void gridViewNumberSet(DataGridView dtgviewName, int[] number)
        {
            for(int i = 0; i < number.Length; i++)
            {
                dtgviewName.Columns[number[i]].DefaultCellStyle.Format = "N0";
            }
        }

        // 날짜 서식 세팅
        public void gridViewDateSet(DataGridView dtgviewName, int[] number)
        {
                dtgviewName.Columns[5].DefaultCellStyle.Format = "d";
        }

        // 빈칸 체크
        public string gridViewInputCheck(DataGridView dtgviewName)
        {
            string result = string.Empty;
            for (int i = 0; i < dtgviewName.Rows.Count; i++)
            {
                for (int j = 0; j < dtgviewName.Columns.Count; j++)
                {
                    if (dtgviewName.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show(dtgviewName.Columns[j].HeaderText.ToString()
                            + "정보가 누락됐습니다. 확인 바랍니다.");
                        result = "neededCheck";
                    }
                }
            }
            return result;
        }
    }
}
