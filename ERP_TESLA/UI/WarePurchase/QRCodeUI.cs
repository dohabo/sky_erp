using GenCode128;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace ERP_TESLA.UI.WarePurchase
{
    public partial class QRCodeUI : Form
    {
        public QRCodeUI()
        {
            InitializeComponent();

            
        }

        private void QRCodeUI_Load(object sender, EventArgs e)
        {
            // 콤보박스 사이즈 바인딩
            var sizeItems = new Dictionary<string, int>();
            sizeItems["01 level"] = 1;
            sizeItems["02 level"] = 2;
            sizeItems["03 level"] = 3;
            sizeItems["04 level"] = 4;
            sizeItems["05 level"] = 5;
            sizeItems["06 level"] = 6;
            cbSizeList.DataSource = new BindingSource(sizeItems, null);
            cbSizeList.DisplayMember = "Key";
            cbSizeList.ValueMember = "Value";

            // 기본값 지정.
            cbSizeList.SelectedValue = 4;

            // 콤보박스 Version 바인딩
            var versionItems = new Dictionary<string, int>();
            for (int i = 9; i < 41; i++)
            {
                versionItems[i.ToString()] = i;
            }
            cbVersion.DataSource = new BindingSource(versionItems, null);
            cbVersion.DisplayMember = "Key";
            cbVersion.ValueMember = "Value";
            cbVersion.SelectedIndex = 0;

            // 콤보박스 Correction Level 바인딩
            var correctionLevelItems = new Dictionary<string, string>();
            correctionLevelItems["L"] = "L";
            correctionLevelItems["M"] = "M";
            correctionLevelItems["Q"] = "Q";
            correctionLevelItems["H"] = "H";

            cbCorrectionLevel.DataSource = new BindingSource(correctionLevelItems, null);
            cbCorrectionLevel.DisplayMember = "Key";
            cbCorrectionLevel.ValueMember = "Value";
            cbCorrectionLevel.SelectedIndex = 1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int sizeNum = (int)cbSizeList.SelectedValue;

            // 다른건 입력 안해도 이름은 꼭 넣어라.   
            string userName = txtName.Text.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("이름이라도 넣어 주세요!!");
                return;
            }

            // MECARD 포맷으로 변경한다.   
            StringBuilder cardeFormat = new StringBuilder();

            cardeFormat.Append("MECARD:"); // 카드형태 선언   
            cardeFormat.AppendFormat("N:{0};", txtName.Text.Trim()); // 이름


            // QRCodeEncoder 인스턴스 생성   
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            // 인코딩모드는 바이트로 설정.   
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            // QRCode 사이즈 지정.   
            qrCodeEncoder.QRCodeScale = sizeNum;
            // 버전을 지정.(주의 : MECOARD로 만들려면 9이상으로 지정한다.)   
            //qrCodeEncoder.QRCodeVersion = 9;   
            int level = (int)cbVersion.SelectedValue;
            qrCodeEncoder.QRCodeVersion = level;
            // 에러 보정 레벨을 지정.   
            //qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;   
            switch (cbCorrectionLevel.SelectedValue.ToString())
            {
                case "H":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                    break;
                case "Q":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                    break;
                case "L":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                    break;
                case "M":
                default:
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                    break;
            }

            Image qrImage;
            string data = cardeFormat.ToString();
            try
            {
                // QRCode 이미지를 생성해 줌.   
                qrImage = qrCodeEncoder.Encode(data);
                picEncode.Image = qrImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 상황 발생!! 세팅을 확인해 보세요!!");
            }

            // 저장버튼 활성화   
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.FileName = string.Empty;
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.picEncode.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.picEncode.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.picEncode.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 4:
                        this.picEncode.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }

                fs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Image myimg = Code128Rendering.MakeBarcodeImage(txtInput.Text, int.Parse(txtWeight.Text), true);
                pictBarcode.Image = myimg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, this.Text);
            }
        }
    }
}
