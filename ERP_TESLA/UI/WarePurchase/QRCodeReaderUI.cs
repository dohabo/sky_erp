using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge.Controls;
using System.Drawing.Imaging;
using ERP_TESLA.DAO;
using ERP_TESLA.CLASS.WarePurchase;

namespace ERP_TESLA.UI.WarePurchase
{
    partial class QRCodeReaderUI : Form
    {
        List<Input> inputlist;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public List<Input> Inputlist { get => inputlist; set => inputlist = value; }

        public QRCodeReaderUI()
        {
            InitializeComponent();
        }

        private void QRCodeReaderUI_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cboxCamera.Items.Add(device.Name);
            cboxCamera.SelectedIndex = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboxCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                tboxValue.Invoke(new MethodInvoker(delegate ()
                {
                    tboxValue.Text = result.ToString();
                }));
            }
            pictureBox1.Image = bitmap;
        }

        private void QRCodeReaderUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void tboxValue_TextChanged(object sender, EventArgs e)
        {
            char divide = '/';
            //발주번호 / 거래처 / 품번 / 수량
            string[] data = tboxValue.Text.Split(divide);
            dtgviewInputAdd.Rows.Add(data);
        }

        private void dtgviewInputAdd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dtgviewInputAdd.Rows.Count; i++)
            {
                if(dtgviewInputAdd.Rows[i].Cells[colMCode.Index].Value != null)
                {
                    string MCode = dtgviewInputAdd.Rows[i].Cells[colMCode.Index].Value.ToString();
                    dtgviewInputAdd.Rows[i].Cells[colMName.Index].Value = OraMgr.Instance.selectMName(MCode);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgviewInputAdd.Rows.Count; i++)
            {
                Input input =
                    new Input(
                        int.Parse(dtgviewInputAdd.Rows[i].Cells[colPOrder.Index].Value.ToString()),
                        int.Parse(dtgviewInputAdd.Rows[i].Cells[colCCOde.Index].Value.ToString()),
                        dtgviewInputAdd.Rows[i].Cells[colMCode.Index].Value.ToString(),
                        dtgviewInputAdd.Rows[i].Cells[colMName.Index].Value.ToString(),
                        int.Parse(dtgviewInputAdd.Rows[i].Cells[colAmount.Index].Value.ToString())
                    );
                List<Input> inputTemp = new List<Input>();
                inputTemp.Add(input);
                this.inputlist = inputTemp;
            }
        }

        //void QRCodeReaderUI_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        FilterInfoCollection fiCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

        //        foreach (FilterInfo fi in fiCollection)
        //        {
        //            cboxCamera.Items.Add(fi.MonikerString);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //int _wid = 640;
        //int _hei = 480;
        //VideoSourcePlayer videoSourcePlayer1;
        //void setPlayer()
        //{
        //    videoSourcePlayer1 = new VideoSourcePlayer();
        //    videoSourcePlayer1.Width = _wid;
        //    videoSourcePlayer1.Height = _hei;
        //    this.Controls.Add(videoSourcePlayer1);
        //
        //}
        //void QRCodeReaderUI_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    try
        //    {
        //        videoSourcePlayer1.SignalToStop();
        //        videoSourcePlayer1.WaitForStop();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void btnOK_Click(object sender, EventArgs e)
        //{
        //    VideoCaptureDevice cam = new VideoCaptureDevice(cboxCamera.SelectedItem.ToString());
        //    cam.DesiredFrameRate = 30;
        //    videoSourcePlayer1.VideoSource = cam;
        //    videoSourcePlayer1.Start();
        //}
    }
}

