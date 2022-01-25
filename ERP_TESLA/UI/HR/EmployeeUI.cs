using ERP_TESLA.PoPUP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;
using System.IO;
using ERP_TESLA.CLASS.HR;
using ERP_TESLA.DAO;

namespace ERP_TESLA.UI.HR
{
    public partial class EmployeeUI : UserControl
    {
        Employee employee = new Employee();
        public EmployeeUI()
        {
            InitializeComponent();
        }

        private OracleConnection conn;    //커넥션 개체
        private String str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=c##lee; Password=tiger;";
        private OracleTransaction Transact;  //트랜젝션 
        private OracleCommand Comm;         //커맨드 객체

        // button 옆에 pop up 창 띄우기 
        private void btnSmpSch_Click(object sender, EventArgs e)
        {
            UISymbolButton btnSmpSch = (UISymbolButton)sender;
            EmployeePopup secondForm = new EmployeePopup(btnSmpSch.Location.X + 10, btnSmpSch.Location.Y + 10);
            DialogResult dialogresult = secondForm.ShowDialog();
        }


        private void btnsConSch_Click(object sender, EventArgs e)
        {
            // if(db.result!=null)
            tabControl1.SelectedTab = tabPage2;
            // else
            MessageBox.Show("존재하지 않는 사원입니다");
        }
        // tabPage1
        private void tboxDepart_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImageSch_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.Title = "이미지 열기";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                pboxEmp.Image = new Bitmap(openFileDialog1.FileName);
                String strFullPathFile = openFileDialog1.FileName;
                tboxFilePath.Text = strFullPathFile;
            }
            pboxEmp.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (pboxEmp.Image != null)
            {
                pboxEmp.Image.Dispose();
                tboxFilePath.Text = string.Empty;
            }
            else
            {
                btnDelete.Enabled = false;
                MessageBox.Show("이미지를 등록해주세요");
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            string query = string.Format("INSERT INTO employee_t(ecode, ename,departure,grade,indate," +
                "telnum,birth,address,email,PICTURE) " +
                "VALUES(employee_t_seq.nextval, '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}', :image)",
                tboxEName.Text, tboxDeparture.Text, tboxGrade.Text, dpicInDate.Text,
                tboxFirstTel.Text + tboxMiddleTel.Text + tboxLastTel.Text, 
                dpicBirthday.Text, tboxAddress.Text, tboxEmailFront.Text+"@"+ cbboxEmailRear.Text
                );
            conn = new OracleConnection(str);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Comm = new OracleCommand();
                Comm.Connection = conn;
                Transact = conn.BeginTransaction();
                try
                {
                    Comm.CommandText = query;
                    FileStream fs =
                            new FileStream(string.Format("{0}", tboxFilePath.Text), FileMode.Open, FileAccess.Read);
                    byte[] b = new byte[fs.Length - 1];
                    fs.Read(b, 0, b.Length);
                    fs.Close();
                    OracleParameter oracleParameter = new OracleParameter();
                    oracleParameter.ParameterName = ":image";
                    oracleParameter.OracleDbType = OracleDbType.Blob;
                    oracleParameter.Direction = ParameterDirection.Input;
                    oracleParameter.Size = b.Length;
                    oracleParameter.Value = b;
                    Comm.Parameters.Add(oracleParameter);
                    Comm.ExecuteNonQuery();
                    Comm.Parameters.Clear();
                    Transact.Commit();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                    Transact.Rollback();
                }
            }
        }

        private void btnNewEnroll_Click(object sender, EventArgs e)
        {

        }

        // tabPage2

        private void btnImagereSch_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.Title = "이미지 열기";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                pboxEmp2.Image = new Bitmap(openFileDialog1.FileName);
            }
            pboxEmp2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnreImage_Click(object sender, EventArgs e)
        {
            pboxEmp2.Image.Dispose();
        }

        private void btnClearDelete_Click(object sender, EventArgs e)
        {
            //해당 레코드 sql삭제문 시행
            tabPage2.Controls.Clear();
        }
        // 기타 부가적인 이벤트들 1. tabkey 이벤트 
        private void btnEnroll_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == (char)Keys.Tab)
            {

            }
        }

        private void btnAddrSch_Click(object sender, EventArgs e)
        {
            AddressPopup addressPopup = new AddressPopup();
            addressPopup.ShowDialog();

            if (addressPopup.gstrZipCode != "")
            {
                tboxAddress.Text = addressPopup.gstrAddress1;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Employee> employeelist = new List<Employee>();
            employeelist = OraMgr.Instance.selectEmployee();
            employee.employeeGridView(employeelist, dtgviewEmployee);
        }

        private void dtgviewEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ecode = int.Parse(dtgviewEmployee.SelectedRows[0].Cells[colECode.Index].Value.ToString());
            List<Employee> employeelist = new List<Employee>();
            employeelist = OraMgr.Instance.selectEmployeeInfo(ecode);

            conn = new OracleConnection(str);
            conn.Open();
            OracleCommand sql =
                new OracleCommand(string.Format("select ename, departure, indate, birth, telnum, address, email, picture " +
                "from employee_t where ecode = {0}", ecode), conn);
            sql.CommandType = CommandType.Text;
            sql.InitialLONGFetchSize = -1;

            OracleDataReader rd = sql.ExecuteReader();

            while (rd.Read())
            {
                teboxEName.Text =rd["ename"].ToString();
                teboxDeparture.Text = rd["departure"].ToString();
                teboxInDate.Text = rd["indate"].ToString();
                teboxBirhtday.Text = rd["birth"].ToString();
                teboxTel.Text = rd["telnum"].ToString();
                teboxAddress.Text = rd["address"].ToString();
                teboxEmail.Text = rd["email"].ToString();

                String picture = rd.GetString(0);

                //
                // Call GetBytes() with a null Byte[] parameter in order to
                // get required length of data:
                //
                long len = rd.GetBytes(7, 0, null, 0, 0);

                //Console.WriteLine($"{file_name}: {len} bytes");

                //
                // Get data as Byte[]:
                //
                Byte[] bytes = new Byte[len];
                rd.GetBytes(7, 0, bytes, 0, (int)len);

                File.WriteAllBytes(picture, bytes);

                MemoryStream ms = null;
                Image img = null;
                try
                {
                    ms = new MemoryStream(bytes);
                    img = Image.FromStream(ms);
                    pboxEmp2.Image = (Image)img.Clone();
                    pboxEmp2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (ms != null)
                    {
                        ms.Dispose();
                        ms = null;
                    }
                    if (img != null)
                    {
                        img.Dispose();
                        img = null;
                    }
                }
            }
        }
    }
}
