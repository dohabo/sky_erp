
namespace ERP_TESLA.UI.WarePurchase
{
    partial class PurchaseMgtUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseMgtUI));
            this.btnSumPrice = new Sunny.UI.UISymbolButton();
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.btnPrinting = new Sunny.UI.UISymbolButton();
            this.btnPreview = new Sunny.UI.UISymbolButton();
            this.label2 = new System.Windows.Forms.Label();
            this.uiLine1 = new Sunny.UI.UILine();
            this.btnExportExcel = new Sunny.UI.UISymbolButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tboxPCode = new Sunny.UI.UITextBox();
            this.btnpOrderCodeSearch = new Sunny.UI.UISymbolButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxCCode = new Sunny.UI.UITextBox();
            this.btncCodeSearch = new Sunny.UI.UISymbolButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxMCode = new Sunny.UI.UITextBox();
            this.btnmCodeSearch = new Sunny.UI.UISymbolButton();
            this.label18 = new System.Windows.Forms.Label();
            this.cbboxStatus = new Sunny.UI.UIComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpicpInTo = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpicpInFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tboxSumPrice = new Sunny.UI.UITextBox();
            this.dtgviewInputList = new System.Windows.Forms.DataGridView();
            this.colConfirm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colConfirmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.btnConfirm = new Sunny.UI.UISymbolButton();
            this.btnAllCheck = new Sunny.UI.UISymbolButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChangeConfirmDate = new Sunny.UI.UISymbolButton();
            this.tboxConfirmDate = new Sunny.UI.UITextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pdialInput = new System.Windows.Forms.PrintDialog();
            this.pdocInput = new System.Drawing.Printing.PrintDocument();
            this.ppviewdialInput = new System.Windows.Forms.PrintPreviewDialog();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewInputList)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSumPrice
            // 
            this.btnSumPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnSumPrice.FillHoverColor = System.Drawing.Color.Gray;
            this.btnSumPrice.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSumPrice.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnSumPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSumPrice.IsScaled = false;
            this.btnSumPrice.Location = new System.Drawing.Point(832, 185);
            this.btnSumPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSumPrice.Name = "btnSumPrice";
            this.btnSumPrice.RectColor = System.Drawing.Color.Transparent;
            this.btnSumPrice.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnSumPrice.RectPressColor = System.Drawing.Color.Transparent;
            this.btnSumPrice.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnSumPrice.Size = new System.Drawing.Size(100, 29);
            this.btnSumPrice.Style = Sunny.UI.UIStyle.Custom;
            this.btnSumPrice.Symbol = 61639;
            this.btnSumPrice.TabIndex = 100;
            this.btnSumPrice.Text = "합계계산";
            this.btnSumPrice.Click += new System.EventHandler(this.btnSumPrice_Click);
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
            this.label2.Text = "▶ 매입 관리";
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
            this.tableLayoutPanel3.Controls.Add(this.tboxPCode, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnpOrderCodeSearch, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tboxCCode, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btncCodeSearch, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tboxMCode, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnmCodeSearch, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label18, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbboxStatus, 4, 1);
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
            // tboxPCode
            // 
            this.tboxPCode.ButtonSymbol = 61761;
            this.tboxPCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxPCode.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxPCode.IsScaled = false;
            this.tboxPCode.Location = new System.Drawing.Point(100, 5);
            this.tboxPCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxPCode.Maximum = 2147483647D;
            this.tboxPCode.Minimum = -2147483648D;
            this.tboxPCode.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxPCode.Name = "tboxPCode";
            this.tboxPCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxPCode.Size = new System.Drawing.Size(88, 20);
            this.tboxPCode.Style = Sunny.UI.UIStyle.Custom;
            this.tboxPCode.TabIndex = 13;
            this.tboxPCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label3.Text = "발주번호";
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
            this.label5.Text = "거래처번호";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxCCode
            // 
            this.tboxCCode.ButtonSymbol = 61761;
            this.tboxCCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxCCode.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxCCode.IsScaled = false;
            this.tboxCCode.Location = new System.Drawing.Point(100, 35);
            this.tboxCCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxCCode.Maximum = 2147483647D;
            this.tboxCCode.Minimum = -2147483648D;
            this.tboxCCode.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxCCode.Name = "tboxCCode";
            this.tboxCCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxCCode.Size = new System.Drawing.Size(88, 20);
            this.tboxCCode.Style = Sunny.UI.UIStyle.Custom;
            this.tboxCCode.TabIndex = 12;
            this.tboxCCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(242, 30);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 30);
            this.label18.TabIndex = 6;
            this.label18.Text = "확정여부";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbboxStatus
            // 
            this.cbboxStatus.DataSource = null;
            this.cbboxStatus.FillColor = System.Drawing.Color.White;
            this.cbboxStatus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbboxStatus.IsScaled = false;
            this.cbboxStatus.Location = new System.Drawing.Point(342, 35);
            this.cbboxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbboxStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbboxStatus.Name = "cbboxStatus";
            this.cbboxStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbboxStatus.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.cbboxStatus.Size = new System.Drawing.Size(88, 20);
            this.cbboxStatus.Style = Sunny.UI.UIStyle.Custom;
            this.cbboxStatus.TabIndex = 17;
            this.cbboxStatus.Text = "미확정";
            this.cbboxStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.7691F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.95586F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.319185F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.95586F));
            this.tableLayoutPanel4.Controls.Add(this.label17, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtpicpInTo, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtpicpInFrom, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(530, 11);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(410, 91);
            this.tableLayoutPanel4.TabIndex = 91;
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
            // dtpicpInTo
            // 
            this.dtpicpInTo.Checked = false;
            this.dtpicpInTo.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicpInTo.Location = new System.Drawing.Point(273, 3);
            this.dtpicpInTo.Name = "dtpicpInTo";
            this.dtpicpInTo.Size = new System.Drawing.Size(130, 25);
            this.dtpicpInTo.TabIndex = 14;
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
            this.label16.Text = "입고일자";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpicpInFrom
            // 
            this.dtpicpInFrom.CalendarFont = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicpInFrom.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicpInFrom.Location = new System.Drawing.Point(100, 3);
            this.dtpicpInFrom.Name = "dtpicpInFrom";
            this.dtpicpInFrom.Size = new System.Drawing.Size(123, 25);
            this.dtpicpInFrom.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(835, 619);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "합계 금액";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnSearch.Controls.Add(this.tableLayoutPanel4);
            this.pnSearch.Location = new System.Drawing.Point(20, 51);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(965, 117);
            this.pnSearch.TabIndex = 94;
            // 
            // tboxSumPrice
            // 
            this.tboxSumPrice.ButtonSymbol = 61761;
            this.tboxSumPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxSumPrice.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxSumPrice.IsScaled = false;
            this.tboxSumPrice.Location = new System.Drawing.Point(938, 619);
            this.tboxSumPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxSumPrice.Maximum = 2147483647D;
            this.tboxSumPrice.Minimum = -2147483648D;
            this.tboxSumPrice.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxSumPrice.Name = "tboxSumPrice";
            this.tboxSumPrice.ReadOnly = true;
            this.tboxSumPrice.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxSumPrice.Size = new System.Drawing.Size(84, 20);
            this.tboxSumPrice.Style = Sunny.UI.UIStyle.Custom;
            this.tboxSumPrice.TabIndex = 15;
            this.tboxSumPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tboxSumPrice.TextChanged += new System.EventHandler(this.tboxSumPrice_TextChanged);
            // 
            // dtgviewInputList
            // 
            this.dtgviewInputList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgviewInputList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgviewInputList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgviewInputList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewInputList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgviewInputList.ColumnHeadersHeight = 30;
            this.dtgviewInputList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgviewInputList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConfirm,
            this.colConfirmDate,
            this.colPOrder,
            this.colCCode,
            this.colCName,
            this.colMCode,
            this.colMName,
            this.colInDate,
            this.colAmount,
            this.colUnit,
            this.colPrice,
            this.colSupplyPrice,
            this.colVat,
            this.colSumPrice});
            this.dtgviewInputList.EnableHeadersVisualStyles = false;
            this.dtgviewInputList.GridColor = System.Drawing.Color.DarkGray;
            this.dtgviewInputList.Location = new System.Drawing.Point(20, 217);
            this.dtgviewInputList.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dtgviewInputList.Name = "dtgviewInputList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewInputList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgviewInputList.RowHeadersVisible = false;
            this.dtgviewInputList.RowTemplate.Height = 30;
            this.dtgviewInputList.Size = new System.Drawing.Size(1002, 399);
            this.dtgviewInputList.TabIndex = 108;
            // 
            // colConfirm
            // 
            this.colConfirm.HeaderText = "확정";
            this.colConfirm.Name = "colConfirm";
            this.colConfirm.Width = 60;
            // 
            // colConfirmDate
            // 
            this.colConfirmDate.HeaderText = "확정일자";
            this.colConfirmDate.Name = "colConfirmDate";
            // 
            // colPOrder
            // 
            this.colPOrder.HeaderText = "발주번호";
            this.colPOrder.Name = "colPOrder";
            // 
            // colCCode
            // 
            this.colCCode.HeaderText = "거래처번호";
            this.colCCode.Name = "colCCode";
            this.colCCode.Width = 110;
            // 
            // colCName
            // 
            this.colCName.HeaderText = "거래처명";
            this.colCName.Name = "colCName";
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
            // colInDate
            // 
            this.colInDate.HeaderText = "입고일자";
            this.colInDate.Name = "colInDate";
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "수량";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 80;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "단위";
            this.colUnit.Name = "colUnit";
            this.colUnit.Width = 80;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "단가";
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 80;
            // 
            // colSupplyPrice
            // 
            this.colSupplyPrice.HeaderText = "공급가";
            this.colSupplyPrice.Name = "colSupplyPrice";
            this.colSupplyPrice.Width = 90;
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
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(16, 191);
            this.uiMarkLabel1.MarkColor = System.Drawing.Color.SlateGray;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiMarkLabel1.TabIndex = 107;
            this.uiMarkLabel1.Text = "입고 내역";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnConfirm.FillHoverColor = System.Drawing.Color.Gray;
            this.btnConfirm.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirm.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnConfirm.IsScaled = false;
            this.btnConfirm.Location = new System.Drawing.Point(938, 185);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RectColor = System.Drawing.Color.Transparent;
            this.btnConfirm.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnConfirm.RectPressColor = System.Drawing.Color.Transparent;
            this.btnConfirm.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Size = new System.Drawing.Size(84, 29);
            this.btnConfirm.Style = Sunny.UI.UIStyle.Custom;
            this.btnConfirm.Symbol = 61639;
            this.btnConfirm.TabIndex = 112;
            this.btnConfirm.Text = "확정";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnAllCheck
            // 
            this.btnAllCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnAllCheck.FillHoverColor = System.Drawing.Color.Gray;
            this.btnAllCheck.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllCheck.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnAllCheck.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnAllCheck.IsScaled = false;
            this.btnAllCheck.Location = new System.Drawing.Point(726, 185);
            this.btnAllCheck.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAllCheck.Name = "btnAllCheck";
            this.btnAllCheck.RectColor = System.Drawing.Color.Transparent;
            this.btnAllCheck.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnAllCheck.RectPressColor = System.Drawing.Color.Transparent;
            this.btnAllCheck.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnAllCheck.Size = new System.Drawing.Size(100, 29);
            this.btnAllCheck.Style = Sunny.UI.UIStyle.Custom;
            this.btnAllCheck.TabIndex = 113;
            this.btnAllCheck.Text = "일괄체크";
            this.btnAllCheck.Click += new System.EventHandler(this.btnAllCheck_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel2.Controls.Add(this.btnChangeConfirmDate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tboxConfirmDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 622);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 33);
            this.tableLayoutPanel2.TabIndex = 114;
            // 
            // btnChangeConfirmDate
            // 
            this.btnChangeConfirmDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeConfirmDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnChangeConfirmDate.FillHoverColor = System.Drawing.Color.Gray;
            this.btnChangeConfirmDate.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangeConfirmDate.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnChangeConfirmDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnChangeConfirmDate.IsScaled = false;
            this.btnChangeConfirmDate.Location = new System.Drawing.Point(194, 3);
            this.btnChangeConfirmDate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChangeConfirmDate.Name = "btnChangeConfirmDate";
            this.btnChangeConfirmDate.RectColor = System.Drawing.Color.Transparent;
            this.btnChangeConfirmDate.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnChangeConfirmDate.RectPressColor = System.Drawing.Color.Transparent;
            this.btnChangeConfirmDate.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnChangeConfirmDate.Size = new System.Drawing.Size(105, 27);
            this.btnChangeConfirmDate.Style = Sunny.UI.UIStyle.Custom;
            this.btnChangeConfirmDate.Symbol = 61473;
            this.btnChangeConfirmDate.TabIndex = 87;
            this.btnChangeConfirmDate.Text = "일괄변경";
            this.btnChangeConfirmDate.Click += new System.EventHandler(this.btnChangeConfirmDate_Click);
            // 
            // tboxConfirmDate
            // 
            this.tboxConfirmDate.ButtonSymbol = 61761;
            this.tboxConfirmDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxConfirmDate.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxConfirmDate.IsScaled = false;
            this.tboxConfirmDate.Location = new System.Drawing.Point(86, 5);
            this.tboxConfirmDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxConfirmDate.Maximum = 2147483647D;
            this.tboxConfirmDate.Minimum = -2147483648D;
            this.tboxConfirmDate.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxConfirmDate.Name = "tboxConfirmDate";
            this.tboxConfirmDate.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxConfirmDate.Size = new System.Drawing.Size(101, 23);
            this.tboxConfirmDate.Style = Sunny.UI.UIStyle.Custom;
            this.tboxConfirmDate.TabIndex = 12;
            this.tboxConfirmDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "확정일자";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pdialInput
            // 
            this.pdialInput.UseEXDialog = true;
            // 
            // pdocInput
            // 
            this.pdocInput.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocInput_PrintPage);
            // 
            // ppviewdialInput
            // 
            this.ppviewdialInput.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppviewdialInput.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppviewdialInput.ClientSize = new System.Drawing.Size(400, 300);
            this.ppviewdialInput.Enabled = true;
            this.ppviewdialInput.Icon = ((System.Drawing.Icon)(resources.GetObject("ppviewdialInput.Icon")));
            this.ppviewdialInput.Name = "ppviewdialInput";
            this.ppviewdialInput.Visible = false;
            // 
            // PurchaseMgtUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnAllCheck);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dtgviewInputList);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.tboxSumPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSumPrice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.pnSearch);
            this.Name = "PurchaseMgtUI";
            this.Size = new System.Drawing.Size(1040, 674);
            this.Load += new System.EventHandler(this.PurchaseMgtUI_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewInputList)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UISymbolButton btnSumPrice;
        private Sunny.UI.UISymbolButton btnSearch;
        private Sunny.UI.UISymbolButton btnPrinting;
        private Sunny.UI.UISymbolButton btnPreview;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolButton btnExportExcel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Sunny.UI.UIComboBox cbboxStatus;
        private Sunny.UI.UISymbolButton btnpOrderCodeSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UITextBox tboxCCode;
        private Sunny.UI.UISymbolButton btncCodeSearch;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UITextBox tboxMCode;
        private Sunny.UI.UISymbolButton btnmCodeSearch;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpicpInFrom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpicpInTo;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox tboxSumPrice;
        private Sunny.UI.UITextBox tboxPCode;
        private System.Windows.Forms.DataGridView dtgviewInputList;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UISymbolButton btnConfirm;
        private Sunny.UI.UISymbolButton btnAllCheck;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSumPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UISymbolButton btnChangeConfirmDate;
        private Sunny.UI.UITextBox tboxConfirmDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PrintDialog pdialInput;
        private System.Drawing.Printing.PrintDocument pdocInput;
        private System.Windows.Forms.PrintPreviewDialog ppviewdialInput;
    }
}
