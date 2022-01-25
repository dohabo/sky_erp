
namespace ERP_TESLA.UI.Sales
{
    partial class SalesMgtUI
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesMgtUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnpOrder = new Sunny.UI.UISymbolButton();
            this.dtpicpInFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.tboxpOrder = new Sunny.UI.UITextBox();
            this.btnProdCode = new Sunny.UI.UISymbolButton();
            this.lblpOrder = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.pnSch = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpicpInTo = new System.Windows.Forms.DateTimePicker();
            this.uiLine1 = new Sunny.UI.UILine();
            this.btnSalesPreview = new Sunny.UI.UISymbolButton();
            this.btnSalesPrinting = new Sunny.UI.UISymbolButton();
            this.btnSalesSch = new Sunny.UI.UISymbolButton();
            this.btnExportExcel = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextBox6 = new Sunny.UI.UITextBox();
            this.uiTextBox7 = new Sunny.UI.UITextBox();
            this.uiTextBox8 = new Sunny.UI.UITextBox();
            this.pdocInput = new System.Drawing.Printing.PrintDocument();
            this.pdialInput = new System.Windows.Forms.PrintDialog();
            this.ppviewdialInput = new System.Windows.Forms.PrintPreviewDialog();
            this.dtgviewSales = new System.Windows.Forms.DataGridView();
            this.ColumnsalesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.uiTextBox5 = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.tboxpSales = new Sunny.UI.UITextBox();
            this.lblpCode = new Sunny.UI.UITextBox();
            this.lblSalesNum = new Sunny.UI.UITextBox();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel3 = new Sunny.UI.UIMarkLabel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.uiTextBox9 = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiTextBox10 = new Sunny.UI.UITextBox();
            this.uiTextBox11 = new Sunny.UI.UITextBox();
            this.uiTextBox12 = new Sunny.UI.UITextBox();
            this.uiMarkLabel4 = new Sunny.UI.UIMarkLabel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            this.pnSch.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewSales)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69725F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.98165F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.073395F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.53211F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.09174F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            tableLayoutPanel1.Controls.Add(this.btnpOrder, 2, 0);
            tableLayoutPanel1.Controls.Add(this.dtpicpInFrom, 4, 0);
            tableLayoutPanel1.Controls.Add(this.lblDate, 3, 0);
            tableLayoutPanel1.Controls.Add(this.tboxpOrder, 1, 0);
            tableLayoutPanel1.Controls.Add(this.btnProdCode, 5, 0);
            tableLayoutPanel1.Controls.Add(this.lblpOrder, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(11, 10);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Size = new System.Drawing.Size(548, 41);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnpOrder
            // 
            this.btnpOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnpOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnpOrder.ForeColor = System.Drawing.Color.DimGray;
            this.btnpOrder.IsScaled = false;
            this.btnpOrder.Location = new System.Drawing.Point(197, 6);
            this.btnpOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnpOrder.Name = "btnpOrder";
            this.btnpOrder.RectColor = System.Drawing.Color.Transparent;
            this.btnpOrder.Size = new System.Drawing.Size(27, 27);
            this.btnpOrder.Style = Sunny.UI.UIStyle.Custom;
            this.btnpOrder.Symbol = 61442;
            this.btnpOrder.TabIndex = 20;
            this.btnpOrder.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // dtpicpInFrom
            // 
            this.dtpicpInFrom.CalendarFont = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicpInFrom.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicpInFrom.Location = new System.Drawing.Point(345, 6);
            this.dtpicpInFrom.Name = "dtpicpInFrom";
            this.dtpicpInFrom.Size = new System.Drawing.Size(129, 25);
            this.dtpicpInFrom.TabIndex = 14;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.Location = new System.Drawing.Point(240, 3);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 33);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "매출 기준기간";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxpOrder
            // 
            this.tboxpOrder.ButtonSymbol = 61761;
            this.tboxpOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxpOrder.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxpOrder.IsScaled = false;
            this.tboxpOrder.Location = new System.Drawing.Point(99, 8);
            this.tboxpOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxpOrder.Maximum = 2147483647D;
            this.tboxpOrder.Minimum = -2147483648D;
            this.tboxpOrder.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxpOrder.Name = "tboxpOrder";
            this.tboxpOrder.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxpOrder.Size = new System.Drawing.Size(84, 23);
            this.tboxpOrder.Style = Sunny.UI.UIStyle.Custom;
            this.tboxpOrder.TabIndex = 19;
            this.tboxpOrder.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnProdCode
            // 
            this.btnProdCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProdCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnProdCode.ForeColor = System.Drawing.Color.DimGray;
            this.btnProdCode.IsScaled = false;
            this.btnProdCode.Location = new System.Drawing.Point(508, 6);
            this.btnProdCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnProdCode.Name = "btnProdCode";
            this.btnProdCode.RectColor = System.Drawing.Color.Transparent;
            this.btnProdCode.Size = new System.Drawing.Size(30, 27);
            this.btnProdCode.Style = Sunny.UI.UIStyle.Custom;
            this.btnProdCode.Symbol = 61544;
            this.btnProdCode.TabIndex = 12;
            // 
            // lblpOrder
            // 
            this.lblpOrder.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblpOrder.Location = new System.Drawing.Point(3, 3);
            this.lblpOrder.Margin = new System.Windows.Forms.Padding(0);
            this.lblpOrder.Name = "lblpOrder";
            this.lblpOrder.Size = new System.Drawing.Size(89, 33);
            this.lblpOrder.TabIndex = 14;
            this.lblpOrder.Text = "제품 품번";
            this.lblpOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.lblSales.Location = new System.Drawing.Point(5, 5);
            this.lblSales.Margin = new System.Windows.Forms.Padding(5);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(102, 21);
            this.lblSales.TabIndex = 48;
            this.lblSales.Text = "▶ 매출 관리";
            // 
            // pnSch
            // 
            this.pnSch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnSch.Controls.Add(this.tableLayoutPanel2);
            this.pnSch.Controls.Add(tableLayoutPanel1);
            this.pnSch.Location = new System.Drawing.Point(0, 45);
            this.pnSch.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnSch.Name = "pnSch";
            this.pnSch.Size = new System.Drawing.Size(1040, 68);
            this.pnSch.TabIndex = 49;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.Controls.Add(this.dtpicpInTo, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(556, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(191, 41);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // dtpicpInTo
            // 
            this.dtpicpInTo.CalendarFont = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicpInTo.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpicpInTo.Location = new System.Drawing.Point(6, 6);
            this.dtpicpInTo.Name = "dtpicpInTo";
            this.dtpicpInTo.Size = new System.Drawing.Size(126, 25);
            this.dtpicpInTo.TabIndex = 15;
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
            this.uiLine1.TabIndex = 60;
            // 
            // btnSalesPreview
            // 
            this.btnSalesPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesPreview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnSalesPreview.FillHoverColor = System.Drawing.Color.Gray;
            this.btnSalesPreview.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalesPreview.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnSalesPreview.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSalesPreview.IsScaled = false;
            this.btnSalesPreview.Location = new System.Drawing.Point(847, 5);
            this.btnSalesPreview.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSalesPreview.Name = "btnSalesPreview";
            this.btnSalesPreview.RectColor = System.Drawing.Color.Transparent;
            this.btnSalesPreview.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnSalesPreview.RectPressColor = System.Drawing.Color.Transparent;
            this.btnSalesPreview.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnSalesPreview.Size = new System.Drawing.Size(102, 29);
            this.btnSalesPreview.Style = Sunny.UI.UIStyle.Custom;
            this.btnSalesPreview.Symbol = 62060;
            this.btnSalesPreview.TabIndex = 76;
            this.btnSalesPreview.Text = "미리보기";
            this.btnSalesPreview.Click += new System.EventHandler(this.btnSalesPreview_Click);
            // 
            // btnSalesPrinting
            // 
            this.btnSalesPrinting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesPrinting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnSalesPrinting.FillHoverColor = System.Drawing.Color.Gray;
            this.btnSalesPrinting.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalesPrinting.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnSalesPrinting.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSalesPrinting.IsScaled = false;
            this.btnSalesPrinting.Location = new System.Drawing.Point(956, 5);
            this.btnSalesPrinting.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSalesPrinting.Name = "btnSalesPrinting";
            this.btnSalesPrinting.RectColor = System.Drawing.Color.Transparent;
            this.btnSalesPrinting.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnSalesPrinting.RectPressColor = System.Drawing.Color.Transparent;
            this.btnSalesPrinting.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnSalesPrinting.Size = new System.Drawing.Size(71, 29);
            this.btnSalesPrinting.Style = Sunny.UI.UIStyle.Custom;
            this.btnSalesPrinting.Symbol = 61487;
            this.btnSalesPrinting.TabIndex = 74;
            this.btnSalesPrinting.Text = "인쇄";
            this.btnSalesPrinting.Click += new System.EventHandler(this.btnSalesPrinting_Click);
            // 
            // btnSalesSch
            // 
            this.btnSalesSch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesSch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnSalesSch.FillHoverColor = System.Drawing.Color.Gray;
            this.btnSalesSch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalesSch.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnSalesSch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSalesSch.IsScaled = false;
            this.btnSalesSch.Location = new System.Drawing.Point(691, 5);
            this.btnSalesSch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSalesSch.Name = "btnSalesSch";
            this.btnSalesSch.RectColor = System.Drawing.Color.Transparent;
            this.btnSalesSch.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnSalesSch.RectPressColor = System.Drawing.Color.Transparent;
            this.btnSalesSch.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnSalesSch.Size = new System.Drawing.Size(71, 29);
            this.btnSalesSch.Style = Sunny.UI.UIStyle.Custom;
            this.btnSalesSch.Symbol = 61442;
            this.btnSalesSch.TabIndex = 75;
            this.btnSalesSch.Text = "조회";
            this.btnSalesSch.Click += new System.EventHandler(this.btnSalesSch_Click);
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
            this.btnExportExcel.Location = new System.Drawing.Point(769, 5);
            this.btnExportExcel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.RectColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.RectPressColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.Size = new System.Drawing.Size(71, 29);
            this.btnExportExcel.Style = Sunny.UI.UIStyle.Custom;
            this.btnExportExcel.Symbol = 61714;
            this.btnExportExcel.TabIndex = 73;
            this.btnExportExcel.Text = "엑셀";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(8, 368);
            this.uiMarkLabel1.MarkColor = System.Drawing.Color.SlateGray;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(168, 23);
            this.uiMarkLabel1.TabIndex = 78;
            this.uiMarkLabel1.Text = "제품별 매출 개요";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Controls.Add(this.uiLabel3, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiLabel2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiLabel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiTextBox6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiTextBox7, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.uiTextBox8, 5, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 554);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(922, 47);
            this.tableLayoutPanel3.TabIndex = 79;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(462, 3);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 34);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 85;
            this.uiLabel3.Text = "총 부가세";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(234, 3);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 34);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 84;
            this.uiLabel2.Text = "총 매출금액";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(6, 3);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 34);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "총 건수";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTextBox6
            // 
            this.uiTextBox6.ButtonSymbol = 61761;
            this.uiTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox6.IsScaled = false;
            this.uiTextBox6.Location = new System.Drawing.Point(121, 8);
            this.uiTextBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox6.Maximum = 2147483647D;
            this.uiTextBox6.Minimum = -2147483648D;
            this.uiTextBox6.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox6.Name = "uiTextBox6";
            this.uiTextBox6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.uiTextBox6.Size = new System.Drawing.Size(103, 29);
            this.uiTextBox6.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox6.TabIndex = 80;
            this.uiTextBox6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox7
            // 
            this.uiTextBox7.ButtonSymbol = 61761;
            this.uiTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox7.IsScaled = false;
            this.uiTextBox7.Location = new System.Drawing.Point(349, 8);
            this.uiTextBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox7.Maximum = 2147483647D;
            this.uiTextBox7.Minimum = -2147483648D;
            this.uiTextBox7.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox7.Name = "uiTextBox7";
            this.uiTextBox7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.uiTextBox7.Size = new System.Drawing.Size(103, 29);
            this.uiTextBox7.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox7.TabIndex = 81;
            this.uiTextBox7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox8
            // 
            this.uiTextBox8.ButtonSymbol = 61761;
            this.uiTextBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox8.IsScaled = false;
            this.uiTextBox8.Location = new System.Drawing.Point(577, 8);
            this.uiTextBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox8.Maximum = 2147483647D;
            this.uiTextBox8.Minimum = -2147483648D;
            this.uiTextBox8.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox8.Name = "uiTextBox8";
            this.uiTextBox8.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.uiTextBox8.Size = new System.Drawing.Size(103, 29);
            this.uiTextBox8.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox8.TabIndex = 82;
            this.uiTextBox8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pdocInput
            // 
            this.pdocInput.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocInput_PrintPage);
            // 
            // pdialInput
            // 
            this.pdialInput.UseEXDialog = true;
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
            // dtgviewSales
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgviewSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgviewSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgviewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgviewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnsalesDate,
            this.ColumnConCode});
            this.dtgviewSales.GridColor = System.Drawing.Color.DarkGray;
            this.dtgviewSales.Location = new System.Drawing.Point(13, 151);
            this.dtgviewSales.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dtgviewSales.Name = "dtgviewSales";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgviewSales.RowHeadersVisible = false;
            this.dtgviewSales.RowTemplate.Height = 23;
            this.dtgviewSales.Size = new System.Drawing.Size(995, 203);
            this.dtgviewSales.TabIndex = 80;
            // 
            // ColumnsalesDate
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnsalesDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnsalesDate.HeaderText = "날짜";
            this.ColumnsalesDate.Name = "ColumnsalesDate";
            // 
            // ColumnConCode
            // 
            this.ColumnConCode.HeaderText = "주문번호";
            this.ColumnConCode.Name = "ColumnConCode";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.Controls.Add(this.uiTextBox5, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.uiLabel7, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.uiLabel4, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.uiLabel5, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.uiLabel6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tboxpSales, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblpCode, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblSalesNum, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(9, 394);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(922, 47);
            this.tableLayoutPanel4.TabIndex = 81;
            // 
            // uiTextBox5
            // 
            this.uiTextBox5.ButtonSymbol = 61761;
            this.uiTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox5.IsScaled = false;
            this.uiTextBox5.Location = new System.Drawing.Point(805, 8);
            this.uiTextBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox5.Maximum = 2147483647D;
            this.uiTextBox5.Minimum = -2147483648D;
            this.uiTextBox5.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox5.Name = "uiTextBox5";
            this.uiTextBox5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.uiTextBox5.Size = new System.Drawing.Size(103, 29);
            this.uiTextBox5.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox5.TabIndex = 87;
            this.uiTextBox5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(690, 3);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(100, 34);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 86;
            this.uiLabel7.Text = "총 부가세";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(462, 3);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 34);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 85;
            this.uiLabel4.Text = "총 매출금액";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(234, 3);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 34);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 84;
            this.uiLabel5.Text = "총 매출건수";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(6, 3);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 34);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 3;
            this.uiLabel6.Text = "제품 품번";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxpSales
            // 
            this.tboxpSales.ButtonSymbol = 61761;
            this.tboxpSales.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxpSales.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxpSales.IsScaled = false;
            this.tboxpSales.Location = new System.Drawing.Point(577, 8);
            this.tboxpSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxpSales.Maximum = 2147483647D;
            this.tboxpSales.Minimum = -2147483648D;
            this.tboxpSales.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxpSales.Name = "tboxpSales";
            this.tboxpSales.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxpSales.Size = new System.Drawing.Size(103, 29);
            this.tboxpSales.Style = Sunny.UI.UIStyle.Custom;
            this.tboxpSales.TabIndex = 82;
            this.tboxpSales.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblpCode
            // 
            this.lblpCode.ButtonSymbol = 61761;
            this.lblpCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblpCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lblpCode.IsScaled = false;
            this.lblpCode.Location = new System.Drawing.Point(121, 8);
            this.lblpCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblpCode.Maximum = 2147483647D;
            this.lblpCode.Minimum = -2147483648D;
            this.lblpCode.MinimumSize = new System.Drawing.Size(1, 16);
            this.lblpCode.Name = "lblpCode";
            this.lblpCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.lblpCode.Size = new System.Drawing.Size(103, 29);
            this.lblpCode.Style = Sunny.UI.UIStyle.Custom;
            this.lblpCode.TabIndex = 80;
            this.lblpCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesNum
            // 
            this.lblSalesNum.ButtonSymbol = 61761;
            this.lblSalesNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSalesNum.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lblSalesNum.IsScaled = false;
            this.lblSalesNum.Location = new System.Drawing.Point(349, 8);
            this.lblSalesNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblSalesNum.Maximum = 2147483647D;
            this.lblSalesNum.Minimum = -2147483648D;
            this.lblSalesNum.MinimumSize = new System.Drawing.Size(1, 16);
            this.lblSalesNum.Name = "lblSalesNum";
            this.lblSalesNum.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.lblSalesNum.Size = new System.Drawing.Size(103, 29);
            this.lblSalesNum.Style = Sunny.UI.UIStyle.Custom;
            this.lblSalesNum.TabIndex = 81;
            this.lblSalesNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiMarkLabel2.Location = new System.Drawing.Point(9, 118);
            this.uiMarkLabel2.MarkColor = System.Drawing.Color.SlateGray;
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(433, 23);
            this.uiMarkLabel2.TabIndex = 82;
            this.uiMarkLabel2.Text = "매출 내역";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiMarkLabel3.Location = new System.Drawing.Point(6, 525);
            this.uiMarkLabel3.MarkColor = System.Drawing.Color.SlateGray;
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel3.Size = new System.Drawing.Size(168, 23);
            this.uiMarkLabel3.TabIndex = 83;
            this.uiMarkLabel3.Text = "총 매출 개요";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel5.ColumnCount = 8;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.Controls.Add(this.uiTextBox9, 7, 0);
            this.tableLayoutPanel5.Controls.Add(this.uiLabel9, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.uiLabel10, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.uiLabel11, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.uiLabel12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.uiTextBox10, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.uiTextBox11, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.uiTextBox12, 3, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(7, 470);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(922, 47);
            this.tableLayoutPanel5.TabIndex = 85;
            // 
            // uiTextBox9
            // 
            this.uiTextBox9.ButtonSymbol = 61761;
            this.uiTextBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox9.IsScaled = false;
            this.uiTextBox9.Location = new System.Drawing.Point(805, 8);
            this.uiTextBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox9.Maximum = 2147483647D;
            this.uiTextBox9.Minimum = -2147483648D;
            this.uiTextBox9.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox9.Name = "uiTextBox9";
            this.uiTextBox9.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.uiTextBox9.Size = new System.Drawing.Size(103, 29);
            this.uiTextBox9.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox9.TabIndex = 87;
            this.uiTextBox9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.Location = new System.Drawing.Point(690, 3);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(100, 34);
            this.uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel9.TabIndex = 86;
            this.uiLabel9.Text = "총 부가세";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel10.Location = new System.Drawing.Point(462, 3);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(100, 34);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.TabIndex = 85;
            this.uiLabel10.Text = "총 매출금액";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel11.Location = new System.Drawing.Point(234, 3);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(100, 34);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.TabIndex = 84;
            this.uiLabel11.Text = "총 매출건수";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel12.Location = new System.Drawing.Point(6, 3);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(105, 34);
            this.uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel12.TabIndex = 3;
            this.uiLabel12.Text = "거래처 번호";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTextBox10
            // 
            this.uiTextBox10.ButtonSymbol = 61761;
            this.uiTextBox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox10.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox10.IsScaled = false;
            this.uiTextBox10.Location = new System.Drawing.Point(577, 8);
            this.uiTextBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox10.Maximum = 2147483647D;
            this.uiTextBox10.Minimum = -2147483648D;
            this.uiTextBox10.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox10.Name = "uiTextBox10";
            this.uiTextBox10.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.uiTextBox10.Size = new System.Drawing.Size(103, 29);
            this.uiTextBox10.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox10.TabIndex = 82;
            this.uiTextBox10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox11
            // 
            this.uiTextBox11.ButtonSymbol = 61761;
            this.uiTextBox11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox11.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox11.IsScaled = false;
            this.uiTextBox11.Location = new System.Drawing.Point(121, 8);
            this.uiTextBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox11.Maximum = 2147483647D;
            this.uiTextBox11.Minimum = -2147483648D;
            this.uiTextBox11.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox11.Name = "uiTextBox11";
            this.uiTextBox11.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.uiTextBox11.Size = new System.Drawing.Size(103, 29);
            this.uiTextBox11.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox11.TabIndex = 80;
            this.uiTextBox11.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox12
            // 
            this.uiTextBox12.ButtonSymbol = 61761;
            this.uiTextBox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox12.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox12.IsScaled = false;
            this.uiTextBox12.Location = new System.Drawing.Point(349, 8);
            this.uiTextBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox12.Maximum = 2147483647D;
            this.uiTextBox12.Minimum = -2147483648D;
            this.uiTextBox12.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox12.Name = "uiTextBox12";
            this.uiTextBox12.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.uiTextBox12.Size = new System.Drawing.Size(103, 29);
            this.uiTextBox12.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox12.TabIndex = 81;
            this.uiTextBox12.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel4
            // 
            this.uiMarkLabel4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiMarkLabel4.Location = new System.Drawing.Point(6, 444);
            this.uiMarkLabel4.MarkColor = System.Drawing.Color.SlateGray;
            this.uiMarkLabel4.Name = "uiMarkLabel4";
            this.uiMarkLabel4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel4.Size = new System.Drawing.Size(168, 23);
            this.uiMarkLabel4.TabIndex = 84;
            this.uiMarkLabel4.Text = "거래처별 매출 개요";
            this.uiMarkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SalesMgtUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.uiMarkLabel4);
            this.Controls.Add(this.uiMarkLabel3);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.dtgviewSales);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.btnSalesPreview);
            this.Controls.Add(this.btnSalesPrinting);
            this.Controls.Add(this.btnSalesSch);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.pnSch);
            this.Controls.Add(this.lblSales);
            this.Name = "SalesMgtUI";
            this.Size = new System.Drawing.Size(1040, 674);
            this.Load += new System.EventHandler(this.SalesMgtUI_Load);
            tableLayoutPanel1.ResumeLayout(false);
            this.pnSch.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewSales)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Panel pnSch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UISymbolButton btnProdCode;
        private System.Windows.Forms.Label lblpOrder;
        private Sunny.UI.UITextBox tboxpOrder;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolButton btnSalesPreview;
        private Sunny.UI.UISymbolButton btnSalesPrinting;
        private Sunny.UI.UISymbolButton btnSalesSch;
        private Sunny.UI.UISymbolButton btnExportExcel;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Sunny.UI.UITextBox uiTextBox6;
        private System.Windows.Forms.DateTimePicker dtpicpInFrom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpicpInTo;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox8;
        private Sunny.UI.UITextBox uiTextBox7;
        private System.Drawing.Printing.PrintDocument pdocInput;
        private System.Windows.Forms.PrintDialog pdialInput;
        private System.Windows.Forms.PrintPreviewDialog ppviewdialInput;
        private Sunny.UI.UISymbolButton btnpOrder;
        private System.Windows.Forms.DataGridView dtgviewSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnsalesDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Sunny.UI.UITextBox uiTextBox5;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox tboxpSales;
        private Sunny.UI.UITextBox lblpCode;
        private Sunny.UI.UITextBox lblSalesNum;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UIMarkLabel uiMarkLabel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Sunny.UI.UITextBox uiTextBox9;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UITextBox uiTextBox10;
        private Sunny.UI.UITextBox uiTextBox11;
        private Sunny.UI.UITextBox uiTextBox12;
        private Sunny.UI.UIMarkLabel uiMarkLabel4;
    }
}
