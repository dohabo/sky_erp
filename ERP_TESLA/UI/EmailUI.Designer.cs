
namespace ERP_TESLA.UI
{
    partial class EmailUI
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tboxTitle = new Sunny.UI.UITextBox();
            this.tboxAttach = new Sunny.UI.UITextBox();
            this.tboxPW = new Sunny.UI.UITextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tboxSendby = new Sunny.UI.UITextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tboxSendTo = new Sunny.UI.UITextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tboxContents = new Sunny.UI.UITextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSearchSendTo = new Sunny.UI.UISymbolButton();
            this.btnAttach = new Sunny.UI.UISymbolButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new Sunny.UI.UISymbolButton();
            this.btnClear = new Sunny.UI.UISymbolButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.78572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.928571F));
            this.tableLayoutPanel1.Controls.Add(this.tboxTitle, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tboxAttach, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tboxPW, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboxSendby, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tboxSendTo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tboxContents, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearchSendTo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAttach, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.09678F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.09677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.09677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.09677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.09677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.51613F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 372);
            this.tableLayoutPanel1.TabIndex = 89;
            // 
            // tboxTitle
            // 
            this.tboxTitle.ButtonSymbol = 61761;
            this.tboxTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxTitle.IsScaled = false;
            this.tboxTitle.Location = new System.Drawing.Point(128, 188);
            this.tboxTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxTitle.Maximum = 2147483647D;
            this.tboxTitle.Minimum = -2147483648D;
            this.tboxTitle.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxTitle.Name = "tboxTitle";
            this.tboxTitle.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxTitle.Size = new System.Drawing.Size(276, 32);
            this.tboxTitle.Style = Sunny.UI.UIStyle.Custom;
            this.tboxTitle.TabIndex = 90;
            this.tboxTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxAttach
            // 
            this.tboxAttach.ButtonSymbol = 61761;
            this.tboxAttach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxAttach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxAttach.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxAttach.IsScaled = false;
            this.tboxAttach.Location = new System.Drawing.Point(128, 143);
            this.tboxAttach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxAttach.Maximum = 2147483647D;
            this.tboxAttach.Minimum = -2147483648D;
            this.tboxAttach.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxAttach.Name = "tboxAttach";
            this.tboxAttach.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxAttach.Size = new System.Drawing.Size(276, 32);
            this.tboxAttach.Style = Sunny.UI.UIStyle.Custom;
            this.tboxAttach.TabIndex = 90;
            this.tboxAttach.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxPW
            // 
            this.tboxPW.ButtonSymbol = 61761;
            this.tboxPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxPW.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxPW.IsScaled = false;
            this.tboxPW.Location = new System.Drawing.Point(128, 53);
            this.tboxPW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxPW.Maximum = 2147483647D;
            this.tboxPW.Minimum = -2147483648D;
            this.tboxPW.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxPW.Name = "tboxPW";
            this.tboxPW.PasswordChar = '●';
            this.tboxPW.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxPW.Size = new System.Drawing.Size(276, 32);
            this.tboxPW.Style = Sunny.UI.UIStyle.Custom;
            this.tboxPW.TabIndex = 97;
            this.tboxPW.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(3, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 42);
            this.label11.TabIndex = 95;
            this.label11.Text = "첨부";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(3, 93);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 42);
            this.label12.TabIndex = 94;
            this.label12.Text = "받는사람(e-mail)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxSendby
            // 
            this.tboxSendby.ButtonSymbol = 61761;
            this.tboxSendby.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxSendby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxSendby.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxSendby.IsScaled = false;
            this.tboxSendby.Location = new System.Drawing.Point(128, 8);
            this.tboxSendby.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxSendby.Maximum = 2147483647D;
            this.tboxSendby.Minimum = -2147483648D;
            this.tboxSendby.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxSendby.Name = "tboxSendby";
            this.tboxSendby.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxSendby.Size = new System.Drawing.Size(276, 32);
            this.tboxSendby.Style = Sunny.UI.UIStyle.Custom;
            this.tboxSendby.TabIndex = 89;
            this.tboxSendby.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(3, 48);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 42);
            this.label14.TabIndex = 93;
            this.label14.Text = "비밀번호(pw)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(3, 183);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 42);
            this.label15.TabIndex = 96;
            this.label15.Text = "제목";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxSendTo
            // 
            this.tboxSendTo.ButtonSymbol = 61761;
            this.tboxSendTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxSendTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxSendTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxSendTo.IsScaled = false;
            this.tboxSendTo.Location = new System.Drawing.Point(128, 98);
            this.tboxSendTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxSendTo.Maximum = 2147483647D;
            this.tboxSendTo.Minimum = -2147483648D;
            this.tboxSendTo.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxSendTo.Name = "tboxSendTo";
            this.tboxSendTo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxSendTo.Size = new System.Drawing.Size(276, 32);
            this.tboxSendTo.Style = Sunny.UI.UIStyle.Custom;
            this.tboxSendTo.TabIndex = 104;
            this.tboxSendTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(3, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 141);
            this.label10.TabIndex = 98;
            this.label10.Tag = "내용";
            this.label10.Text = "내용";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxContents
            // 
            this.tboxContents.ButtonSymbol = 61761;
            this.tboxContents.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxContents.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxContents.IsScaled = false;
            this.tboxContents.Location = new System.Drawing.Point(128, 233);
            this.tboxContents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxContents.Maximum = 2147483647D;
            this.tboxContents.Minimum = -2147483648D;
            this.tboxContents.MinimumSize = new System.Drawing.Size(1, 16);
            this.tboxContents.Multiline = true;
            this.tboxContents.Name = "tboxContents";
            this.tboxContents.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tboxContents.Size = new System.Drawing.Size(276, 131);
            this.tboxContents.Style = Sunny.UI.UIStyle.Custom;
            this.tboxContents.TabIndex = 103;
            this.tboxContents.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 42);
            this.label13.TabIndex = 79;
            this.label13.Text = "작성자(e-mail)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchSendTo
            // 
            this.btnSearchSendTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchSendTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnSearchSendTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSearchSendTo.IsScaled = false;
            this.btnSearchSendTo.Location = new System.Drawing.Point(414, 96);
            this.btnSearchSendTo.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearchSendTo.Name = "btnSearchSendTo";
            this.btnSearchSendTo.RectColor = System.Drawing.Color.Transparent;
            this.btnSearchSendTo.Size = new System.Drawing.Size(34, 31);
            this.btnSearchSendTo.Style = Sunny.UI.UIStyle.Custom;
            this.btnSearchSendTo.Symbol = 61442;
            this.btnSearchSendTo.TabIndex = 107;
            this.btnSearchSendTo.Click += new System.EventHandler(this.btnSearchSendTo_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnAttach.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnAttach.IsScaled = false;
            this.btnAttach.Location = new System.Drawing.Point(414, 141);
            this.btnAttach.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.RectColor = System.Drawing.Color.Transparent;
            this.btnAttach.Size = new System.Drawing.Size(34, 31);
            this.btnAttach.Style = Sunny.UI.UIStyle.Custom;
            this.btnAttach.Symbol = 61717;
            this.btnAttach.TabIndex = 107;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
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
            this.label2.TabIndex = 105;
            this.label2.Text = "▶ E-Mail 발송";
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnSend.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSend.IsScaled = false;
            this.btnSend.Location = new System.Drawing.Point(338, 453);
            this.btnSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.RectColor = System.Drawing.Color.Transparent;
            this.btnSend.Size = new System.Drawing.Size(84, 35);
            this.btnSend.Style = Sunny.UI.UIStyle.Custom;
            this.btnSend.Symbol = 361912;
            this.btnSend.TabIndex = 106;
            this.btnSend.Text = "발송";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnClear.IsScaled = false;
            this.btnClear.Location = new System.Drawing.Point(248, 453);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.RectColor = System.Drawing.Color.Transparent;
            this.btnClear.Size = new System.Drawing.Size(84, 35);
            this.btnClear.Style = Sunny.UI.UIStyle.Custom;
            this.btnClear.Symbol = 61473;
            this.btnClear.TabIndex = 107;
            this.btnClear.Text = "새글";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLine1.IsScaled = false;
            this.uiLine1.LineColor = System.Drawing.Color.LightSlateGray;
            this.uiLine1.LineSize = 2;
            this.uiLine1.Location = new System.Drawing.Point(-3, 48);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(550, 2);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 108;
            // 
            // EmailUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 520);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmailUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmailUI";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UITextBox tboxTitle;
        private Sunny.UI.UITextBox tboxAttach;
        private Sunny.UI.UITextBox tboxPW;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Sunny.UI.UITextBox tboxSendby;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Sunny.UI.UITextBox tboxSendTo;
        private System.Windows.Forms.Label label10;
        private Sunny.UI.UITextBox tboxContents;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UISymbolButton btnSend;
        private Sunny.UI.UISymbolButton btnAttach;
        private Sunny.UI.UISymbolButton btnClear;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolButton btnSearchSendTo;
    }
}