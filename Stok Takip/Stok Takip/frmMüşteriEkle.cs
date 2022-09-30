using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stok_Takip
{
    public partial class frmMüşteriEkle : Form
    {
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();

        private void frmMüşteriEkle_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Kontrol();
            if (boşdurum==false)
            {
                if (ekledurum == true)

                {
                    baglanti.SqlComm("insert into Müşteri(musterino,adsoyad,telefon,adres,email) values (@musterino,@adsoyad,@telefon,@adres,@email)");

                    SqlBaglanti.comm.Parameters.AddWithValue("@musterino", txtMüşteriNo.Text);
                    SqlBaglanti.comm.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                    SqlBaglanti.comm.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                    SqlBaglanti.comm.Parameters.AddWithValue("@adres", txtAdres.Text);
                    SqlBaglanti.comm.Parameters.AddWithValue("@email", txtEmail.Text);
                    SqlBaglanti.comm.ExecuteNonQuery();

                    MessageBox.Show("Müşteri Kaydı Eklendi");
                    foreach (Control İtem in this.Controls)
                    {
                        if (İtem is TextBox)
                        {
                            İtem.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bu Müşteri No zaten Mevcut");
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir Müşteri No Girin ");
            }
            
        }
        bool ekledurum;
        bool boşdurum;
        private void Kontrol()
        {
            ekledurum = true;
            boşdurum = false;
            baglanti.DataRead("select * from Müşteri");
            while (SqlBaglanti.read.Read())
            {
                if (txtMüşteriNo.Text!="" || txtAdSoyad.Text!=""|| txtTelefon.Text!=""|| txtEmail.Text!=""||txtAdres.Text!="")
                {
                    if (txtMüşteriNo.Text == SqlBaglanti.read["MusteriNo"].ToString())
                    {
                        ekledurum = false;
                    }
                }
                else
                {
                    boşdurum = true;
                }
                
               
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle.ActiveForm.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMüşteriListele frmMüşteri = new frmMüşteriListele();
            frmMüşteri.Show();
        }
    }
}
