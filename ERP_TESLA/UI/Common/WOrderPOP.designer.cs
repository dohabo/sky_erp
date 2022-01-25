
namespace ERP_TESLA.UI.Common
{
    partial class WOrderPOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WOrderPOP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.mainMin = new Sunny.UI.UISymbolButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoveNext = new Sunny.UI.UISymbolButton();
            this.btnMovePre = new Sunny.UI.UISymbolButton();
            this.dtgviewWOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colwOrderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2proPlanCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2mCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2mName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new Sunny.UI.UISymbolButton();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewWOrder)).BeginInit();
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
            this.pnTop.Size = new System.Drawing.Size(999, 34);
            this.pnTop.TabIndex = 96;
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
            this.mainMin.Location = new System.Drawing.Point(913, 0);
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
            this.mainExit.Location = new System.Drawing.Point(956, 0);
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
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "작업지시목록 조회";
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnMoveNext.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnMoveNext.IsScaled = false;
            this.btnMoveNext.Location = new System.Drawing.Point(491, 383);
            this.btnMoveNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.RectColor = System.Drawing.Color.Transparent;
            this.btnMoveNext.Size = new System.Drawing.Size(27, 32);
            this.btnMoveNext.Style = Sunny.UI.UIStyle.Custom;
            this.btnMoveNext.Symbol = 61524;
            this.btnMoveNext.TabIndex = 99;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnMovePre
            // 
            this.btnMovePre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovePre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnMovePre.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnMovePre.IsScaled = false;
            this.btnMovePre.Location = new System.Drawing.Point(430, 383);
            this.btnMovePre.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMovePre.Name = "btnMovePre";
            this.btnMovePre.RectColor = System.Drawing.Color.Transparent;
            this.btnMovePre.Size = new System.Drawing.Size(27, 32);
            this.btnMovePre.Style = Sunny.UI.UIStyle.Custom;
            this.btnMovePre.Symbol = 61523;
            this.btnMovePre.TabIndex = 98;
            this.btnMovePre.Click += new System.EventHandler(this.btnMovePre_Click);
            // 
            // dtgviewWOrder
            // 
            this.dtgviewWOrder.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgviewWOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgviewWOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgviewWOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewWOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgviewWOrder.ColumnHeadersHeight = 30;
            this.dtgviewWOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgviewWOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.colwOrderCode,
            this.col2proPlanCode,
            this.col2mCode,
            this.col2mName,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.colcCode,
            this.dataGridViewTextBoxColumn18});
            this.dtgviewWOrder.EnableHeadersVisualStyles = false;
            this.dtgviewWOrder.GridColor = System.Drawing.Color.DarkGray;
            this.dtgviewWOrder.Location = new System.Drawing.Point(9, 40);
            this.dtgviewWOrder.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dtgviewWOrder.Name = "dtgviewWOrder";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewWOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dtgviewWOrder.RowHeadersVisible = false;
            this.dtgviewWOrder.RowTemplate.Height = 30;
            this.dtgviewWOrder.Size = new System.Drawing.Size(983, 337);
            this.dtgviewWOrder.TabIndex = 100;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "선택";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.Width = 75;
            // 
            // colwOrderCode
            // 
            this.colwOrderCode.HeaderText = "지시번호";
            this.colwOrderCode.Name = "colwOrderCode";
            // 
            // col2proPlanCode
            // 
            this.col2proPlanCode.HeaderText = "생산계획번호";
            this.col2proPlanCode.Name = "col2proPlanCode";
            this.col2proPlanCode.Width = 135;
            // 
            // col2mCode
            // 
            this.col2mCode.HeaderText = "품번";
            this.col2mCode.Name = "col2mCode";
            this.col2mCode.Width = 80;
            // 
            // col2mName
            // 
            this.col2mName.HeaderText = "품명";
            this.col2mName.Name = "col2mName";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "수량";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "지시일";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "완료예정일";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // colcCode
            // 
            this.colcCode.HeaderText = "납품처";
            this.colcCode.Name = "colcCode";
            this.colcCode.Width = 90;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "상태";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 74;
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
            this.btnSelect.Location = new System.Drawing.Point(921, 388);
            this.btnSelect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.RectColor = System.Drawing.Color.Transparent;
            this.btnSelect.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnSelect.RectPressColor = System.Drawing.Color.Transparent;
            this.btnSelect.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnSelect.Size = new System.Drawing.Size(71, 27);
            this.btnSelect.Style = Sunny.UI.UIStyle.Custom;
            this.btnSelect.TabIndex = 103;
            this.btnSelect.Text = "선택";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // WOrderPOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 427);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dtgviewWOrder);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.btnMovePre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WOrderPOP";
            this.Text = "WOrderPOP";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewWOrder)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgviewWOrder;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colwOrderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2proPlanCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2mCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2mName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private Sunny.UI.UISymbolButton btnSelect;
    }
}