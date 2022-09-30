using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MessagingToolkit.QRCode.Codec;

namespace Stok_Takip
{
    public partial class frmBarkodOluştur : Form
    {
        public frmBarkodOluştur()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(txtCode.Text,60);
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureBox1.Image = enc.Encode(txtCode.Text);
            //Zen.Barcode.CodeQrBarcodeDraw Qr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            //pictureBox1.Image = Qr.Draw(txtCode.Text, 60);
        }

        private void frmBarkodOluştur_Load(object sender, EventArgs e)
        {

        }
    }
}
