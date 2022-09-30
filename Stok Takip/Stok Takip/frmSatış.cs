using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class frmSatış : Form
    {
        public frmSatış()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
      
        
        private void SepetListele()
        {
            baglanti.SqlComm("select *from Sepet where SatisKodu='"+txtSatışKodu.Text+"'");          
            dataGridView1.DataSource = baglanti.SqlTable("select *from Sepet where SatisKodu='" + txtSatışKodu.Text + "'");
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
 
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Hesapla()
        {
            baglanti.SqlComm("select sum(toplamfiyati) from Sepet ");
            txtGenelToplam.Text = SqlBaglanti.comm.ExecuteScalar()+"TL";
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle();
            ekle.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMüşteriListele listele = new frmMüşteriListele();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void FormSatis_Load(object sender, EventArgs e)
        {
            //baglanti.SqlConn();
            //txtBarkodNo.Text = "";
            VeriSayısı();
            SatışGetir();
            SepetListele();
        }

        private void VeriSayısı()
        {
            baglanti.SqlComm("select count(*) from Sepet");
            verisayisi = SqlBaglanti.comm.ExecuteScalar().ToString();
            label12.Text = verisayisi;
        }
        /*private void SepetÜrünVeriSayısı()
        {
            baglanti.SqlComm("select count(*) from Sepet");
            sepetverisayisi = SqlBaglanti.comm.ExecuteScalar().ToString();
            label12.Text = verisayisi;
        }*/

        private void SatışGetir()
        {
            baglanti.DataRead("select * from Satış");
            while (SqlBaglanti.read.Read())
            {
                if(SqlBaglanti.read["SatisKodu"].ToString()!=null)
                    comboBox1.Items.Add(SqlBaglanti.read["SatisKodu"].ToString());
                int satışkodu = 1 + int.Parse(SqlBaglanti.read["SatisKodu"].ToString());
                txtSatışKodu.Text = satışkodu.ToString();
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmÜrünListele frm = new frmÜrünListele();
            frm.ShowDialog();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtMüşteriNo.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.DataRead("select * from Müşteri where MusteriNo like '" + txtMüşteriNo.Text + "'");
            
           
            while (SqlBaglanti.read.Read())
            {
                txtAdSoyad.Text = SqlBaglanti.read["adsoyad"].ToString();
                txtTelefon.Text = SqlBaglanti.read["telefon"].ToString();
            }
            
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.DataRead("select * from Ürün where barkodno like '" + txtBarkodNo.Text + "'");
            
            while (SqlBaglanti.read.Read())
            {
                txtÜrünAdı.Text = SqlBaglanti.read["urunadi"].ToString();
                txtSatışFiyatı.Text = SqlBaglanti.read["satisfiyati"].ToString();
            }
           

        }

        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktarı)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }
      
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
           
            Kontrol();

            if (ekledurum == true && miktardurum == true && boşkontrol == false)
            {
                baglanti.SqlComm("insert into Sepet(SatisKodu,MusteriNo,AdSoyad,Telefon,Barkodno,UrunAdi,Miktari,SatisFiyati,ToplamFiyati,Tarih) values (@satiskodu,@musterino,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)");
                SqlBaglanti.comm.Parameters.AddWithValue("@satiskodu", txtSatışKodu.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@musterino", txtMüşteriNo.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@miktari", int.Parse(txtMiktarı.Text));
                SqlBaglanti.comm.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text));
                SqlBaglanti.comm.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyat.Text));
                SqlBaglanti.comm.Parameters.AddWithValue("@tarih", DateTime.Now);
                SqlBaglanti.comm.ExecuteNonQuery();
            }         
            else if (güncelledurum == true && miktardurum == true && boşkontrol == false)
            {
                baglanti.SqlComm("update Sepet set Miktari=Miktari+ '" + int.Parse(txtMiktarı.Text) + "' where BarkodNo='" + txtBarkodNo.Text + "'");
                SqlBaglanti.comm.ExecuteNonQuery();
                baglanti.SqlComm("update Sepet set ToplamFiyati=Miktari*SatisFiyati where BarkodNo = '" + txtBarkodNo.Text + "'");
                SqlBaglanti.comm.ExecuteNonQuery();
            }           
            else if (miktardurum==false && boşkontrol == false)
            {
                MessageBox.Show("Stokta Yeterli Ürün Bulunmuyor ");
            }
            else if (boşkontrol==true)
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            VeriSayısı();
            SepetListele();
            Hesapla();
           
        }
        public static bool ekledurum;
        public static bool güncelledurum;
        public static bool miktardurum;
        public static int miktar;
        public static string verisayisi;
        public static int sepetverisayisi;
        public static bool boşkontrol;
        public static int sepetmiktarı;

        public void Kontrol()
        {
            VeriSayısı();
            ekledurum = false;
            güncelledurum = false;
            miktardurum = false;
            boşkontrol = false;
            
            if (txtSatışKodu.Text == "" || txtBarkodNo.Text == "" || txtÜrünAdı.Text == "" || txtMiktarı.Text == "")
            {
                boşkontrol = true;
            }
            else if (txtMiktarı.Text == "0")
            {
                boşkontrol = true;
            }
            else
            {
                sepetmiktarı = 0;
                if (int.Parse(verisayisi) == 0)
                {
                    
                    baglanti.SqlComm("select Miktari from Ürün where BarkodNo='" + txtBarkodNo.Text + "'");
                    miktar = int.Parse(SqlBaglanti.comm.ExecuteScalar().ToString());
                    
                    if (int.Parse(txtMiktarı.Text) <= miktar)
                    {
                        ekledurum = true;
                        miktardurum = true;
                    }
                }
                else if (int.Parse(verisayisi) > 0)
                {
                    baglanti.SqlComm("select Miktari from Ürün where BarkodNo='" + txtBarkodNo.Text + "'");
                    miktar = int.Parse(SqlBaglanti.comm.ExecuteScalar().ToString());
                    baglanti.SqlComm("select count(Miktari) from Sepet where BarkodNo='" + txtBarkodNo.Text + "'");
                    sepetmiktarı = int.Parse(SqlBaglanti.comm.ExecuteScalar().ToString());
                    baglanti.DataRead("select * from Sepet");             
                    while (SqlBaglanti.read.Read())
                    {
                        
                        if (sepetmiktarı == 0 && SqlBaglanti.read["SatisKodu"].ToString() == txtSatışKodu.Text && SqlBaglanti.read["BarkodNo"].ToString() != txtBarkodNo.Text)
                        {
                            
                            if (sepetmiktarı + int.Parse(txtMiktarı.Text) <= miktar)
                            {
                                ekledurum = true;
                                miktardurum = true;
                            }
                        }
                        else if (txtSatışKodu.Text == SqlBaglanti.read["SatisKodu"].ToString() && SqlBaglanti.read["BarkodNo"].ToString() == txtBarkodNo.Text)
                        {
                            baglanti.SqlComm("select Miktari from Sepet where BarkodNo='" + txtBarkodNo.Text + "'");
                            sepetverisayisi = int.Parse(SqlBaglanti.comm.ExecuteScalar().ToString());
                            if (sepetverisayisi + int.Parse(txtMiktarı.Text) <= miktar)
                            {
                                güncelledurum = true;
                                miktardurum = true;
                            }
                        }
                    }
                    
                }
          
        
                
                
            } 
                         
        }

        private void txtMiktarı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktarı.Text) * double.Parse(txtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtSatışFiyatı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktarı.Text) * double.Parse(txtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.SqlComm("delete from Sepet where barkodno= '" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'");
            
            SqlBaglanti.comm.ExecuteNonQuery();
            SepetListele();
            MessageBox.Show("Ürün Silindi");
            Hesapla();
            VeriSayısı();
        }

        private void btnSatışİptal_Click(object sender, EventArgs e)
        {
            baglanti.SqlComm("delete from Sepet");
            
            SqlBaglanti.comm.ExecuteNonQuery();
            
            MessageBox.Show("Ürünler Silindi");
           
            SepetListele();
            Hesapla();
            VeriSayısı();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSatışListele listele = new frmSatışListele();
            listele.ShowDialog();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                baglanti.SqlComm("insert into Satış(SatisKodu,MusteriNo,AdSoyad,Telefon,BarkodNo,UrunAdi,Miktari,SatisFiyati,ToplamFiyati,Tarih) values(@satiskodu,@musterino,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)");

                SqlBaglanti.comm.Parameters.AddWithValue("@satiskodu", txtSatışKodu.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@musterino", txtMüşteriNo.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                SqlBaglanti.comm.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["UrunAdi"].Value.ToString());
                SqlBaglanti.comm.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["Miktari"].Value.ToString()));
                SqlBaglanti.comm.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["SatisFiyati"].Value.ToString()));
                SqlBaglanti.comm.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyati"].Value.ToString()));
                SqlBaglanti.comm.Parameters.AddWithValue("@tarih", DateTime.Now);
                SqlBaglanti.comm.ExecuteNonQuery();
                baglanti.SqlComm("update Ürün set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno='" + int.Parse(dataGridView1.Rows[i].Cells["barkodno"].Value.ToString()) + "'");              
                SqlBaglanti.comm.ExecuteNonQuery();
            }
            MessageBox.Show("Satış Yapıldı");
            baglanti.SqlComm("delete from Sepet ");           
            SqlBaglanti.comm.ExecuteNonQuery();            
            SepetListele();
            SatışGetir();
            Hesapla();
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünÖnMaliyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void önMaliyetHesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÖnMaliyet göster = new frmÖnMaliyet();
            göster.ShowDialog();
        }

        private void önMaliyetleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÖnMaliyetListele göster = new frmÖnMaliyetListele();
            göster.ShowDialog();
        }

        private void txtGenelToplam_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //baglanti.SqlComm("delete from Sepet");
            //SqlBaglanti.comm.ExecuteNonQuery();
            frmSatış.ActiveForm.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullanıcıBilgileriniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullanıcıAyarları ayar = new frmKullanıcıAyarları();
            ayar.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmBarkodOkut barkodOkut = new frmBarkodOkut();
            barkodOkut.Show();
        }

        private void satınAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSatınAlma satınAlma = new frmSatınAlma();
            satınAlma.ShowDialog();
        }

        private void txtToplamFiyat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
