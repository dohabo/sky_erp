using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_TESLA.DAO;
using ERP_TESLA.Model;
using ERP_TESLA.Model.HR;
using ERP_TESLA.PoPUP;
using Sunny.UI;

namespace ERP_TESLA.UI.HR
{
    public partial class AttendanceUI : UserControl
    {
        EmployeeModel anemployee = new EmployeeModel();
        AttendanceModel attendanceModel;
        PayrollModel payrollModel;


        int attendYear;
        int attendMonth;
        int vacationDays;
        int workingDays;
        int sickDays;

        public AttendanceUI()
        {
            InitializeComponent();                       
        }
        #region 조회파트
        private void btnEmployeeSch_Click(object sender, EventArgs e)
        {
            EmployeePopup employeePopup = new EmployeePopup();            
        }
        
        private void btnAttendanceSch_Click_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[] number = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 2 };
            RadioButton[,] str = new RadioButton[,]
            {
                { rbtn1, rbtn2, rbtn3 },
                { rbtn4, rbtn5, rbtn6},
                { rbtn7, rbtn8, rbtn9},
                { rbtn10, rbtn11, rbtn12},
                { rbtn13, rbtn14, rbtn15 },
                { rbtn16, rbtn17, rbtn18 },
                { rbtn19, rbtn20, rbtn21 },
                { rbtn22, rbtn23, rbtn24 },
                { rbtn25, rbtn26, rbtn27 },
                { rbtn28, rbtn29, rbtn30 },
                { rbtn31, rbtn32, rbtn33 },
                { rbtn34, rbtn35, rbtn36 },
                { rbtn37, rbtn38, rbtn39 },
                { rbtn40, rbtn41, rbtn42 },
                { rbtn43, rbtn44, rbtn43 },
                { rbtn46, rbtn47, rbtn44 },
                { rbtn49, rbtn50, rbtn51 },
                { rbtn52, rbtn53, rbtn54 },
                { rbtn55, rbtn56, rbtn57 },
                { rbtn58, rbtn59, rbtn60 },
                { rbtn61, rbtn62, rbtn63 },
                { rbtn64, rbtn65, rbtn66 },
                { rbtn67, rbtn68, rbtn69 },
                { rbtn70, rbtn71, rbtn72 },
                { rbtn73, rbtn74, rbtn75 },
                { rbtn76, rbtn77, rbtn78 },
                { rbtn79, rbtn80, rbtn81 },
                { rbtn82, rbtn83, rbtn84 },
                { rbtn85, rbtn86, rbtn87 },
                { rbtn88, rbtn89, rbtn90 },
                { rbtn91, rbtn92, rbtn93 }
            };

            int ok = 0;
            int vx = 0;
            int sx = 0;
            for (int i = 0; i < str.GetLength(0); i++)
            {
                str[i, number[rand.Next(0, 10)]].Checked = true;
                if (str[i, 0].Checked == true)
                {
                    ok += 1;
                }
                if (str[i, 1].Checked == true)
                {
                    vx++;
                }
                if (str[i, 2].Checked == true)
                {
                    sx++;
                }
            }
            anemployee.ECode = 456;
            anemployee.EName = tboxEmployeeName.Text;
            anemployee.Departure = "생산부";
            anemployee.Grade = "사원";

            
            cboxAttendYear.Text = cboxAttendYear.SelectedItem.ToString();
            attendYear = int.Parse(cboxAttendYear.Text);
            cboxAttendMonth.Text = cboxAttendMonth.SelectedItem.ToString();
            attendMonth = int.Parse(cboxAttendMonth.Text);

            workingDays = ok;
            vacationDays = vx;
            sickDays = sx;

            attendanceModel = new AttendanceModel
                (anemployee.ECode, anemployee.EName, anemployee.Departure, anemployee.Grade, attendYear, attendMonth, vacationDays,sickDays,workingDays);
            List<AttendanceModel> list = new List<AttendanceModel>();
            list.Add(attendanceModel);
            attendanceModel.AttendanceGridView(list, dtgviewcAttend);           
        }
        #endregion

        #region 등록파트
        private void btnAttendanceAdd_Click(object sender, EventArgs e)
        {
            OraMgr.Instance.insertAttendance(attendanceModel);
            string payMentDate = string.Format("{0}-{1}-25",
                attendanceModel.AttendYear,
                attendanceModel.AttendMonth+1);
            int payMentStandard = 11000;
            int payMenttotal = payMentStandard * attendanceModel.WorkingDays;
            
            payrollModel = new PayrollModel(
                attendanceModel.ECode,
                attendanceModel.EName,
                attendanceModel.Departure,
                attendanceModel.Grade,
                attendanceModel.AttendYear,
                attendanceModel.AttendMonth,
                payMentDate,
                attendanceModel.WorkingDays,
                payMentStandard,
                payMenttotal
                );
            OraMgr.Instance.insertPayroll(payrollModel);
        }
        #endregion


    }
}
