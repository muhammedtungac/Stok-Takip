using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Stok_Takip
{
    public partial class frmÜrünEkle : Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.DataRead("select * from Ürün");
            
            while (SqlBaglanti.read.Read())
            {
                if (txtBarkodNo.Text==SqlBaglanti.read["barkodno"].ToString() || txtBarkodNo.Text=="")
                {
                    durum = false;
                }
            }
        }
        private void KategoriGetir()
        {
            baglanti.DataRead("select *from kategoribilgileri");
            
            while (SqlBaglanti.read.Read())
            {
                comboKategori.Items.Add(SqlBaglanti.read["kategori"].ToString());
            }
            
        }
        private void frmÜrünEkle_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.DataRead("select * from markabilgileri where kategori='" + comboKategori.SelectedItem + "'");
            
            while (SqlBaglanti.read.Read())
            {
                comboMarka.Items.Add(SqlBaglanti.read["marka"].ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                baglanti.SqlComm("insert into Ürün(BarkodNo,Kategori,Marka,UrunAdi,Miktari,AlisFiyati,SatisFiyati,Tarih) values (@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih) ");
              

                SqlBaglanti.comm.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@kategori", comboKategori.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@marka", comboMarka.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@miktari", int.Parse(txtMiktar.Text));
                SqlBaglanti.comm.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlışFiyatı.Text));
                SqlBaglanti.comm.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text));
                SqlBaglanti.comm.Parameters.AddWithValue("@tarih", DateTime.Now);

                SqlBaglanti.comm.ExecuteNonQuery();
                
                MessageBox.Show("Ürün Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir Barkod No Var","Uyarı");
            }
            comboMarka.Items.Clear();
            foreach(Control item in groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text=="")
            {
                lblMiktar.Text = "";
                foreach(Control item in groupBox2.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.DataRead("select *from Ürün where barkodno like '" + BarkodNotxt.Text + "'");
           
            while (SqlBaglanti.read.Read())
            {
                Kategoritxt.Text = SqlBaglanti.read["kategori"].ToString();
                Markatxt.Text = SqlBaglanti.read["marka"].ToString();
                ÜrünAdıtxt.Text = SqlBaglanti.read["urunadi"].ToString();
                lblMiktar.Text = SqlBaglanti.read["miktari"].ToString();
                AlışFiyatıtxt.Text = SqlBaglanti.read["alisfiyati"].ToString();
                SatışFiyatıtxt.Text = SqlBaglanti.read["satisfiyati"].ToString();
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==false)
            {
                baglanti.SqlComm("update Ürün set miktari=miktari+'" + int.Parse(Miktartxt.Text) + "' where barkodno='" + BarkodNotxt.Text + "'");
                SqlBaglanti.comm.ExecuteNonQuery();

                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            MessageBox.Show("Varolan Ürüne Ekleme Yapıldı");
        }

        private void btnÜrünGöster_Click(object sender, EventArgs e)
        {
            frmÜrünListele göster = new frmÜrünListele();
            göster.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmÜrünEkle.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        string resimyolu;
        private void btnResimSeç_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpeg Dosyaları|*.jpg|*.jpeg|*.png";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                
                resimyolu = openFileDialog1.FileName;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(resimyolu, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();           
            baglanti.SqlComm("insert into ÜrünResimler (BarkodNo,Resim) values (@barkodno,@resim)");
            SqlBaglanti.comm.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
            SqlBaglanti.comm.Parameters.Add("@resim",SqlDbType.Image,resim.Length).Value=resim;
            SqlBaglanti.comm.ExecuteNonQuery();
            if (SqlBaglanti.comm.ExecuteNonQuery()>0)
            {
                MessageBox.Show("Resim Eklendi");
            }
            else
            {
                MessageBox.Show("Resim Eklenemedi");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBarkodOkut barcode = new frmBarkodOkut();
            barcode.Show();
        }

        private void btnBarcodeOluştur_Click(object sender, EventArgs e)
        {
            frmBarkodOluştur barcode = new frmBarkodOluştur();
            barcode.ShowDialog();
        
        }
    }
}
