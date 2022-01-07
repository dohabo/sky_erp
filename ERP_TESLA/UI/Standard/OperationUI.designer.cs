
namespace ERP_TESLA.UI.Standard
{
    partial class OperationUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiLine1 = new Sunny.UI.UILine();
            this.lblConUISub = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tboxoprName = new Sunny.UI.UITextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tboxoprCode = new Sunny.UI.UITextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tboxoprDescription = new Sunny.UI.UITextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnOperationUpdate = new Sunny.UI.UISymbolButton();
            this.btnOperationAdd = new Sunny.UI.UISymbolButton();
            this.btnOperationDelete = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel3 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.dtgviewOpeartionList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxoperCodeSearch = new Sunny.UI.UITextBox();
            this.btnoperCodeSearch = new Sunny.UI.UISymbolButton();
            this.btnClear = new Sunny.UI.UISymbolButton();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewOpeartionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.uiLine1.TabIndex = 77;
            // 
            // lblConUISub
            // 
            this.lblConUISub.AutoSize = true;
            this.lblConUISub.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblConUISub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.lblConUISub.Location = new System.Drawing.Point(5, 6);
            this.lblConUISub.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblConUISub.Name = "lblConUISub";
            this.lblConUISub.Size = new System.Drawing.Size(140, 21);
            this.lblConUISub.TabIndex = 76;
            this.lblConUISub.Text = "▶ 공정 정보 관리";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(20, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 472);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.uiMarkLabel2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(15, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 450);
            this.panel1.TabIndex = 72;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.btnOperationUpdate);
            this.panel2.Controls.Add(this.btnOperationAdd);
            this.panel2.Controls.Add(this.btnOperationDelete);
            this.panel2.Controls.Add(this.uiMarkLabel3);
            this.panel2.Controls.Add(this.uiMarkLabel1);
            this.panel2.Controls.Add(this.dtgviewOpeartionList);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 450);
            this.panel2.TabIndex = 82;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel1.Controls.Add(this.tboxoprName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboxoprCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tboxoprDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(488, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.35132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.35132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.29736F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 384);
            this.tableLayoutPanel1.TabIndex = 95;
            // 
            // tboxoprName
            // 
            this.tboxoprName.ButtonSymbol = 61761;
            this.tboxoprName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxoprName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxoprName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxoprName.IsScaled = false;
            this.tboxoprName.Location = new System.Drawing.Point(215, 64);
            this.tboxoprName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxoprName.Maximum = 2147483647D;
            this.tboxoprName.Minimum = -2147483648D;
            this.tboxoprName.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxoprName.Name = "tboxoprName";
            this.tboxoprName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxoprName.Size = new System.Drawing.Size(255, 43);
            this.tboxoprName.Style = Sunny.UI.UIStyle.Custom;
            this.tboxoprName.TabIndex = 97;
            this.tboxoprName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(3, 115);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 266);
            this.label12.TabIndex = 94;
            this.label12.Text = "설명";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxoprCode
            // 
            this.tboxoprCode.ButtonSymbol = 61761;
            this.tboxoprCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxoprCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxoprCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxoprCode.IsScaled = false;
            this.tboxoprCode.Location = new System.Drawing.Point(215, 8);
            this.tboxoprCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxoprCode.Maximum = 2147483647D;
            this.tboxoprCode.Minimum = -2147483648D;
            this.tboxoprCode.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxoprCode.Name = "tboxoprCode";
            this.tboxoprCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxoprCode.Size = new System.Drawing.Size(255, 43);
            this.tboxoprCode.Style = Sunny.UI.UIStyle.Custom;
            this.tboxoprCode.TabIndex = 89;
            this.tboxoprCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(3, 59);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 53);
            this.label14.TabIndex = 93;
            this.label14.Text = "공정명";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxoprDescription
            // 
            this.tboxoprDescription.ButtonSymbol = 61761;
            this.tboxoprDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxoprDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxoprDescription.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxoprDescription.IsScaled = false;
            this.tboxoprDescription.Location = new System.Drawing.Point(215, 120);
            this.tboxoprDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxoprDescription.Maximum = 2147483647D;
            this.tboxoprDescription.Minimum = -2147483648D;
            this.tboxoprDescription.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxoprDescription.Multiline = true;
            this.tboxoprDescription.Name = "tboxoprDescription";
            this.tboxoprDescription.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxoprDescription.Size = new System.Drawing.Size(255, 256);
            this.tboxoprDescription.Style = Sunny.UI.UIStyle.Custom;
            this.tboxoprDescription.TabIndex = 104;
            this.tboxoprDescription.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 53);
            this.label13.TabIndex = 79;
            this.label13.Text = "공정번호";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOperationUpdate
            // 
            this.btnOperationUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperationUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnOperationUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnOperationUpdate.IsScaled = false;
            this.btnOperationUpdate.Location = new System.Drawing.Point(791, 3);
            this.btnOperationUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOperationUpdate.Name = "btnOperationUpdate";
            this.btnOperationUpdate.RectColor = System.Drawing.Color.Transparent;
            this.btnOperationUpdate.Size = new System.Drawing.Size(84, 35);
            this.btnOperationUpdate.Style = Sunny.UI.UIStyle.Custom;
            this.btnOperationUpdate.Symbol = 61473;
            this.btnOperationUpdate.TabIndex = 93;
            this.btnOperationUpdate.Text = "수정";
            this.btnOperationUpdate.Click += new System.EventHandler(this.btnOperationUpdate_Click);
            // 
            // btnOperationAdd
            // 
            this.btnOperationAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperationAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnOperationAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnOperationAdd.IsScaled = false;
            this.btnOperationAdd.Location = new System.Drawing.Point(881, 3);
            this.btnOperationAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOperationAdd.Name = "btnOperationAdd";
            this.btnOperationAdd.RectColor = System.Drawing.Color.Transparent;
            this.btnOperationAdd.Size = new System.Drawing.Size(84, 35);
            this.btnOperationAdd.Style = Sunny.UI.UIStyle.Custom;
            this.btnOperationAdd.Symbol = 61543;
            this.btnOperationAdd.TabIndex = 94;
            this.btnOperationAdd.Text = "등록";
            this.btnOperationAdd.Click += new System.EventHandler(this.btnOperationAdd_Click);
            // 
            // btnOperationDelete
            // 
            this.btnOperationDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperationDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnOperationDelete.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnOperationDelete.IsScaled = false;
            this.btnOperationDelete.Location = new System.Drawing.Point(701, 3);
            this.btnOperationDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOperationDelete.Name = "btnOperationDelete";
            this.btnOperationDelete.RectColor = System.Drawing.Color.Transparent;
            this.btnOperationDelete.Size = new System.Drawing.Size(84, 35);
            this.btnOperationDelete.Style = Sunny.UI.UIStyle.Custom;
            this.btnOperationDelete.Symbol = 61544;
            this.btnOperationDelete.TabIndex = 94;
            this.btnOperationDelete.Text = "삭제";
            this.btnOperationDelete.Click += new System.EventHandler(this.btnOperationDelete_Click);
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiMarkLabel3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiMarkLabel3.Location = new System.Drawing.Point(488, 10);
            this.uiMarkLabel3.MarkColor = System.Drawing.Color.SlateGray;
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel3.Size = new System.Drawing.Size(217, 23);
            this.uiMarkLabel3.TabIndex = 60;
            this.uiMarkLabel3.Text = "공정 등록/수정/삭제";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiMarkLabel1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(3, 10);
            this.uiMarkLabel1.MarkColor = System.Drawing.Color.SlateGray;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(103, 23);
            this.uiMarkLabel1.TabIndex = 60;
            this.uiMarkLabel1.Text = "공정 목록";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtgviewOpeartionList
            // 
            this.dtgviewOpeartionList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgviewOpeartionList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgviewOpeartionList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgviewOpeartionList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewOpeartionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgviewOpeartionList.ColumnHeadersHeight = 30;
            this.dtgviewOpeartionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgviewOpeartionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgviewOpeartionList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgviewOpeartionList.EnableHeadersVisualStyles = false;
            this.dtgviewOpeartionList.GridColor = System.Drawing.Color.DarkGray;
            this.dtgviewOpeartionList.Location = new System.Drawing.Point(10, 40);
            this.dtgviewOpeartionList.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dtgviewOpeartionList.Name = "dtgviewOpeartionList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewOpeartionList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgviewOpeartionList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgviewOpeartionList.RowTemplate.Height = 30;
            this.dtgviewOpeartionList.Size = new System.Drawing.Size(465, 384);
            this.dtgviewOpeartionList.TabIndex = 81;
            this.dtgviewOpeartionList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgviewOpeartionList_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "공정번호";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "공정명";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "설명";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiMarkLabel2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiMarkLabel2.Location = new System.Drawing.Point(3, 10);
            this.uiMarkLabel2.MarkColor = System.Drawing.Color.SlateGray;
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(103, 23);
            this.uiMarkLabel2.TabIndex = 60;
            this.uiMarkLabel2.Text = "공정 목록";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView2.Location = new System.Drawing.Point(10, 40);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(269, 384);
            this.dataGridView2.TabIndex = 81;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "사원번호";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "이름";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 85;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "부서";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tboxoperCodeSearch, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnoperCodeSearch, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 58);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(236, 35);
            this.tableLayoutPanel2.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 65;
            this.label3.Text = "공정번호";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxoperCodeSearch
            // 
            this.tboxoperCodeSearch.ButtonSymbol = 61761;
            this.tboxoperCodeSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxoperCodeSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxoperCodeSearch.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxoperCodeSearch.IsScaled = false;
            this.tboxoperCodeSearch.Location = new System.Drawing.Point(97, 8);
            this.tboxoperCodeSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tboxoperCodeSearch.Maximum = 2147483647D;
            this.tboxoperCodeSearch.Minimum = -2147483648D;
            this.tboxoperCodeSearch.MinimumSize = new System.Drawing.Size(1, 20);
            this.tboxoperCodeSearch.Name = "tboxoperCodeSearch";
            this.tboxoperCodeSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxoperCodeSearch.Size = new System.Drawing.Size(81, 20);
            this.tboxoperCodeSearch.Style = Sunny.UI.UIStyle.Custom;
            this.tboxoperCodeSearch.TabIndex = 66;
            this.tboxoperCodeSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnoperCodeSearch
            // 
            this.btnoperCodeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnoperCodeSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnoperCodeSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnoperCodeSearch.FillHoverColor = System.Drawing.Color.Gray;
            this.btnoperCodeSearch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnoperCodeSearch.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnoperCodeSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnoperCodeSearch.IsScaled = false;
            this.btnoperCodeSearch.Location = new System.Drawing.Point(187, 6);
            this.btnoperCodeSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnoperCodeSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnoperCodeSearch.Name = "btnoperCodeSearch";
            this.btnoperCodeSearch.RectColor = System.Drawing.Color.Transparent;
            this.btnoperCodeSearch.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnoperCodeSearch.RectPressColor = System.Drawing.Color.Transparent;
            this.btnoperCodeSearch.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnoperCodeSearch.Size = new System.Drawing.Size(44, 23);
            this.btnoperCodeSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btnoperCodeSearch.Symbol = 61442;
            this.btnoperCodeSearch.TabIndex = 67;
            this.btnoperCodeSearch.Click += new System.EventHandler(this.btnoperCodeSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FillColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnClear.IsScaled = false;
            this.btnClear.Location = new System.Drawing.Point(893, 77);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnClear.Size = new System.Drawing.Size(130, 35);
            this.btnClear.Style = Sunny.UI.UIStyle.Custom;
            this.btnClear.Symbol = 61473;
            this.btnClear.TabIndex = 96;
            this.btnClear.Text = "새로 등록";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // OperationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.lblConUISub);
            this.Name = "OperationUI";
            this.Size = new System.Drawing.Size(1040, 674);
            this.Load += new System.EventHandler(this.OperationUI_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewOpeartionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILine uiLine1;
        private System.Windows.Forms.Label lblConUISub;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIMarkLabel uiMarkLabel3;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.DataGridView dtgviewOpeartionList;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Sunny.UI.UISymbolButton btnOperationUpdate;
        private Sunny.UI.UISymbolButton btnOperationAdd;
        private Sunny.UI.UISymbolButton btnOperationDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UITextBox tboxoprName;
        private System.Windows.Forms.Label label12;
        private Sunny.UI.UITextBox tboxoprCode;
        private System.Windows.Forms.Label label14;
        private Sunny.UI.UITextBox tboxoprDescription;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox tboxoperCodeSearch;
        private Sunny.UI.UISymbolButton btnoperCodeSearch;
        private Sunny.UI.UISymbolButton btnClear;
    }
}
