
namespace ERP_TESLA.UI.WarePurchase
{
    partial class InOutList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgviewOrderList = new System.Windows.Forms.DataGridView();
            this.colInOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsupplyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.btnPOrderPrinting = new Sunny.UI.UISymbolButton();
            this.btnPOrderPreview = new Sunny.UI.UISymbolButton();
            this.label2 = new System.Windows.Forms.Label();
            this.uiLine1 = new Sunny.UI.UILine();
            this.btnExportExcel = new Sunny.UI.UISymbolButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnpOrderCodeSearch = new Sunny.UI.UISymbolButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxMCode = new Sunny.UI.UITextBox();
            this.btnmCodeSearch = new Sunny.UI.UISymbolButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxWCode = new Sunny.UI.UITextBox();
            this.btneCodeSearch = new Sunny.UI.UISymbolButton();
            this.cbboxInOut = new Sunny.UI.UIComboBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpicInOutFrom = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpicInOutTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewOrderList)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgviewOrderList
            // 
            this.dtgviewOrderList.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgviewOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgviewOrderList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgviewOrderList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgviewOrderList.ColumnHeadersHeight = 30;
            this.dtgviewOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgviewOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInOut,
            this.colClass,
            this.colNumber,
            this.colMCode,
            this.colMName,
            this.colAmount,
            this.colWCode,
            this.colUnit,
            this.colInOutDate,
            this.colPrice,
            this.colsupplyPrice,
            this.colVat,
            this.colSumPrice});
            this.dtgviewOrderList.EnableHeadersVisualStyles = false;
            this.dtgviewOrderList.GridColor = System.Drawing.Color.DarkGray;
            this.dtgviewOrderList.Location = new System.Drawing.Point(29, 185);
            this.dtgviewOrderList.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dtgviewOrderList.Name = "dtgviewOrderList";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewOrderList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgviewOrderList.RowHeadersVisible = false;
            this.dtgviewOrderList.RowTemplate.Height = 30;
            this.dtgviewOrderList.Size = new System.Drawing.Size(965, 438);
            this.dtgviewOrderList.TabIndex = 99;
            // 
            // colInOut
            // 
            this.colInOut.HeaderText = "입출고";
            this.colInOut.Name = "colInOut";
            this.colInOut.Width = 90;
            // 
            // colClass
            // 
            this.colClass.HeaderText = "구분";
            this.colClass.Name = "colClass";
            this.colClass.Width = 80;
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "내역번호";
            this.colNumber.Name = "colNumber";
            // 
            // colMCode
            // 
            this.colMCode.HeaderText = "자재품번";
            this.colMCode.Name = "colMCode";
            // 
            // colMName
            // 
            this.colMName.HeaderText = "자재품명";
            this.colMName.Name = "colMName";
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "수량";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 80;
            // 
            // colWCode
            // 
            this.colWCode.HeaderText = "창고";
            this.colWCode.Name = "colWCode";
            this.colWCode.Width = 80;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "단위";
            this.colUnit.Name = "colUnit";
            this.colUnit.Width = 80;
            // 
            // colInOutDate
            // 
            this.colInOutDate.HeaderText = "입출고일";
            this.colInOutDate.Name = "colInOutDate";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "단가";
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 90;
            // 
            // colsupplyPrice
            // 
            this.colsupplyPrice.HeaderText = "공급가";
            this.colsupplyPrice.Name = "colsupplyPrice";
            this.colsupplyPrice.Width = 90;
            // 
            // colVat
            // 
            this.colVat.HeaderText = "부가세";
            this.colVat.Name = "colVat";
            this.colVat.Width = 90;
            // 
            // colSumPrice
            // 
            this.colSumPrice.HeaderText = "합계액";
            this.colSumPrice.Name = "colSumPrice";
            this.colSumPrice.Width = 90;
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
            this.btnSearch.Location = new System.Drawing.Point(921, 14);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RectColor = System.Drawing.Color.Transparent;
            this.btnSearch.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnSearch.RectPressColor = System.Drawing.Color.Transparent;
            this.btnSearch.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnSearch.Size = new System.Drawing.Size(71, 29);
            this.btnSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btnSearch.Symbol = 61442;
            this.btnSearch.TabIndex = 110;
            this.btnSearch.Text = "검색";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPOrderPrinting
            // 
            this.btnPOrderPrinting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOrderPrinting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnPOrderPrinting.FillHoverColor = System.Drawing.Color.Gray;
            this.btnPOrderPrinting.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPOrderPrinting.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnPOrderPrinting.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnPOrderPrinting.IsScaled = false;
            this.btnPOrderPrinting.Location = new System.Drawing.Point(844, 14);
            this.btnPOrderPrinting.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPOrderPrinting.Name = "btnPOrderPrinting";
            this.btnPOrderPrinting.RectColor = System.Drawing.Color.Transparent;
            this.btnPOrderPrinting.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnPOrderPrinting.RectPressColor = System.Drawing.Color.Transparent;
            this.btnPOrderPrinting.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnPOrderPrinting.Size = new System.Drawing.Size(71, 29);
            this.btnPOrderPrinting.Style = Sunny.UI.UIStyle.Custom;
            this.btnPOrderPrinting.Symbol = 61487;
            this.btnPOrderPrinting.TabIndex = 109;
            this.btnPOrderPrinting.Text = "인쇄";
            // 
            // btnPOrderPreview
            // 
            this.btnPOrderPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOrderPreview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnPOrderPreview.FillHoverColor = System.Drawing.Color.Gray;
            this.btnPOrderPreview.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPOrderPreview.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnPOrderPreview.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnPOrderPreview.IsScaled = false;
            this.btnPOrderPreview.Location = new System.Drawing.Point(736, 14);
            this.btnPOrderPreview.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPOrderPreview.Name = "btnPOrderPreview";
            this.btnPOrderPreview.RectColor = System.Drawing.Color.Transparent;
            this.btnPOrderPreview.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnPOrderPreview.RectPressColor = System.Drawing.Color.Transparent;
            this.btnPOrderPreview.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnPOrderPreview.Size = new System.Drawing.Size(102, 29);
            this.btnPOrderPreview.Style = Sunny.UI.UIStyle.Custom;
            this.btnPOrderPreview.Symbol = 62060;
            this.btnPOrderPreview.TabIndex = 111;
            this.btnPOrderPreview.Text = "미리보기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 107;
            this.label2.Text = "▶ 입출고 내역";
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLine1.IsScaled = false;
            this.uiLine1.LineColor = System.Drawing.Color.LightSlateGray;
            this.uiLine1.LineSize = 2;
            this.uiLine1.Location = new System.Drawing.Point(9, 47);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(990, 2);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 108;
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
            this.btnExportExcel.Location = new System.Drawing.Point(659, 14);
            this.btnExportExcel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.RectColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.RectPressColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.Size = new System.Drawing.Size(71, 29);
            this.btnExportExcel.Style = Sunny.UI.UIStyle.Custom;
            this.btnExportExcel.Symbol = 61714;
            this.btnExportExcel.TabIndex = 104;
            this.btnExportExcel.Text = "엑셀";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84128F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.31746F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.31746F));
            this.tableLayoutPanel3.Controls.Add(this.btnpOrderCodeSearch, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tboxMCode, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnmCodeSearch, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tboxWCode, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.btneCodeSearch, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbboxInOut, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(49, 71);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(487, 91);
            this.tableLayoutPanel3.TabIndex = 105;
            // 
            // btnpOrderCodeSearch
            // 
            this.btnpOrderCodeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpOrderCodeSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnpOrderCodeSearch.FillHoverColor = System.Drawing.Color.Gray;
            this.btnpOrderCodeSearch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnpOrderCodeSearch.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnpOrderCodeSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnpOrderCodeSearch.IsScaled = false;
            this.btnpOrderCodeSearch.Location = new System.Drawing.Point(195, 3);
            this.btnpOrderCodeSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnpOrderCodeSearch.Name = "btnpOrderCodeSearch";
            this.btnpOrderCodeSearch.RectColor = System.Drawing.Color.Transparent;
            this.btnpOrderCodeSearch.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnpOrderCodeSearch.RectPressColor = System.Drawing.Color.Transparent;
            this.btnpOrderCodeSearch.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnpOrderCodeSearch.Size = new System.Drawing.Size(42, 24);
            this.btnpOrderCodeSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btnpOrderCodeSearch.Symbol = 61442;
            this.btnpOrderCodeSearch.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "자재 구분";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(242, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "자재번호";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxMCode
            // 
            this.tboxMCode.ButtonSymbol = 61761;
            this.tboxMCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxMCode.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxMCode.IsScaled = false;
            this.tboxMCode.Location = new System.Drawing.Point(342, 5);
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
            // btnmCodeSearch
            // 
            this.btnmCodeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmCodeSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnmCodeSearch.FillHoverColor = System.Drawing.Color.Gray;
            this.btnmCodeSearch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmCodeSearch.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnmCodeSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnmCodeSearch.IsScaled = false;
            this.btnmCodeSearch.Location = new System.Drawing.Point(437, 3);
            this.btnmCodeSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnmCodeSearch.Name = "btnmCodeSearch";
            this.btnmCodeSearch.RectColor = System.Drawing.Color.Transparent;
            this.btnmCodeSearch.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnmCodeSearch.RectPressColor = System.Drawing.Color.Transparent;
            this.btnmCodeSearch.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnmCodeSearch.Size = new System.Drawing.Size(45, 24);
            this.btnmCodeSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btnmCodeSearch.Symbol = 61442;
            this.btnmCodeSearch.TabIndex = 12;
            this.btnmCodeSearch.Click += new System.EventHandler(this.btnmCodeSearch_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(242, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "창고";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxWCode
            // 
            this.tboxWCode.ButtonSymbol = 61761;
            this.tboxWCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxWCode.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxWCode.IsScaled = false;
            this.tboxWCode.Location = new System.Drawing.Point(342, 35);
            this.tboxWCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxWCode.Maximum = 2147483647D;
            this.tboxWCode.Minimum = -2147483648D;
            this.tboxWCode.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxWCode.Name = "tboxWCode";
            this.tboxWCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxWCode.Size = new System.Drawing.Size(88, 20);
            this.tboxWCode.Style = Sunny.UI.UIStyle.Custom;
            this.tboxWCode.TabIndex = 14;
            this.tboxWCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btneCodeSearch
            // 
            this.btneCodeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneCodeSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btneCodeSearch.FillHoverColor = System.Drawing.Color.Gray;
            this.btneCodeSearch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btneCodeSearch.FillSelectedColor = System.Drawing.Color.Gray;
            this.btneCodeSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btneCodeSearch.IsScaled = false;
            this.btneCodeSearch.Location = new System.Drawing.Point(437, 33);
            this.btneCodeSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btneCodeSearch.Name = "btneCodeSearch";
            this.btneCodeSearch.RectColor = System.Drawing.Color.Transparent;
            this.btneCodeSearch.RectHoverColor = System.Drawing.Color.Transparent;
            this.btneCodeSearch.RectPressColor = System.Drawing.Color.Transparent;
            this.btneCodeSearch.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btneCodeSearch.Size = new System.Drawing.Size(45, 24);
            this.btneCodeSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btneCodeSearch.Symbol = 61442;
            this.btneCodeSearch.TabIndex = 15;
            this.btneCodeSearch.Click += new System.EventHandler(this.btneCodeSearch_Click);
            // 
            // cbboxInOut
            // 
            this.cbboxInOut.DataSource = null;
            this.cbboxInOut.FillColor = System.Drawing.Color.White;
            this.cbboxInOut.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbboxInOut.IsScaled = false;
            this.cbboxInOut.Location = new System.Drawing.Point(100, 5);
            this.cbboxInOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbboxInOut.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbboxInOut.Name = "cbboxInOut";
            this.cbboxInOut.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbboxInOut.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.cbboxInOut.Size = new System.Drawing.Size(88, 20);
            this.cbboxInOut.Style = Sunny.UI.UIStyle.Custom;
            this.cbboxInOut.TabIndex = 17;
            this.cbboxInOut.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnSearch.Controls.Add(this.tableLayoutPanel4);
            this.pnSearch.Location = new System.Drawing.Point(29, 60);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(965, 117);
            this.pnSearch.TabIndex = 106;
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
            this.tableLayoutPanel4.Controls.Add(this.dtpicInOutFrom, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label17, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtpicInOutTo, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(530, 11);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(410, 60);
            this.tableLayoutPanel4.TabIndex = 112;
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
            this.label16.Text = "입출고일자";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpicInOutFrom
            // 
            this.dtpicInOutFrom.CalendarFont = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicInOutFrom.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicInOutFrom.Location = new System.Drawing.Point(100, 3);
            this.dtpicInOutFrom.Name = "dtpicInOutFrom";
            this.dtpicInOutFrom.Size = new System.Drawing.Size(123, 25);
            this.dtpicInOutFrom.TabIndex = 14;
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
            // dtpicInOutTo
            // 
            this.dtpicInOutTo.Checked = false;
            this.dtpicInOutTo.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicInOutTo.Location = new System.Drawing.Point(273, 3);
            this.dtpicInOutTo.Name = "dtpicInOutTo";
            this.dtpicInOutTo.Size = new System.Drawing.Size(130, 25);
            this.dtpicInOutTo.TabIndex = 14;
            // 
            // InOutList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 635);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPOrderPrinting);
            this.Controls.Add(this.btnPOrderPreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.dtgviewOrderList);
            this.Name = "InOutList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InOutList";
            this.Load += new System.EventHandler(this.InOutList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewOrderList)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgviewOrderList;
        private Sunny.UI.UISymbolButton btnSearch;
        private Sunny.UI.UISymbolButton btnPOrderPrinting;
        private Sunny.UI.UISymbolButton btnPOrderPreview;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolButton btnExportExcel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Sunny.UI.UISymbolButton btnpOrderCodeSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UITextBox tboxMCode;
        private Sunny.UI.UISymbolButton btnmCodeSearch;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UITextBox tboxWCode;
        private Sunny.UI.UISymbolButton btneCodeSearch;
        private Sunny.UI.UIComboBox cbboxInOut;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpicInOutFrom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpicInOutTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsupplyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSumPrice;
    }
}