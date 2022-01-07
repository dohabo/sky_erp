
namespace ERP_TESLA.UI.WarePurchase
{
    partial class QRCodeUI
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
            this.label7 = new System.Windows.Forms.Label();
            this.cbSizeList = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCorrectionLevel = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.picEncode = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.pictBarcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEncode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "Size Level :";
            // 
            // cbSizeList
            // 
            this.cbSizeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSizeList.FormattingEnabled = true;
            this.cbSizeList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSizeList.Location = new System.Drawing.Point(696, 29);
            this.cbSizeList.Name = "cbSizeList";
            this.cbSizeList.Size = new System.Drawing.Size(141, 20);
            this.cbSizeList.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 21);
            this.txtName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name :";
            // 
            // cbCorrectionLevel
            // 
            this.cbCorrectionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCorrectionLevel.FormattingEnabled = true;
            this.cbCorrectionLevel.Location = new System.Drawing.Point(141, 125);
            this.cbCorrectionLevel.Name = "cbCorrectionLevel";
            this.cbCorrectionLevel.Size = new System.Drawing.Size(155, 20);
            this.cbCorrectionLevel.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 12);
            this.label15.TabIndex = 25;
            this.label15.Text = "Correction Level :";
            // 
            // cbVersion
            // 
            this.cbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Location = new System.Drawing.Point(92, 80);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(204, 20);
            this.cbVersion.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 12);
            this.label14.TabIndex = 27;
            this.label14.Text = "Version :";
            // 
            // picEncode
            // 
            this.picEncode.Location = new System.Drawing.Point(32, 191);
            this.picEncode.Name = "picEncode";
            this.picEncode.Size = new System.Drawing.Size(587, 109);
            this.picEncode.TabIndex = 29;
            this.picEncode.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(520, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(601, 162);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 23);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "QRCode 생성";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "BarCode 생성";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(116, 393);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(196, 21);
            this.txtInput.TabIndex = 16;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(327, 393);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(196, 21);
            this.txtWeight.TabIndex = 16;
            // 
            // pictBarcode
            // 
            this.pictBarcode.Location = new System.Drawing.Point(32, 443);
            this.pictBarcode.Name = "pictBarcode";
            this.pictBarcode.Size = new System.Drawing.Size(587, 109);
            this.pictBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBarcode.TabIndex = 29;
            this.pictBarcode.TabStop = false;
            // 
            // QRCodeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pictBarcode);
            this.Controls.Add(this.picEncode);
            this.Controls.Add(this.cbVersion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbCorrectionLevel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSizeList);
            this.Name = "QRCodeUI";
            this.Text = "QRCodeUI";
            this.Load += new System.EventHandler(this.QRCodeUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEncode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSizeList;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCorrectionLevel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbVersion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox picEncode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.PictureBox pictBarcode;
    }
}