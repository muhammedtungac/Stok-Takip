using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class frmSatınAlma : Form
    {
        public frmSatınAlma()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();

        private void frmSatınAlma_Load(object sender, EventArgs e)
        {
            TabloyuGetir();
        }

        private void TabloyuGetir()
        {
            baglanti.SqlComm("select * from SatınAlma");
            dataGridView1.DataSource = baglanti.TableTemizle("select * from Table");
        }
        public bool boşkontrol;
        public bool ekledurum;
        public bool güncelledurum;
        public int verisayisi;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.SqlComm("select count(*) from SatınAlma");
            verisayisi = int.Parse(SqlBaglanti.comm.ExecuteScalar().ToString());
            Kontrol();
            if (verisayisi == 0 && boşkontrol == false)
            {
                baglanti.SqlComm("insert into SatınAlma (MusteriNo,AdSoyad,Telefon,AlisNo,UrunAdi,Miktari,AlisFiyati,Toplam,Tarih) values (@MusteriNo,@AdSoyad,@Telefon,@AlisNo,@UrunAdi,@Miktari,@AlisFiyati,@Toplam,@Tarih)");
                SqlBaglanti.comm.Parameters.AddWithValue("@MusteriNo", txtMüşteriNo.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@AlisNo", txtAlışNo.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@UrunAdi", txtÜrünAdı.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@Miktari", int.Parse(txtMiktarı.Text));
                SqlBaglanti.comm.Parameters.AddWithValue("@AlisFiyati", double.Parse(txtAlışFiyatı.Text));
                SqlBaglanti.comm.Parameters.AddWithValue("@Toplam", (double.Parse(txtAlışFiyatı.Text) * double.Parse(txtMiktarı.Text)));
                SqlBaglanti.comm.Parameters.AddWithValue("@Tarih", DateTime.Now);
                SqlBaglanti.comm.ExecuteNonQuery();
            }
            else if (verisayisi > 0 && boşkontrol == false && ekledurum == true)
            {
                baglanti.SqlComm("insert into SatınAlma (MusteriNo,AdSoyad,Telefon,AlisNo,UrunAdi,Miktari,AlisFiyati,Toplam,Tarih) values (@MusteriNo,@AdSoyad,@Telefon,@AlisNo,@UrunAdi,@Miktari,@AlisFiyati,@Toplam,@Tarih)");
                SqlBaglanti.comm.Parameters.AddWithValue("@MusteriNo", txtMüşteriNo.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@AlisNo", txtAlışNo.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@UrunAdi", txtÜrünAdı.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@Miktari", int.Parse(txtMiktarı.Text));
                SqlBaglanti.comm.Parameters.AddWithValue("@AlisFiyati", double.Parse(txtAlışFiyatı.Text));
                SqlBaglanti.comm.Parameters.AddWithValue("@Toplam", (double.Parse(txtAlışFiyatı.Text) * double.Parse(txtMiktarı.Text)));
                SqlBaglanti.comm.Parameters.AddWithValue("@Tarih", DateTime.Now);
                SqlBaglanti.comm.ExecuteNonQuery();
            }
            else if (verisayisi > 0 && boşkontrol == false && güncelledurum == true)
            {
                baglanti.SqlComm("update SatınAlma set Miktari+='"+int.Parse(txtMiktarı.Text)+"' where AlisNo='"+txtAlışNo.Text+"' and UrunAdi='"+txtÜrünAdı.Text+"'");    
                SqlBaglanti.comm.ExecuteNonQuery();
                baglanti.SqlComm("update SatınAlma set Toplam=Miktari*AlisFiyati where AlisNo='" + txtAlışNo.Text + "' and UrunAdi='" + txtÜrünAdı.Text + "' and AlisNo='" + txtAlışFiyatı.Text + "'");
                SqlBaglanti.comm.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Boş Değer Girilemez");
            }
            Hesapla();
            Goster();
        }
        private void Hesapla()
        {
            baglanti.SqlComm("select sum(Toplam) from SatınAlma");
            txtToplamTutar.Text = SqlBaglanti.comm.ExecuteScalar().ToString();
        }
        private void Goster()
        {
            baglanti.SqlComm("select * from SatınAlma where AlisNo='"+txtAlışNo.Text+"'");
            dataGridView1.DataSource = baglanti.SqlTable("select * from SatınAlma where AlisNo='" + txtAlışNo.Text + "'");
        }
        private void Kontrol()
        {
            boşkontrol = false;
            if ( txtAlışFiyatı.Text=="" || txtAlışNo.Text == "" || txtÜrünAdı.Text == "" || txtToplam.Text == "" || txtMiktarı.Text == "" )
            {
                boşkontrol = true;
            }

            if (boşkontrol==false)
            {
                if (verisayisi==0)
                {
                    ekledurum = true;
                }
                 if (verisayisi>0 )
                {
                    baglanti.DataRead("select * from SatınAlma");
                    while (SqlBaglanti.read.Read())
                    {
                        if(txtÜrünAdı.Text==SqlBaglanti.read["UrunAdi"].ToString())
                        {
                            güncelledurum = true;
                        }
                        else
                        {
                            ekledurum = true;
                        }
                    }
                }             
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMüşteriNo.Text = dataGridView1.CurrentRow.Cells["MusteriNo"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtAlışNo.Text = dataGridView1.CurrentRow.Cells["AlisNo"].Value.ToString();
            txtÜrünAdı.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            txtMiktarı.Text = dataGridView1.CurrentRow.Cells["Miktari"].Value.ToString();
            txtAlışFiyatı.Text = dataGridView1.CurrentRow.Cells["AlisFiyati"].Value.ToString();
            txtToplam.Text = dataGridView1.CurrentRow.Cells["Toplam"].Value.ToString();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.SqlComm("delete from SatınAlma where UrunAdi='" + dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString() + "' and AlisNo='"+dataGridView1.CurrentRow.Cells["AlisNo"].Value.ToString()+ "'and AlisFiyati='" +double.Parse(txtAlışFiyatı.Text)+ "'");
            SqlBaglanti.comm.ExecuteNonQuery();
            Hesapla();
            Goster();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.SqlComm("update SatınAlma set (MusteriNo,AdSoyad,Telefon,AlisNo,UrunAdi,Miktari,AlisFiyati,Toplam,Tarih) values (@MusteriNo,@MusteriAdi,@Telefon,@AlisNo,@UrunAdi,@Miktari,@AlisFiyati,@Toplam,@Tarih)");
            SqlBaglanti.comm.Parameters.AddWithValue("@MusteriNo", txtMüşteriNo.Text);
            SqlBaglanti.comm.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            SqlBaglanti.comm.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            SqlBaglanti.comm.Parameters.AddWithValue("@AlisNo", txtAlışNo.Text);
            SqlBaglanti.comm.Parameters.AddWithValue("@UrunAdi", txtÜrünAdı.Text);
            SqlBaglanti.comm.Parameters.AddWithValue("@Miktari", int.Parse(txtMiktarı.Text));
            SqlBaglanti.comm.Parameters.AddWithValue("@AlisFiyati", double.Parse(txtAlışFiyatı.Text));
            SqlBaglanti.comm.Parameters.AddWithValue("@Toplam", (double.Parse(txtAlışFiyatı.Text) * double.Parse(txtMiktarı.Text)));
            SqlBaglanti.comm.Parameters.AddWithValue("@Tarih", DateTime.Now);
            SqlBaglanti.comm.ExecuteNonQuery();
            Hesapla();
            Goster();
        }        
        private void txtAlışFiyatı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAlışFiyatı.Text=="")
                {
                    txtToplam.Text = "";
                }
                else
                {

                    txtToplam.Text = (double.Parse(txtAlışFiyatı.Text) * double.Parse(txtMiktarı.Text)).ToString() + "TL";

                }
            }
            catch (Exception)
            {

                
            }                            
        }

        private void txtAlışNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAlışNo.Text=="")
                {
                    txtToplamTutar.Text = "";
                    baglanti.SqlComm("select * from SatınAlma");
                    dataGridView1.DataSource = baglanti.TableTemizle("select * from SatınAlma");
                }
                else
                {
                    baglanti.SqlComm("select * from SatınAlma where AlisNo='" + txtAlışNo.Text + "'");
                    dataGridView1.DataSource = baglanti.SqlTable("select * from SatınAlma where AlisNo='" + txtAlışNo.Text + "'");
                    baglanti.SqlComm("select sum(Toplam) from SatınAlma where AlisNo='" + txtAlışNo.Text + "'");
                    txtToplamTutar.Text = SqlBaglanti.comm.ExecuteScalar() + "TL";
                }
            }            
            catch (Exception)
            {

                
            }
        }
    }
}
