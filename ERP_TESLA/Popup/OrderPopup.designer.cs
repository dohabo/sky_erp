namespace ERP_TESLA.PoPUP
{
    partial class OrderPopup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConfirm = new Sunny.UI.UISymbolButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMoveNext = new Sunny.UI.UISymbolButton();
            this.btnMovePre = new Sunny.UI.UISymbolButton();
            this.lblcMgt = new Sunny.UI.UIMarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.IsScaled = false;
            this.btnConfirm.Location = new System.Drawing.Point(310, 316);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RectColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Size = new System.Drawing.Size(53, 24);
            this.btnConfirm.Style = Sunny.UI.UIStyle.Custom;
            this.btnConfirm.SymbolSize = 12;
            this.btnConfirm.TabIndex = 91;
            this.btnConfirm.Text = "확인";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(7, 49);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(356, 261);
            this.dataGridView1.TabIndex = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "번호";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "거래처번호";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "거래처명";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "비고";
            this.Column4.Name = "Column4";
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnMoveNext.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnMoveNext.IsScaled = false;
            this.btnMoveNext.Location = new System.Drawing.Point(339, 21);
            this.btnMoveNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.RectColor = System.Drawing.Color.Transparent;
            this.btnMoveNext.Size = new System.Drawing.Size(20, 24);
            this.btnMoveNext.Style = Sunny.UI.UIStyle.Custom;
            this.btnMoveNext.Symbol = 61524;
            this.btnMoveNext.TabIndex = 89;
            // 
            // btnMovePre
            // 
            this.btnMovePre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovePre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnMovePre.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnMovePre.IsScaled = false;
            this.btnMovePre.Location = new System.Drawing.Point(310, 21);
            this.btnMovePre.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMovePre.Name = "btnMovePre";
            this.btnMovePre.RectColor = System.Drawing.Color.Transparent;
            this.btnMovePre.Size = new System.Drawing.Size(20, 24);
            this.btnMovePre.Style = Sunny.UI.UIStyle.Custom;
            this.btnMovePre.Symbol = 61523;
            this.btnMovePre.TabIndex = 88;
            // 
            // lblcMgt
            // 
            this.lblcMgt.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblcMgt.Location = new System.Drawing.Point(7, 19);
            this.lblcMgt.MarkColor = System.Drawing.Color.SlateGray;
            this.lblcMgt.Name = "lblcMgt";
            this.lblcMgt.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblcMgt.Size = new System.Drawing.Size(100, 23);
            this.lblcMgt.TabIndex = 87;
            this.lblcMgt.Text = "주문 내역";
            this.lblcMgt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 359);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.btnMovePre);
            this.Controls.Add(this.lblcMgt);
            this.Name = "OrderPopup";
            this.Text = "OrderPopup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton btnConfirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Sunny.UI.UISymbolButton btnMoveNext;
        private Sunny.UI.UISymbolButton btnMovePre;
        private Sunny.UI.UIMarkLabel lblcMgt;
    }
}