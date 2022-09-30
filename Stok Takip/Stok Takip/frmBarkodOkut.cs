using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Stok_Takip
{
    public partial class frmBarkodOkut : Form
    {
        public frmBarkodOkut()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void frmBarcode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo f in filterInfoCollection)
            {
                comboKamera.Items.Add(f.Name);
                comboKamera.SelectedIndex = 0;
            }
        }
        private void btnBaşlat_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboKamera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            //timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            
            try
            {
                Bitmap goruntulenenbarkod = (Bitmap)eventArgs.Frame.Clone();
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode(goruntulenenbarkod);
                if (result != null)
                {
                    txtKod.Invoke(new MethodInvoker(delegate ()
                    {
                        txtKod.Text = result.ToString();
                        //frmSatış satış = (frmSatış)Application.OpenForms["frmSatış"];
                        //satış.txtBarkodNo.Text = result.ToString();
                    }
                    ));
                    //Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);  
                }
                pictureBox1.Image = goruntulenenbarkod;
            }
            catch (Exception)
            {

                
            }
           
        }

        private void frmBarcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null)
            {
                if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                }
            }
          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKod_TextChanged(object sender, EventArgs e)
        {
            if (txtKod.Text != "")
            {
                frmSatış frmSatış = (frmSatış)Application.OpenForms["frmSatış"];
                frmSatış.txtBarkodNo.Text = txtKod.Text;

            }
        }
    }
}
