using ERP_TESLA.DAO;
using ERP_TESLA.UI;
using ERP_TESLA.UI.Cost;
using ERP_TESLA.UI.HR;
using ERP_TESLA.UI.Production;
using ERP_TESLA.UI.Sales;
using ERP_TESLA.UI.Standard;
using ERP_TESLA.UI.WarePurchase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKY_ERP
{
    public partial class Main : Form
    {
        string[] uiname = new string[]
        {
            "판매 계획 등록",
            "수주 관리",
            "매출 관리",
            "발주 관리",
            "자재 입고 관리",
            "자재 출고 관리",
            "자재 관리",
            "매입 관리",
            "생산 계획",
            "작업지시",
            "소요 계획",
            "자재 출고요청",
            "작업 실적",
            "근태 관리",
            "급여관리",
            "제조 원가 관리",
            "제품별 원가 산출",
            "원가 분석",
            "사원 등록",
            "거래처 등록",
            "자재 마스터",
            "BOM",
            "공정",
            "창고"
        };

        // Panel 이동 (윈도우에서 끌고 오기) - 1
#pragma warning disable CS0108
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x02;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg,
            int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
#pragma warning restore CS0108

        // 사용자 정의 컨트롤 - 1
        const string UC_NAME_CT = "ContractUI";
        const string UC_NAME_SM = "salesMgtUI";
        const string UC_NAME_SP = "SalesPlanUI";

        const string UC_NAME_IP = "InputUI";
        const string UC_NAME_OD = "OrderUI";
        const string UC_NAME_OP = "OutputUI";
        const string UC_NAME_PM = "PurchaseMgtUI";
        const string UC_NAME_S = "StockUI";

        const string UC_NAME_MR = "MRPUI";
        const string UC_NAME_OPR = "OutputReqUI";
        const string UC_NAME_P = "PerformanceUI";
        const string UC_NAME_PP = "ProductPlanUI";
        const string UC_NAME_WO = "WorkOrderUI";

        const string UC_NAME_A = "AttendanceUI";
        const string UC_NAME_PR = "PayrollUI";

        const string UC_NAME_CA = "CostAnalysisUI";
        const string UC_NAME_CC = "CostCalculUI";
        const string UC_NAME_MC = "ManuCostUI";

        const string UC_NAME_E = "EmployeeUI";
        const string UC_NAME_C = "CompanyUI";
        const string UC_NAME_M = "MaterialUI";
        const string UC_NAME_O = "OperationUI";
        const string UC_NAME_B = "BOMUI";
        const string UC_NAME_W = "WarehouseUI";

        LoginUI login = new LoginUI();
        public Main()
        {
            Thread th = new Thread(new ThreadStart(startSplash));
            th.Start();
            Thread.Sleep(3000);
            th.Abort();
            login.ShowDialog(); // 로그인 화면
            InitializeComponent();
            OraMgr.Instance.connectDB();
        }

        // SPLASH UI
        public void startSplash()
        {
            Application.Run(new SplashUI());
        }

        // Panel 이동 (윈도우에서 끌고 오기) - 2
        private void pnTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // 사용자 정의 컨트롤 - 2 
        void controllView(UserControl uc, string viewName)
        {
            pnCenter.Controls.Clear();
            if (!pnCenter.Controls.ContainsKey(viewName))
            {
                uc.Dock = DockStyle.Fill;
                pnCenter.Controls.Add(uc);
            }
            pnCenter.Controls[viewName].BringToFront();
        }

        // 창 종료
        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 창 최소화
        private void mainMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // 서브 창 열고 닫기 
        private void customizeDesign()
        {
            pnBusiness.Visible = false;
            pnMatPurch.Visible = false;
            pnProduction.Visible = false;
            pnHR.Visible = false;
            pnCostMgt.Visible = false;
            pnStdInfo.Visible = false;
        }

        private void hideSubeMenu()
        {
            if (pnBusiness.Visible == true)
            {
                pnBusiness.Visible = false;
            }
            if (pnMatPurch.Visible == true)
            {
                pnMatPurch.Visible = false;
            }
            if (pnProduction.Visible == true)
            {
                pnProduction.Visible = false;
            }
            if (pnHR.Visible == true)
            {
                pnHR.Visible = false;
            }
            if (pnCostMgt.Visible == true)
            {
                pnCostMgt.Visible = false;
            }
            if (pnStdInfo.Visible == true)
            {
                pnStdInfo.Visible = false;
            }
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubeMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void btnBusinessMgt_Click(object sender, EventArgs e)
        {
            showSubMenu(pnBusiness);
        }

        private void btnMatPurcMgt_Click(object sender, EventArgs e)
        {
            showSubMenu(pnMatPurch);
        }

        private void btnProductionMgt_Click(object sender, EventArgs e)
        {
            showSubMenu(pnProduction);
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            showSubMenu(pnHR);
        }

        private void btnCostMgt_Click(object sender, EventArgs e)
        {
            showSubMenu(pnCostMgt);
        }

        private void btnStdInfoMgt_Click(object sender, EventArgs e)
        {
            showSubMenu(pnStdInfo);
        }

        private void btnSalesPlan_Click(object sender, EventArgs e)
        {
            controllView(new SalesPlanUI(), UC_NAME_SP);
        }

        private void btnContractMgt_Click(object sender, EventArgs e)
        {
            controllView(new ContractUI(), UC_NAME_CT);
        }

        private void btnSalesMgt_Click(object sender, EventArgs e)
        {
            controllView(new SalesMgtUI(), UC_NAME_SM);
        }

        private void btnOrderMgt_Click(object sender, EventArgs e)
        {
            controllView(new OrderUI(), UC_NAME_OD);
        }

        private void btnMInputMgt_Click(object sender, EventArgs e)
        {
            controllView(new InputUI(), UC_NAME_IP);
        }

        private void btnMOutputMgt_Click(object sender, EventArgs e)
        {
            controllView(new OutputUI(), UC_NAME_OP);
        }

        private void btnMaterialMgt_Click(object sender, EventArgs e)
        {
            controllView(new StockUI(), UC_NAME_S);
        }

        private void btnPurchaseMgt_Click(object sender, EventArgs e)
        {
            controllView(new PurchaseMgtUI(), UC_NAME_PM);
        }

        private void btnProdutionPlan_Click(object sender, EventArgs e)
        {
            controllView(new ProductPlanUI(), UC_NAME_PP);
        }

        private void btnMaterialPlan_Click(object sender, EventArgs e)
        {
            controllView(new MRPUI(), UC_NAME_MR);
        }

        private void btnMaterialReq_Click(object sender, EventArgs e)
        {
            controllView(new OutputReqUI(), UC_NAME_OPR);
        }

        private void btnWorkOrder_Click(object sender, EventArgs e)
        {
            controllView(new WorkOrderUI(), UC_NAME_WO);
        }

        private void btnWorkResult_Click(object sender, EventArgs e)
        {
            controllView(new PerformanceUI(), UC_NAME_P);
        }

        private void btnEmpAttitude_Click(object sender, EventArgs e)
        {
            controllView(new AttendanceUI(), UC_NAME_A);
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            controllView(new PayrollUI(), UC_NAME_PR);
        }

        private void btnManuCost_Click(object sender, EventArgs e)
        {
            controllView(new ManuCostUI(), UC_NAME_MC);
        }

        private void btnCostResult_Click(object sender, EventArgs e)
        {
            controllView(new CostCalculUI(), UC_NAME_CC);
        }

        private void btnCostAnalysis_Click(object sender, EventArgs e)
        {
            controllView(new CostAnalysisUI(), UC_NAME_CA);
        }
        private void btnEmployeeMgt_Click(object sender, EventArgs e)
        {
            controllView(new EmployeeUI(), UC_NAME_E);
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            controllView(new CompanyUI(), UC_NAME_C);
        }

        private void btnMaterialMaster_Click(object sender, EventArgs e)
        {
            controllView(new MaterialUI(), UC_NAME_M);
        }

        private void btnBOM_Click(object sender, EventArgs e)
        {
            controllView(new BOMUI(), UC_NAME_B);
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            controllView(new OperationUI(), UC_NAME_O);
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            controllView(new WarehouseUI(), UC_NAME_W);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            customizeDesign();
            
            // Create the list to use as the custom source. 
            var source = new AutoCompleteStringCollection();
            source.AddRange(uiname);

            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchUI(sender, e, textBox1);
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e) 
        { 
            if (e.KeyCode == Keys.Enter) 
            {
                searchUI(sender, e, textBox1);
            }
        }

        void searchUI(Object sender, EventArgs e, TextBox textbox)
        {
            if (textbox.Text == "판매 계획 등록") btnOrderMgt_Click(sender, e);
            else if (textbox.Text == "수주 관리") btnContractMgt_Click(sender, e);
            else if (textbox.Text == "매출 관리") btnSalesMgt_Click(sender, e);
            else if (textbox.Text == "자재 입고 관리") btnMInputMgt_Click(sender, e);
            else if (textbox.Text == "자재 출고 관리") btnMOutputMgt_Click(sender, e);
            else if (textbox.Text == "자재 관리") btnMaterialMgt_Click(sender, e);
            else if (textbox.Text == "매입 관리") btnPurchaseMgt_Click(sender, e);
            else if (textbox.Text == "생산 계획") btnProdutionPlan_Click(sender, e);
            else if (textbox.Text == "작업지시") btnWorkOrder_Click(sender, e);
            else if (textbox.Text == "소요 계획") btnMaterialPlan_Click(sender, e);
            else if (textbox.Text == "자재 출고요청") btnMaterialReq_Click(sender, e);
            else if (textbox.Text == "작업 실적") btnWorkResult_Click(sender, e);
            else if (textbox.Text == "근태 관리") btnEmpAttitude_Click(sender, e);
            else if (textbox.Text == "급여관리") btnPayroll_Click(sender, e);
            else if (textbox.Text == "제조 원가 관리") btnManuCost_Click(sender, e);
            else if (textbox.Text == "제품별 원가 산출") btnCostResult_Click(sender, e);
            else if (textbox.Text == "원가 분석") btnCostAnalysis_Click(sender, e);
            else if (textbox.Text == "사원 등록") btnEmployeeMgt_Click(sender, e);
            else if (textbox.Text == "거래처 등록") btnCompany_Click(sender, e);
            else if (textbox.Text == "자재 마스터") btnMaterialMaster_Click(sender, e);
            else if (textbox.Text == "BOM") btnBOM_Click(sender, e);
            else if (textbox.Text == "공정") btnOperation_Click(sender, e);
            else if (textbox.Text == "창고") btnWarehouse_Click(sender, e);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            lblNumber.Text = login.id(); // 로그인 성공 시 메인화면에 사번 표시 됨
            string dep = OraMgr.Instance.selectDeparture(lblNumber.Text);
            if (dep == "구매")
            {
                NoticeMRP noticemrp = new NoticeMRP();
                noticemrp.ShowDialog();
            }
            else if (dep == "생산")
            {
                NoticeOutputReq noticeOutputreq = new NoticeOutputReq();
                noticeOutputreq.ShowDialog();
            }
            else if (dep == "자재")
            {
                NoticeOutputReq noticeOutputreq = new NoticeOutputReq();
                noticeOutputreq.ShowDialog();
            }
        }
    }
}
