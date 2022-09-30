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
    public partial class frmKayıt : Form
    {
        SqlBaglanti baglanti = new SqlBaglanti();
        
        public frmKayıt()
        {
            InitializeComponent();
        }
        
        bool kullanıcıkontrol;
        bool textkontrol;
        private void KullanıcıKontrol()
        {
            kullanıcıkontrol = false;
            textkontrol = false;
            baglanti.DataRead("select * from Kullanıcı");
            while (SqlBaglanti.read.Read())
            {
                if (txtKullanıcıAdı.Text==SqlBaglanti.read["ID"].ToString())
                {  
                    kullanıcıkontrol = true;
                    
                }
                else if (txtKullanıcıAdı.Text=="" || txtŞifre.Text=="" || txtCevap.Text=="")
                {
                    textkontrol = true;
                }
            }
            
        }
        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            KullanıcıKontrol();

            
            if (kullanıcıkontrol == false && textkontrol==false)
            {
                if (txtŞifre.Text == txtŞifreTekrar.Text)
                {
                    baglanti.SqlComm("insert into Kullanıcı (ID,Şifre,Soru,Cevap) values (@ID,@Şifre,@Soru,@Cevap)");
                    
                    SqlBaglanti.comm.Parameters.AddWithValue("@ID", txtKullanıcıAdı.Text);
                    SqlBaglanti.comm.Parameters.AddWithValue("@Şifre", txtŞifre.Text);
                    SqlBaglanti.comm.Parameters.AddWithValue("@Soru", comboSoru.SelectedItem.ToString());
                    SqlBaglanti.comm.Parameters.AddWithValue("@Cevap", txtCevap.Text);
                    SqlBaglanti.comm.ExecuteNonQuery();                   
                    MessageBox.Show("Kayıt Yapıldı");
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Şifreler Birbiriyle Uyuşmuyor");
                }
            }
            else if(kullanıcıkontrol==true && textkontrol==false)
            {
                MessageBox.Show("Böyle Bir Kullanıcı Zaten Kayıtlı");
            }
            else
            {
                MessageBox.Show("Bir Değer Girin");
            }

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            comboSoru.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGiriş giriş = new frmGiriş();
            giriş.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtŞifre.PasswordChar = '\0';
                txtŞifreTekrar.PasswordChar = '\0';
            }
            else
            {
                txtŞifre.PasswordChar = '*';
                txtŞifreTekrar.PasswordChar = '*';
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmKayıt.ActiveForm.Close();
        }

        private void frmKayıt_Load(object sender, EventArgs e)
        {
            //baglanti.SqlConn();
        }
    }
}
