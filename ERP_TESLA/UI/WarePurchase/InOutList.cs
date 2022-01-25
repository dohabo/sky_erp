using ERP_TESLA.CLASS.WarePurchase;
using ERP_TESLA.DAO;
using ERP_TESLA.UI.Common;
using ERP_TESLA.Utility;
using ERP_TESLA.Utility.Fuction;
using ERP_TESLA.Utility.Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.UI.WarePurchase
{
    /// <summary>
    /// name         : 입출고 내역
    /// function     : 재고 수불 현황 확인
    /// date of prep : 2022. 01. 03
    /// date of upd  : 
    /// </summary>
    public partial class InOutList : Form
    {
        string mCode;
        InOut inout = new InOut();
        ExcelFunc exl = new ExcelFunc();
        GridView gridview = new GridView();

        public InOutList()
        {
            InitializeComponent();
        }

        public InOutList(string mCode)
        {
            InitializeComponent();
            this.mCode = mCode;
        }

        private void InOutList_Load(object sender, EventArgs e)
        {
            dtgviewOrderList.Rows.Clear();
            Date getdate = new Date();
            dtpicInOutFrom.Text = getdate.getDateThisMonthFrom(dtpicInOutFrom);
            dtpicInOutTo.Text = getdate.getDateThisMonthTo(dtpicInOutTo);
            string[] inoutClass = new string[] {"전체","입고","출고"};
            cbboxInOut.Items.AddRange(inoutClass);
            cbboxInOut.Text = "전체";
            gridview.gridViewStyleSet(dtgviewOrderList);
            if (mCode != null)
            {
                List<InOut> inoutList = OraMgr.Instance.selectInOut(mCode);
                inout.inOutGridView(inoutList, dtgviewOrderList);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            exl.excelExport(dtgviewOrderList, "입출고 내역",dtpicInOutFrom, dtpicInOutTo);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgviewOrderList.Rows.Clear();

            Dictionary<string, string> search = new Dictionary<string, string>();
            search.Add("mcode", tboxMCode.Text);
            search.Add("wcode", tboxWCode.Text);

            Dictionary<string, string> searchCondition = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> pair in search)
            {
                if (pair.Value != "")
                {
                    searchCondition.Add(pair.Key, pair.Value);
                }
            }

            string[,] searchDate = new string[,]
            {
                {"inoutDate", dtpicInOutFrom.Text, dtpicInOutTo.Text},
            };

            List<InOut> inoutList = OraMgr.Instance.selectInOut(
                searchCondition, searchDate,cbboxInOut.Text);
            inout.inOutGridView(inoutList, dtgviewOrderList);
        }

        private void btnmCodeSearch_Click(object sender, EventArgs e)
        {
            MaterialPOP materialpop = new MaterialPOP();
            materialpop.ShowDialog();
            tboxMCode.Text = materialpop.Mcode;
        }

        private void btneCodeSearch_Click(object sender, EventArgs e)
        {
            WarehousePOP warehouse = new WarehousePOP();
            warehouse.ShowDialog();
        }
    }
}
