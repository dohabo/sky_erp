
namespace ERP_TESLA.UI.Common
{
    partial class CompanyPOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyPOP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.mainMin = new Sunny.UI.UISymbolButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoveNext = new Sunny.UI.UISymbolButton();
            this.btnMovePre = new Sunny.UI.UISymbolButton();
            this.dtgviewCom = new System.Windows.Forms.DataGridView();
            this.btnSelect = new Sunny.UI.UISymbolButton();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewCom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnTop.Controls.Add(this.mainMin);
            this.pnTop.Controls.Add(this.mainExit);
            this.pnTop.Controls.Add(this.pictureBox1);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(513, 34);
            this.pnTop.TabIndex = 92;
            this.pnTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseMove);
            // 
            // mainMin
            // 
            this.mainMin.BackColor = System.Drawing.Color.Transparent;
            this.mainMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainMin.FillColor = System.Drawing.Color.Transparent;
            this.mainMin.FillHoverColor = System.Drawing.Color.Black;
            this.mainMin.FillPressColor = System.Drawing.Color.Black;
            this.mainMin.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainMin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainMin.IsScaled = false;
            this.mainMin.Location = new System.Drawing.Point(427, 0);
            this.mainMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainMin.Name = "mainMin";
            this.mainMin.RectColor = System.Drawing.Color.Transparent;
            this.mainMin.RectHoverColor = System.Drawing.Color.Transparent;
            this.mainMin.RectPressColor = System.Drawing.Color.Transparent;
            this.mainMin.RectSelectedColor = System.Drawing.Color.Transparent;
            this.mainMin.Size = new System.Drawing.Size(43, 34);
            this.mainMin.Style = Sunny.UI.UIStyle.Custom;
            this.mainMin.Symbol = 61544;
            this.mainMin.SymbolSize = 25;
            this.mainMin.TabIndex = 12;
            this.mainMin.Click += new System.EventHandler(this.mainMin_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainExit.FillColor = System.Drawing.Color.Transparent;
            this.mainExit.FillHoverColor = System.Drawing.Color.Black;
            this.mainExit.FillPressColor = System.Drawing.Color.Black;
            this.mainExit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.IsScaled = false;
            this.mainExit.Location = new System.Drawing.Point(470, 0);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Transparent;
            this.mainExit.RectHoverColor = System.Drawing.Color.Transparent;
            this.mainExit.RectPressColor = System.Drawing.Color.Transparent;
            this.mainExit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.mainExit.Size = new System.Drawing.Size(43, 34);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61453;
            this.mainExit.SymbolSize = 25;
            this.mainExit.TabIndex = 11;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "거래처 조회";
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnMoveNext.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnMoveNext.IsScaled = false;
            this.btnMoveNext.Location = new System.Drawing.Point(278, 384);
            this.btnMoveNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.RectColor = System.Drawing.Color.Transparent;
            this.btnMoveNext.Size = new System.Drawing.Size(27, 32);
            this.btnMoveNext.Style = Sunny.UI.UIStyle.Custom;
            this.btnMoveNext.Symbol = 61524;
            this.btnMoveNext.TabIndex = 95;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnMovePre
            // 
            this.btnMovePre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovePre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnMovePre.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnMovePre.IsScaled = false;
            this.btnMovePre.Location = new System.Drawing.Point(217, 384);
            this.btnMovePre.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMovePre.Name = "btnMovePre";
            this.btnMovePre.RectColor = System.Drawing.Color.Transparent;
            this.btnMovePre.Size = new System.Drawing.Size(27, 32);
            this.btnMovePre.Style = Sunny.UI.UIStyle.Custom;
            this.btnMovePre.Symbol = 61523;
            this.btnMovePre.TabIndex = 94;
            this.btnMovePre.Click += new System.EventHandler(this.btnMovePre_Click);
            // 
            // dtgviewCom
            // 
            this.dtgviewCom.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgviewCom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgviewCom.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgviewCom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewCom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgviewCom.ColumnHeadersHeight = 30;
            this.dtgviewCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgviewCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn,
            this.colCCode,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgviewCom.EnableHeadersVisualStyles = false;
            this.dtgviewCom.GridColor = System.Drawing.Color.DarkGray;
            this.dtgviewCom.Location = new System.Drawing.Point(10, 41);
            this.dtgviewCom.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dtgviewCom.Name = "dtgviewCom";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewCom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgviewCom.RowHeadersVisible = false;
            this.dtgviewCom.RowTemplate.Height = 30;
            this.dtgviewCom.Size = new System.Drawing.Size(493, 337);
            this.dtgviewCom.TabIndex = 93;
            this.dtgviewCom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgviewCom_CellClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnSelect.FillHoverColor = System.Drawing.Color.Gray;
            this.btnSelect.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelect.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSelect.IsScaled = false;
            this.btnSelect.Location = new System.Drawing.Point(430, 388);
            this.btnSelect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.RectColor = System.Drawing.Color.Transparent;
            this.btnSelect.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnSelect.RectPressColor = System.Drawing.Color.Transparent;
            this.btnSelect.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnSelect.Size = new System.Drawing.Size(71, 27);
            this.btnSelect.Style = Sunny.UI.UIStyle.Custom;
            this.btnSelect.TabIndex = 96;
            this.btnSelect.Text = "선택";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.HeaderText = "선택";
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            this.CheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckBoxColumn.Width = 80;
            // 
            // colCCode
            // 
            this.colCCode.HeaderText = "회사번호";
            this.colCCode.Name = "colCCode";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "회사명";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "대표";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "전화번호";
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // CompanyPOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 427);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.btnMovePre);
            this.Controls.Add(this.dtgviewCom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "CompanyPOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyPOP";
            this.Load += new System.EventHandler(this.CompanyPOP_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewCom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private Sunny.UI.UISymbolButton mainMin;
        private Sunny.UI.UISymbolButton mainExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UISymbolButton btnMoveNext;
        private Sunny.UI.UISymbolButton btnMovePre;
        private System.Windows.Forms.DataGridView dtgviewCom;
        private Sunny.UI.UISymbolButton btnSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}