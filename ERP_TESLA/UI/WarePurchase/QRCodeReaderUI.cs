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

namespace ERP_TESLA.UI.WarePurchase
{
    public partial class QRCodeReaderUI : Form
    {
        public QRCodeReaderUI()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

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
                textBox1.Invoke(new MethodInvoker(delegate ()
                {
                    textBox1.Text = result.ToString();
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

