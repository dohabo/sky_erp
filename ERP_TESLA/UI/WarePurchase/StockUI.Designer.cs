
namespace ERP_TESLA.UI.WarePurchase
{
    partial class StockUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockUI));
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.dtgviewStockList = new System.Windows.Forms.DataGridView();
            this.btnPrinting = new Sunny.UI.UISymbolButton();
            this.btnPreview = new Sunny.UI.UISymbolButton();
            this.label2 = new System.Windows.Forms.Label();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.btnExportExcel = new Sunny.UI.UISymbolButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnpOrderCodeSearch = new Sunny.UI.UISymbolButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxStandard = new Sunny.UI.UITextBox();
            this.btncCodeSearch = new Sunny.UI.UISymbolButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxMCode = new Sunny.UI.UITextBox();
            this.btnmCodeSearch = new Sunny.UI.UISymbolButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxWCode = new Sunny.UI.UITextBox();
            this.btneCodeSearch = new Sunny.UI.UISymbolButton();
            this.cbboxMClass = new Sunny.UI.UIComboBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnShowDetail = new Sunny.UI.UISymbolButton();
            this.pdialStock = new System.Windows.Forms.PrintDialog();
            this.pdocStock = new System.Drawing.Printing.PrintDocument();
            this.ppviewdialStock = new System.Windows.Forms.PrintPreviewDialog();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewStockList)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSearch.Location = new System.Drawing.Point(966, 5);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RectColor = System.Drawing.Color.Transparent;
            this.btnSearch.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnSearch.RectPressColor = System.Drawing.Color.Transparent;
            this.btnSearch.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnSearch.Size = new System.Drawing.Size(71, 29);
            this.btnSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btnSearch.Symbol = 61442;
            this.btnSearch.TabIndex = 99;
            this.btnSearch.Text = "검색";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtgviewStockList
            // 
            this.dtgviewStockList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgviewStockList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgviewStockList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgviewStockList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewStockList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgviewStockList.ColumnHeadersHeight = 30;
            this.dtgviewStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgviewStockList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colMName,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgviewStockList.EnableHeadersVisualStyles = false;
            this.dtgviewStockList.GridColor = System.Drawing.Color.DarkGray;
            this.dtgviewStockList.Location = new System.Drawing.Point(20, 211);
            this.dtgviewStockList.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dtgviewStockList.Name = "dtgviewStockList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewStockList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgviewStockList.RowTemplate.Height = 30;
            this.dtgviewStockList.Size = new System.Drawing.Size(1002, 446);
            this.dtgviewStockList.TabIndex = 97;
            // 
            // btnPrinting
            // 
            this.btnPrinting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrinting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnPrinting.FillHoverColor = System.Drawing.Color.Gray;
            this.btnPrinting.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrinting.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnPrinting.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnPrinting.IsScaled = false;
            this.btnPrinting.Location = new System.Drawing.Point(889, 5);
            this.btnPrinting.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.RectColor = System.Drawing.Color.Transparent;
            this.btnPrinting.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnPrinting.RectPressColor = System.Drawing.Color.Transparent;
            this.btnPrinting.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnPrinting.Size = new System.Drawing.Size(71, 29);
            this.btnPrinting.Style = Sunny.UI.UIStyle.Custom;
            this.btnPrinting.Symbol = 61487;
            this.btnPrinting.TabIndex = 98;
            this.btnPrinting.Text = "인쇄";
            this.btnPrinting.Click += new System.EventHandler(this.btnPrinting_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnPreview.FillHoverColor = System.Drawing.Color.Gray;
            this.btnPreview.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPreview.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnPreview.IsScaled = false;
            this.btnPreview.Location = new System.Drawing.Point(781, 5);
            this.btnPreview.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.RectColor = System.Drawing.Color.Transparent;
            this.btnPreview.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnPreview.RectPressColor = System.Drawing.Color.Transparent;
            this.btnPreview.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnPreview.Size = new System.Drawing.Size(102, 29);
            this.btnPreview.Style = Sunny.UI.UIStyle.Custom;
            this.btnPreview.Symbol = 62060;
            this.btnPreview.TabIndex = 103;
            this.btnPreview.Text = "미리보기";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 95;
            this.label2.Text = "▶ 재고 관리";
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLine1.IsScaled = false;
            this.uiLine1.LineColor = System.Drawing.Color.LightSlateGray;
            this.uiLine1.LineSize = 2;
            this.uiLine1.Location = new System.Drawing.Point(0, 38);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(1040, 2);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 96;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(16, 185);
            this.uiMarkLabel1.MarkColor = System.Drawing.Color.SlateGray;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiMarkLabel1.TabIndex = 89;
            this.uiMarkLabel1.Text = "재고";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnExportExcel.Location = new System.Drawing.Point(704, 5);
            this.btnExportExcel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.RectColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.RectPressColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.Size = new System.Drawing.Size(71, 29);
            this.btnExportExcel.Style = Sunny.UI.UIStyle.Custom;
            this.btnExportExcel.Symbol = 61714;
            this.btnExportExcel.TabIndex = 90;
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
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tboxStandard, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btncCodeSearch, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tboxMCode, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnmCodeSearch, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tboxWCode, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.btneCodeSearch, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbboxMClass, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(40, 62);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(487, 91);
            this.tableLayoutPanel3.TabIndex = 93;
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
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(0, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "규격";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxStandard
            // 
            this.tboxStandard.ButtonSymbol = 61761;
            this.tboxStandard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxStandard.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxStandard.IsScaled = false;
            this.tboxStandard.Location = new System.Drawing.Point(100, 35);
            this.tboxStandard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxStandard.Maximum = 2147483647D;
            this.tboxStandard.Minimum = -2147483648D;
            this.tboxStandard.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxStandard.Name = "tboxStandard";
            this.tboxStandard.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxStandard.Size = new System.Drawing.Size(88, 20);
            this.tboxStandard.Style = Sunny.UI.UIStyle.Custom;
            this.tboxStandard.TabIndex = 12;
            this.tboxStandard.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btncCodeSearch
            // 
            this.btncCodeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncCodeSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btncCodeSearch.FillHoverColor = System.Drawing.Color.Gray;
            this.btncCodeSearch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncCodeSearch.FillSelectedColor = System.Drawing.Color.Gray;
            this.btncCodeSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btncCodeSearch.IsScaled = false;
            this.btncCodeSearch.Location = new System.Drawing.Point(195, 33);
            this.btncCodeSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btncCodeSearch.Name = "btncCodeSearch";
            this.btncCodeSearch.RectColor = System.Drawing.Color.Transparent;
            this.btncCodeSearch.RectHoverColor = System.Drawing.Color.Transparent;
            this.btncCodeSearch.RectPressColor = System.Drawing.Color.Transparent;
            this.btncCodeSearch.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btncCodeSearch.Size = new System.Drawing.Size(42, 24);
            this.btncCodeSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btncCodeSearch.Symbol = 61442;
            this.btncCodeSearch.TabIndex = 12;
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
            // 
            // cbboxMClass
            // 
            this.cbboxMClass.DataSource = null;
            this.cbboxMClass.FillColor = System.Drawing.Color.White;
            this.cbboxMClass.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbboxMClass.IsScaled = false;
            this.cbboxMClass.Location = new System.Drawing.Point(100, 5);
            this.cbboxMClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbboxMClass.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbboxMClass.Name = "cbboxMClass";
            this.cbboxMClass.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbboxMClass.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.cbboxMClass.Size = new System.Drawing.Size(88, 20);
            this.cbboxMClass.Style = Sunny.UI.UIStyle.Custom;
            this.cbboxMClass.TabIndex = 17;
            this.cbboxMClass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnSearch.Location = new System.Drawing.Point(20, 51);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(965, 117);
            this.pnSearch.TabIndex = 94;
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnShowDetail.FillHoverColor = System.Drawing.Color.Gray;
            this.btnShowDetail.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowDetail.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnShowDetail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnShowDetail.IsScaled = false;
            this.btnShowDetail.Location = new System.Drawing.Point(919, 179);
            this.btnShowDetail.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.RectColor = System.Drawing.Color.Transparent;
            this.btnShowDetail.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnShowDetail.RectPressColor = System.Drawing.Color.Transparent;
            this.btnShowDetail.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnShowDetail.Size = new System.Drawing.Size(103, 29);
            this.btnShowDetail.Style = Sunny.UI.UIStyle.Custom;
            this.btnShowDetail.Symbol = 61442;
            this.btnShowDetail.TabIndex = 104;
            this.btnShowDetail.Text = "상세보기";
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // pdialStock
            // 
            this.pdialStock.UseEXDialog = true;
            // 
            // pdocStock
            // 
            this.pdocStock.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocStock_PrintPage);
            // 
            // ppviewdialStock
            // 
            this.ppviewdialStock.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppviewdialStock.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppviewdialStock.ClientSize = new System.Drawing.Size(400, 300);
            this.ppviewdialStock.Enabled = true;
            this.ppviewdialStock.Icon = ((System.Drawing.Icon)(resources.GetObject("ppviewdialStock.Icon")));
            this.ppviewdialStock.Name = "ppviewdialStock";
            this.ppviewdialStock.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "자재구분";
            this.Column1.Name = "Column1";
            // 
            // colMName
            // 
            this.colMName.HeaderText = "품번";
            this.colMName.Name = "colMName";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "품명";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "수량";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "단위";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "규격";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "창고";
            this.Column7.Name = "Column7";
            // 
            // StockUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowDetail);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtgviewStockList);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.pnSearch);
            this.Name = "StockUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1040, 674);
            this.Load += new System.EventHandler(this.StockUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewStockList)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UISymbolButton btnSearch;
        private System.Windows.Forms.DataGridView dtgviewStockList;
        private Sunny.UI.UISymbolButton btnPrinting;
        private Sunny.UI.UISymbolButton btnPreview;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UISymbolButton btnExportExcel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Sunny.UI.UIComboBox cbboxMClass;
        private Sunny.UI.UISymbolButton btnpOrderCodeSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UITextBox tboxStandard;
        private Sunny.UI.UISymbolButton btncCodeSearch;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UITextBox tboxMCode;
        private Sunny.UI.UISymbolButton btnmCodeSearch;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UITextBox tboxWCode;
        private Sunny.UI.UISymbolButton btneCodeSearch;
        private System.Windows.Forms.Panel pnSearch;
        private Sunny.UI.UISymbolButton btnShowDetail;
        private System.Windows.Forms.PrintDialog pdialStock;
        private System.Drawing.Printing.PrintDocument pdocStock;
        private System.Windows.Forms.PrintPreviewDialog ppviewdialStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
