using ERP_TESLA.DAO;
using ERP_TESLA.Model.HR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.UI.HR
{
    public partial class PayrollUI : UserControl
    {
        
        public PayrollUI()
        {
            InitializeComponent();
        }
        #region 조회파트
        private void btnEmployeeSch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPayrollSch_Click(object sender, EventArgs e)
        {
            string ename = tboxEmployeeName.Text;
            cboxAttendYear.Text = cboxAttendYear.SelectedItem.ToString();
            int attendYear = int.Parse(cboxAttendYear.Text);
            cboxAttendMonth.Text = cboxAttendMonth.SelectedItem.ToString();
            int attendMonth = int.Parse(cboxAttendMonth.Text);
            PayrollModel payrollModel = new PayrollModel();
            List<PayrollModel> list = new List<PayrollModel>();
            list = OraMgr.Instance.selectPayroll(ename,attendYear,attendMonth);
            payrollModel.PayrollGridView(list, dtgviewcPayroll);
        }
        
        #endregion

    }
}
