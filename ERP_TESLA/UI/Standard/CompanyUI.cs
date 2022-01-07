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
    public partial class CompanyUI : UserControl
    {
        public CompanyUI()
        {
            InitializeComponent();
        }

        private void CompanyUI_Load(object sender, EventArgs e)
        {
            initCompanyListView();
        }

        string[] errMsg = new string[]
        {
            "거래처명이 누락되었습니다.",
            "전화번호가 누락되었습니다.",
            "주소가 누락되었습니다.",
            "대표자명이 누락되었습니다.",
            "사업자등록번호가 누락되었습니다."
        };

        // tabcontrol 전환 시
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            initCompanyListView();
        }

        // 거래처 코드 검색 시
        private void btncCodeSearch_Click(object sender, EventArgs e)
        {
            string cCode = tboxcCode.Text;
            if(cCode == "")
            {
                MessageBox.Show("거래처 코드를 입력해주세요.");
                return;
            }
            initCompanyListView(int.Parse(cCode));
        }

        // 등록
        private void btnCompanyAdd_Click(object sender, EventArgs e)
        {
            string cName = tboxcName.Text;
            string ceoName = tboxceoName.Text;
            string regNum = tboxregNum.Text;
            string telNum = tboxtelNum.Text;
            string address = tboxaddress.Text;

            // 데이터 누락
            string[] dataArr = new string[]
            {
                cName, telNum, address, ceoName, regNum
            };

            for(int i = 0; i < dataArr.Length; i++)
            {
                if(dataArr[i] == "")
                {
                    MessageBox.Show(errMsg[i]);
                    return;
                }
            }

            Company company = new Company(cName, ceoName, regNum, telNum, address);

            OraMgr.Instance.insertCompany(company);

            MessageBox.Show("등록 완료");

        }

        // 새로고침
        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxcName.Clear();
            tboxceoName.Clear();
            tboxregNum.Clear();
            tboxtelNum.Clear();
            tboxaddress.Clear();
        }

        //  회사 정보 보여주는 메소드
        void initCompanyListView()
        {
            dtgviewCompanyList.Rows.Clear();
            List<Company> list = OraMgr.Instance.selectCompany();
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewCompanyList.Rows.Add(new string[]
                {
                        list[i].CCode.ToString(),
                        list[i].CName.ToString(),
                        list[i].TelNum.ToString(),
                        list[i].Address.ToString(),
                        list[i].CeoName.ToString(),
                        list[i].RegNum.ToString()
                }) ;
            }
        }

        void initCompanyListView(int cCode)
        {
            dtgviewCompanyList.Rows.Clear();
            List<Company> list = OraMgr.Instance.selectCompany(cCode);
            for (int i = 0; i < list.Count; i++)
            {
                dtgviewCompanyList.Rows.Add(new string[]
                {
                        list[i].CCode.ToString(),
                        list[i].CName.ToString(),
                        list[i].TelNum.ToString(),
                        list[i].Address.ToString(),
                        list[i].CeoName.ToString(),
                        list[i].RegNum.ToString()
                });
            }
        }

        // 한 행 선택 시 데이터 값 textbox에 뿌려주기
        private void dtgviewCompanyList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = dtgviewCompanyList.CurrentRow.Index;
            tboxcCodeShow.Text = dtgviewCompanyList.Rows[rowIndex].Cells[0].Value.ToString();
            tboxcNameShow.Text = dtgviewCompanyList.Rows[rowIndex].Cells[1].Value.ToString();
            tboxtelNumShow.Text = dtgviewCompanyList.Rows[rowIndex].Cells[2].Value.ToString();
            tboxaddressShow.Text = dtgviewCompanyList.Rows[rowIndex].Cells[3].Value.ToString();
            tboxceoNameShow.Text = dtgviewCompanyList.Rows[rowIndex].Cells[4].Value.ToString();
            tboxregNumShow.Text = dtgviewCompanyList.Rows[rowIndex].Cells[5].Value.ToString();
        }
        
        // 삭제
        private void btnCompanyDelete_Click(object sender, EventArgs e)
        {
            string cCode = tboxcCodeShow.Text;
            if (cCode == "")
            {
                MessageBox.Show("거래처를 선택해주세요.","경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("거래처 정보를 삭제하시겠습니까?", "Inform", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    OraMgr.Instance.deleteCompany(int.Parse(cCode));
                    initCompanyListView();
                }
                else if (dialogResult == DialogResult.Cancel)
                {

                }
            }           
        }

        // 수정
        private void btnCompanyUpdate_Click(object sender, EventArgs e)
        {
            if (tboxcCodeShow.Text == "")
            {
                MessageBox.Show("거래처를 선택해주세요.", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                int cCode = int.Parse(tboxcCodeShow.Text);
                string cName = tboxcNameShow.Text;
                string ceoName = tboxceoNameShow.Text;
                string regNum = tboxregNumShow.Text;
                string telNum = tboxtelNumShow.Text;
                string address = tboxaddressShow.Text;

                // 데이터 누락
                string[] dataArr = new string[]
                {
                cName, telNum, address, ceoName, regNum
                };

                for (int i = 0; i < dataArr.Length; i++)
                {
                    if (dataArr[i] == "")
                    {
                        MessageBox.Show(errMsg[i]);
                        return;
                    }
                }

                DialogResult dialogResult = MessageBox.Show("거래처 정보를 수정하시겠습니까?", "Inform", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.OK)
                {
                    Company company = new Company(cCode, cName, ceoName, regNum, telNum, address);
                    OraMgr.Instance.updateCompany(company);

                    initCompanyListView();
                }
                else if (dialogResult == DialogResult.Cancel)
                {

                }
            }           
        }      
    }
}
