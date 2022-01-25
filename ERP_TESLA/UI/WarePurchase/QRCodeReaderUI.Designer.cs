
namespace ERP_TESLA.UI.WarePurchase
{
    partial class QRCodeReaderUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxValue = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboxCamera = new System.Windows.Forms.ComboBox();
            this.dtgviewInputAdd = new System.Windows.Forms.DataGridView();
            this.colPOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCOde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStart = new Sunny.UI.UISymbolButton();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.label3 = new System.Windows.Forms.Label();
            this.uiLine1 = new Sunny.UI.UILine();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewInputAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용기기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "바코드 값 :";
            // 
            // tboxValue
            // 
            this.tboxValue.Location = new System.Drawing.Point(109, 281);
            this.tboxValue.Name = "tboxValue";
            this.tboxValue.Size = new System.Drawing.Size(197, 21);
            this.tboxValue.TabIndex = 1;
            this.tboxValue.TextChanged += new System.EventHandler(this.tboxValue_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(40, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cboxCamera
            // 
            this.cboxCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCamera.FormattingEnabled = true;
            this.cboxCamera.Location = new System.Drawing.Point(115, 63);
            this.cboxCamera.Name = "cboxCamera";
            this.cboxCamera.Size = new System.Drawing.Size(121, 20);
            this.cboxCamera.TabIndex = 4;
            // 
            // dtgviewInputAdd
            // 
            this.dtgviewInputAdd.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgviewInputAdd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgviewInputAdd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgviewInputAdd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewInputAdd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgviewInputAdd.ColumnHeadersHeight = 30;
            this.dtgviewInputAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgviewInputAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPOrder,
            this.colCCOde,
            this.colMCode,
            this.colAmount,
            this.colMName});
            this.dtgviewInputAdd.EnableHeadersVisualStyles = false;
            this.dtgviewInputAdd.GridColor = System.Drawing.Color.DarkGray;
            this.dtgviewInputAdd.Location = new System.Drawing.Point(319, 89);
            this.dtgviewInputAdd.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dtgviewInputAdd.Name = "dtgviewInputAdd";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgviewInputAdd.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgviewInputAdd.RowTemplate.Height = 30;
            this.dtgviewInputAdd.Size = new System.Drawing.Size(522, 213);
            this.dtgviewInputAdd.TabIndex = 86;
            this.dtgviewInputAdd.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgviewInputAdd_RowsAdded);
            // 
            // colPOrder
            // 
            this.colPOrder.HeaderText = "발주번호";
            this.colPOrder.Name = "colPOrder";
            // 
            // colCCOde
            // 
            this.colCCOde.HeaderText = "거래처";
            this.colCCOde.Name = "colCCOde";
            this.colCCOde.Width = 90;
            // 
            // colMCode
            // 
            this.colMCode.HeaderText = "자재품번";
            this.colMCode.Name = "colMCode";
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "수량";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 80;
            // 
            // colMName
            // 
            this.colMName.HeaderText = "자재품명";
            this.colMName.Name = "colMName";
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnStart.FillHoverColor = System.Drawing.Color.Gray;
            this.btnStart.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnStart.IsScaled = false;
            this.btnStart.Location = new System.Drawing.Point(242, 63);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.RectColor = System.Drawing.Color.Transparent;
            this.btnStart.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnStart.RectPressColor = System.Drawing.Color.Transparent;
            this.btnStart.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnStart.Size = new System.Drawing.Size(64, 23);
            this.btnStart.Style = Sunny.UI.UIStyle.Custom;
            this.btnStart.Symbol = 61515;
            this.btnStart.SymbolSize = 14;
            this.btnStart.TabIndex = 113;
            this.btnStart.Text = "시작";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnAdd.FillHoverColor = System.Drawing.Color.Gray;
            this.btnAdd.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnAdd.IsScaled = false;
            this.btnAdd.Location = new System.Drawing.Point(777, 63);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RectColor = System.Drawing.Color.Transparent;
            this.btnAdd.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnAdd.RectPressColor = System.Drawing.Color.Transparent;
            this.btnAdd.RectSelectedColor = System.Drawing.Color.Transparent;
            this.btnAdd.Size = new System.Drawing.Size(64, 23);
            this.btnAdd.Style = Sunny.UI.UIStyle.Custom;
            this.btnAdd.Symbol = 61508;
            this.btnAdd.SymbolSize = 14;
            this.btnAdd.TabIndex = 114;
            this.btnAdd.Text = "적용";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 115;
            this.label3.Text = "▶ 바코드 입고 처리";
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLine1.IsScaled = false;
            this.uiLine1.LineColor = System.Drawing.Color.LightSlateGray;
            this.uiLine1.LineSize = 2;
            this.uiLine1.Location = new System.Drawing.Point(-2, 47);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(850, 2);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 116;
            // 
            // QRCodeReaderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 336);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dtgviewInputAdd);
            this.Controls.Add(this.cboxCamera);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tboxValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QRCodeReaderUI";
            this.Text = "QRCodeReaderUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRCodeReaderUI_FormClosing);
            this.Load += new System.EventHandler(this.QRCodeReaderUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewInputAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboxCamera;
        private System.Windows.Forms.DataGridView dtgviewInputAdd;
        private Sunny.UI.UISymbolButton btnStart;
        private Sunny.UI.UISymbolButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCOde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMName;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UILine uiLine1;
    }
}