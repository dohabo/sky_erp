
namespace ERP_TESLA.UI.Cost
{
    partial class CostCalculUI
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostCalculUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiLine1 = new Sunny.UI.UILine();
            this.lblConUISub = new System.Windows.Forms.Label();
            this.dtgviewCostList = new System.Windows.Forms.DataGridView();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnsetYear = new Sunny.UI.UIButton();
            this.btnsetMonth = new Sunny.UI.UIButton();
            this.btnsetWeek = new Sunny.UI.UIButton();
            this.btnsetToday = new Sunny.UI.UIButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxMCode = new Sunny.UI.UITextBox();
            this.btnMCodeSearch = new Sunny.UI.UISymbolButton();
            this.label6 = new System.Windows.Forms.Label();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.cbboxPStatus = new Sunny.UI.UIComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpicFrom = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpicTo = new System.Windows.Forms.DateTimePicker();
            this.btnCostPreview = new Sunny.UI.UISymbolButton();
            this.btnCostPrinting = new Sunny.UI.UISymbolButton();
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.btnExportExcel = new Sunny.UI.UISymbolButton();
            this.btnCostCal = new Sunny.UI.UISymbolButton();
            this.btnCostSave = new Sunny.UI.UISymbolButton();
            this.pdialCost = new System.Windows.Forms.PrintDialog();
            this.pdocCost = new System.Drawing.Printing.PrintDocument();
            this.ppviewdialCost = new System.Windows.Forms.PrintPreviewDialog();
            this.colMCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStandard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterialCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaborCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOverheadCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewCostList)).BeginInit();
            this.pnSearch.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLine1.IsScaled = false;
            this.uiLine1.LineColor = System.Drawing.Color.LightSlateGray;
            this.uiLine1.LineSize = 2;
            this.uiLine1.Location = new System.Drawing.Point(0, 38);
            this.uiLine1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(1040, 2);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 83;
            // 
            // lblConUISub
            // 
            this.lblConUISub.AutoSize = true;
            this.lblConUISub.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblConUISub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.lblConUISub.Location = new System.Drawing.Point(5, 6);
            this.lblConUISub.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblConUISub.Name = "lblConUISub";
            this.lblConUISub.Size = new System.Drawing.Size(156, 21);
            this.lblConUISub.TabIndex = 82;
            this.lblConUISub.Text = "▶ 제품별 원가 분석";
            // 
            // dtgviewCostList
            // 
            this.dtgviewCostList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgviewCostList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgviewCostList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgviewCostList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewCostList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgviewCostList.ColumnHeadersHeight = 30;
            this.dtgviewCostList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgviewCostList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMCode,
            this.colMName,
            this.colStandard,
            this.colPassAmount,
            this.colFailAmount,
            this.colMaterialCost,
            this.colFailCost,
            this.colLaborCost,
            this.colOverheadCost,
            this.colSumPrice});
            this.dtgviewCostList.EnableHeadersVisualStyles = false;
            this.dtgviewCostList.GridColor = System.Drawing.Color.DarkGray;
            this.dtgviewCostList.Location = new System.Drawing.Point(10, 211);
            this.dtgviewCostList.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dtgviewCostList.Name = "dtgviewCostList";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewCostList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgviewCostList.RowTemplate.Height = 30;
            this.dtgviewCostList.Size = new System.Drawing.Size(1002, 447);
            this.dtgviewCostList.TabIndex = 84;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnSearch.Controls.Add(this.btnsetYear);
            this.pnSearch.Controls.Add(this.btnsetMonth);
            this.pnSearch.Controls.Add(this.btnsetWeek);
            this.pnSearch.Controls.Add(this.btnsetToday);
            this.pnSearch.Controls.Add(this.tableLayoutPanel3);
            this.pnSearch.Controls.Add(this.tableLayoutPanel4);
            this.pnSearch.Location = new System.Drawing.Point(10, 49);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(965, 117);
            this.pnSearch.TabIndex = 85;
            // 
            // btnsetYear
            // 
            this.btnsetYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsetYear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnsetYear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnsetYear.IsScaled = false;
            this.btnsetYear.Location = new System.Drawing.Point(687, 46);
            this.btnsetYear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnsetYear.Name = "btnsetYear";
            this.btnsetYear.RectColor = System.Drawing.Color.Transparent;
            this.btnsetYear.Size = new System.Drawing.Size(42, 25);
            this.btnsetYear.Style = Sunny.UI.UIStyle.Custom;
            this.btnsetYear.TabIndex = 99;
            this.btnsetYear.Text = "년";
            this.btnsetYear.Click += new System.EventHandler(this.btnsetYear_Click);
            // 
            // btnsetMonth
            // 
            this.btnsetMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsetMonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnsetMonth.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnsetMonth.IsScaled = false;
            this.btnsetMonth.Location = new System.Drawing.Point(639, 46);
            this.btnsetMonth.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnsetMonth.Name = "btnsetMonth";
            this.btnsetMonth.RectColor = System.Drawing.Color.Transparent;
            this.btnsetMonth.Size = new System.Drawing.Size(42, 25);
            this.btnsetMonth.Style = Sunny.UI.UIStyle.Custom;
            this.btnsetMonth.TabIndex = 98;
            this.btnsetMonth.Text = "월";
            this.btnsetMonth.Click += new System.EventHandler(this.btnsetMonth_Click);
            // 
            // btnsetWeek
            // 
            this.btnsetWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsetWeek.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnsetWeek.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnsetWeek.IsScaled = false;
            this.btnsetWeek.Location = new System.Drawing.Point(591, 46);
            this.btnsetWeek.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnsetWeek.Name = "btnsetWeek";
            this.btnsetWeek.RectColor = System.Drawing.Color.Transparent;
            this.btnsetWeek.Size = new System.Drawing.Size(42, 25);
            this.btnsetWeek.Style = Sunny.UI.UIStyle.Custom;
            this.btnsetWeek.TabIndex = 97;
            this.btnsetWeek.Text = "주";
            this.btnsetWeek.Click += new System.EventHandler(this.btnsetWeek_Click);
            // 
            // btnsetToday
            // 
            this.btnsetToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsetToday.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnsetToday.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnsetToday.IsScaled = false;
            this.btnsetToday.Location = new System.Drawing.Point(543, 46);
            this.btnsetToday.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnsetToday.Name = "btnsetToday";
            this.btnsetToday.RectColor = System.Drawing.Color.Transparent;
            this.btnsetToday.Size = new System.Drawing.Size(42, 25);
            this.btnsetToday.Style = Sunny.UI.UIStyle.Custom;
            this.btnsetToday.TabIndex = 96;
            this.btnsetToday.Text = "일";
            this.btnsetToday.Click += new System.EventHandler(this.btnsetToday_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84128F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.31746F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.31746F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tboxMCode, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnMCodeSearch, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiComboBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbboxPStatus, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 10);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(487, 91);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "프로젝트";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(0, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "품번";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxMCode
            // 
            this.tboxMCode.ButtonSymbol = 61761;
            this.tboxMCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxMCode.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxMCode.IsScaled = false;
            this.tboxMCode.Location = new System.Drawing.Point(100, 35);
            this.tboxMCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxMCode.Maximum = 2147483647D;
            this.tboxMCode.Minimum = -2147483648D;
            this.tboxMCode.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxMCode.Name = "tboxMCode";
            this.tboxMCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxMCode.Size = new System.Drawing.Size(88, 20);
            this.tboxMCode.Style = Sunny.UI.UIStyle.Custom;
            this.tboxMCode.TabIndex = 12;
            this.tboxMCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMCodeSearch
            // 
            this.btnMCodeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMCodeSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnMCodeSearch.FillHoverColor = System.Drawing.Color.Gray;
            this.btnMCodeSearch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMCodeSearch.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnMCodeSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnMCodeSearch.IsScaled = false;
            this.btnMCodeSearch.Location = new System.Drawing.Point(195, 33);
            this.btnMCodeSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMCodeSearch.Name = "btnMCodeSearch";
            this.btnMCodeSearch.RectColor = System.Drawing.Color.Transparent;
            this.btnMCodeSearch.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnMCodeSearch.RectPressColor = System.Drawing.Color.Transparent;
            this.btnMCodeSearch.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnMCodeSearch.Size = new System.Drawing.Size(42, 24);
            this.btnMCodeSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btnMCodeSearch.Symbol = 61442;
            this.btnMCodeSearch.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(242, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "구분";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiComboBox1.IsScaled = false;
            this.uiComboBox1.Location = new System.Drawing.Point(100, 5);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.uiComboBox1.Size = new System.Drawing.Size(88, 20);
            this.uiComboBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiComboBox1.TabIndex = 18;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbboxPStatus
            // 
            this.cbboxPStatus.DataSource = null;
            this.cbboxPStatus.FillColor = System.Drawing.Color.White;
            this.cbboxPStatus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbboxPStatus.IsScaled = false;
            this.cbboxPStatus.Location = new System.Drawing.Point(342, 5);
            this.cbboxPStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbboxPStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbboxPStatus.Name = "cbboxPStatus";
            this.cbboxPStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbboxPStatus.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.cbboxPStatus.Size = new System.Drawing.Size(88, 20);
            this.cbboxPStatus.Style = Sunny.UI.UIStyle.Custom;
            this.cbboxPStatus.TabIndex = 17;
            this.cbboxPStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.7691F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.95586F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.319185F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.95586F));
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtpicFrom, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label17, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtpicTo, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(540, 10);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(410, 30);
            this.tableLayoutPanel4.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 30);
            this.label16.TabIndex = 9;
            this.label16.Text = "기간";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpicFrom
            // 
            this.dtpicFrom.CalendarFont = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicFrom.CustomFormat = "yyyy-mm-dd";
            this.dtpicFrom.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicFrom.Location = new System.Drawing.Point(100, 3);
            this.dtpicFrom.Name = "dtpicFrom";
            this.dtpicFrom.Size = new System.Drawing.Size(123, 25);
            this.dtpicFrom.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(236, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 30);
            this.label17.TabIndex = 9;
            this.label17.Text = "~";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpicTo
            // 
            this.dtpicTo.Checked = false;
            this.dtpicTo.CustomFormat = "yyyy-mm-dd";
            this.dtpicTo.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicTo.Location = new System.Drawing.Point(273, 3);
            this.dtpicTo.Name = "dtpicTo";
            this.dtpicTo.Size = new System.Drawing.Size(130, 25);
            this.dtpicTo.TabIndex = 14;
            // 
            // btnCostPreview
            // 
            this.btnCostPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCostPreview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnCostPreview.FillHoverColor = System.Drawing.Color.Gray;
            this.btnCostPreview.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCostPreview.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnCostPreview.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnCostPreview.IsScaled = false;
            this.btnCostPreview.Location = new System.Drawing.Point(781, 6);
            this.btnCostPreview.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCostPreview.Name = "btnCostPreview";
            this.btnCostPreview.RectColor = System.Drawing.Color.Transparent;
            this.btnCostPreview.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnCostPreview.RectPressColor = System.Drawing.Color.Transparent;
            this.btnCostPreview.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnCostPreview.Size = new System.Drawing.Size(102, 29);
            this.btnCostPreview.Style = Sunny.UI.UIStyle.Custom;
            this.btnCostPreview.Symbol = 62060;
            this.btnCostPreview.TabIndex = 103;
            this.btnCostPreview.Text = "미리보기";
            this.btnCostPreview.Click += new System.EventHandler(this.btnCostPreview_Click);
            // 
            // btnCostPrinting
            // 
            this.btnCostPrinting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCostPrinting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnCostPrinting.FillHoverColor = System.Drawing.Color.Gray;
            this.btnCostPrinting.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCostPrinting.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnCostPrinting.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnCostPrinting.IsScaled = false;
            this.btnCostPrinting.Location = new System.Drawing.Point(889, 6);
            this.btnCostPrinting.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCostPrinting.Name = "btnCostPrinting";
            this.btnCostPrinting.RectColor = System.Drawing.Color.Transparent;
            this.btnCostPrinting.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnCostPrinting.RectPressColor = System.Drawing.Color.Transparent;
            this.btnCostPrinting.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnCostPrinting.Size = new System.Drawing.Size(71, 29);
            this.btnCostPrinting.Style = Sunny.UI.UIStyle.Custom;
            this.btnCostPrinting.Symbol = 61487;
            this.btnCostPrinting.TabIndex = 101;
            this.btnCostPrinting.Text = "인쇄";
            this.btnCostPrinting.Click += new System.EventHandler(this.btnCostPrinting_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnSearch.FillHoverColor = System.Drawing.Color.Gray;
            this.btnSearch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSearch.IsScaled = false;
            this.btnSearch.Location = new System.Drawing.Point(966, 6);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RectColor = System.Drawing.Color.Transparent;
            this.btnSearch.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnSearch.RectPressColor = System.Drawing.Color.Transparent;
            this.btnSearch.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnSearch.Size = new System.Drawing.Size(71, 29);
            this.btnSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btnSearch.Symbol = 61442;
            this.btnSearch.TabIndex = 102;
            this.btnSearch.Text = "검색";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnExportExcel.FillHoverColor = System.Drawing.Color.Gray;
            this.btnExportExcel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExportExcel.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnExportExcel.IsScaled = false;
            this.btnExportExcel.Location = new System.Drawing.Point(704, 6);
            this.btnExportExcel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.RectColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.RectPressColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.Size = new System.Drawing.Size(71, 29);
            this.btnExportExcel.Style = Sunny.UI.UIStyle.Custom;
            this.btnExportExcel.Symbol = 61714;
            this.btnExportExcel.TabIndex = 100;
            this.btnExportExcel.Text = "엑셀";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnCostCal
            // 
            this.btnCostCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCostCal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnCostCal.FillHoverColor = System.Drawing.Color.Gray;
            this.btnCostCal.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCostCal.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnCostCal.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnCostCal.IsScaled = false;
            this.btnCostCal.Location = new System.Drawing.Point(864, 174);
            this.btnCostCal.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCostCal.Name = "btnCostCal";
            this.btnCostCal.RectColor = System.Drawing.Color.Transparent;
            this.btnCostCal.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnCostCal.RectPressColor = System.Drawing.Color.Transparent;
            this.btnCostCal.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnCostCal.Size = new System.Drawing.Size(71, 31);
            this.btnCostCal.Style = Sunny.UI.UIStyle.Custom;
            this.btnCostCal.Symbol = 361932;
            this.btnCostCal.TabIndex = 104;
            this.btnCostCal.Text = "계산";
            this.btnCostCal.Click += new System.EventHandler(this.btnCostCal_Click);
            // 
            // btnCostSave
            // 
            this.btnCostSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCostSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnCostSave.FillHoverColor = System.Drawing.Color.Gray;
            this.btnCostSave.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCostSave.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnCostSave.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnCostSave.IsScaled = false;
            this.btnCostSave.Location = new System.Drawing.Point(941, 174);
            this.btnCostSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCostSave.Name = "btnCostSave";
            this.btnCostSave.RectColor = System.Drawing.Color.Transparent;
            this.btnCostSave.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnCostSave.RectPressColor = System.Drawing.Color.Transparent;
            this.btnCostSave.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnCostSave.Size = new System.Drawing.Size(71, 31);
            this.btnCostSave.Style = Sunny.UI.UIStyle.Custom;
            this.btnCostSave.Symbol = 61639;
            this.btnCostSave.TabIndex = 105;
            this.btnCostSave.Text = "확정";
            // 
            // pdialCost
            // 
            this.pdialCost.UseEXDialog = true;
            // 
            // pdocCost
            // 
            this.pdocCost.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocCost_PrintPage);
            // 
            // ppviewdialCost
            // 
            this.ppviewdialCost.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppviewdialCost.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppviewdialCost.ClientSize = new System.Drawing.Size(400, 300);
            this.ppviewdialCost.Enabled = true;
            this.ppviewdialCost.Icon = ((System.Drawing.Icon)(resources.GetObject("ppviewdialCost.Icon")));
            this.ppviewdialCost.Name = "ppviewdialCost";
            this.ppviewdialCost.Visible = false;
            // 
            // colMCode
            // 
            this.colMCode.HeaderText = "품번";
            this.colMCode.Name = "colMCode";
            // 
            // colMName
            // 
            this.colMName.HeaderText = "품명";
            this.colMName.Name = "colMName";
            this.colMName.Width = 120;
            // 
            // colStandard
            // 
            this.colStandard.HeaderText = "규격";
            this.colStandard.Name = "colStandard";
            this.colStandard.Width = 140;
            // 
            // colPassAmount
            // 
            this.colPassAmount.HeaderText = "실적수량";
            this.colPassAmount.Name = "colPassAmount";
            // 
            // colFailAmount
            // 
            this.colFailAmount.HeaderText = "불량수량";
            this.colFailAmount.Name = "colFailAmount";
            // 
            // colMaterialCost
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.colMaterialCost.DefaultCellStyle = dataGridViewCellStyle3;
            this.colMaterialCost.HeaderText = "재료비";
            this.colMaterialCost.Name = "colMaterialCost";
            // 
            // colFailCost
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.colFailCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFailCost.HeaderText = "불량금액";
            this.colFailCost.Name = "colFailCost";
            // 
            // colLaborCost
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.colLaborCost.DefaultCellStyle = dataGridViewCellStyle5;
            this.colLaborCost.HeaderText = "노무비";
            this.colLaborCost.Name = "colLaborCost";
            // 
            // colOverheadCost
            // 
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.colOverheadCost.DefaultCellStyle = dataGridViewCellStyle6;
            this.colOverheadCost.HeaderText = "간접비";
            this.colOverheadCost.Name = "colOverheadCost";
            // 
            // colSumPrice
            // 
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.colSumPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.colSumPrice.HeaderText = "합계액";
            this.colSumPrice.Name = "colSumPrice";
            // 
            // CostCalculUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCostSave);
            this.Controls.Add(this.btnCostPreview);
            this.Controls.Add(this.btnCostCal);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.btnCostPrinting);
            this.Controls.Add(this.dtgviewCostList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.lblConUISub);
            this.Name = "CostCalculUI";
            this.Size = new System.Drawing.Size(1040, 674);
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewCostList)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILine uiLine1;
        private System.Windows.Forms.Label lblConUISub;
        private System.Windows.Forms.DataGridView dtgviewCostList;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UITextBox tboxMCode;
        private Sunny.UI.UISymbolButton btnMCodeSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpicFrom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpicTo;
        private Sunny.UI.UIButton btnsetYear;
        private Sunny.UI.UIButton btnsetMonth;
        private Sunny.UI.UIButton btnsetWeek;
        private Sunny.UI.UIButton btnsetToday;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIComboBox cbboxPStatus;
        private Sunny.UI.UISymbolButton btnCostPreview;
        private Sunny.UI.UISymbolButton btnCostPrinting;
        private Sunny.UI.UISymbolButton btnSearch;
        private Sunny.UI.UISymbolButton btnExportExcel;
        private Sunny.UI.UISymbolButton btnCostCal;
        private Sunny.UI.UISymbolButton btnCostSave;
        private System.Windows.Forms.PrintDialog pdialCost;
        private System.Drawing.Printing.PrintDocument pdocCost;
        private System.Windows.Forms.PrintPreviewDialog ppviewdialCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFailAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterialCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFailCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaborCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOverheadCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSumPrice;
    }
}
