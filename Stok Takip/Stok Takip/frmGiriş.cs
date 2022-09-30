using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class frmGiriş : Form
    {
        public static string id;
        public static string şifre;

        frmKullanıcıAyarları kayarları = new frmKullanıcıAyarları();
        
        public frmGiriş()
        {
            InitializeComponent();
            


        }
        //SqlConnection baglanti = new SqlConnection("Data Source=Muhammed;Initial Catalog=Stok_Takip;Integrated Security=True");
        
        bool yetkiver;
        bool onaykontrol;
        bool textkontrol;
        bool boşkontrol;
        bool adminkontrol;
        bool user1kontrol;
        bool user2kontrol;
        bool user3kontrol;
        string admin = "0";
        string user1 = "1";
        string user2 = "2";
        string user3 = "3";
        string boş = "";


        SqlBaglanti baglanti = new SqlBaglanti();
        
        

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            frmKayıt kayıt = new frmKayıt();
            kayıt.ShowDialog();
        }

        private void lblŞifre_Click(object sender, EventArgs e)
        {
            frmŞifreÖğrenme şifre = new frmŞifreÖğrenme();
            şifre.ShowDialog();
        }

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            

            Kontrol();
            if (onaykontrol==false && yetkiver == true)
            {
                MessageBox.Show("Admin Tarafından Henüz Erişim Yetkisi Verilmedi");
            }
            else if (textkontrol == false && boşkontrol == true && adminkontrol== false && yetkiver == false && onaykontrol==true)
            {
                frmAnasayfa anasayfa = new frmAnasayfa();
                frmKullanıcıAyarları ayar = new frmKullanıcıAyarları();
                SqlBaglanti.id = txtKullanıcıAdı.Text;
                SqlBaglanti.şifre = txtŞifre.Text;
                //ayar.txtID.Text = txtKullanıcıAdı.Text;
                //ayar.txtŞifre.Text = txtŞifre.Text;
                //anasayfa.lblID.Text = txtKullanıcıAdı.Text;
                //anasayfa.lblŞifre.Text = txtŞifre.Text;
                //anasayfa.id = txtKullanıcıAdı.Text;
                //anasayfa.şifre = txtŞifre.Text;
                
                //MessageBox.Show("Hoş Geldin " + txtKullanıcıAdı.Text);
                anasayfa.ShowDialog();
                

                //frmGiriş.ActiveForm.Close();
            }
            else if (textkontrol == false && boşkontrol == true && user1kontrol==false && yetkiver == false && onaykontrol == true)
            {
                SqlBaglanti.id = txtKullanıcıAdı.Text;
                SqlBaglanti.şifre = txtŞifre.Text;
                frmSatış satış = new frmSatış();
                satış.ShowDialog();
                //MessageBox.Show("Hoş Geldin " + txtKullanıcıAdı.Text);

                //frmGiriş.ActiveForm.Close();
                
            }
            else if (textkontrol == false && boşkontrol == true && user2kontrol == false && yetkiver == false && onaykontrol == true)
            {
                frmÖnMaliyet ömaliyet = new frmÖnMaliyet();
                ömaliyet.ShowDialog();
                //MessageBox.Show("Hoş Geldin " + txtKullanıcıAdı.Text);

                //frmGiriş.ActiveForm.Close();
                
            }
            else if (textkontrol == false && boşkontrol == true && user3kontrol == false && yetkiver == false && onaykontrol == true)
            {
                frmÜrünListele ülistele = new frmÜrünListele();
                ülistele.ShowDialog();
                //MessageBox.Show("Hoş Geldin " + txtKullanıcıAdı.Text);

                //frmGiriş.ActiveForm.Close();
                
            }
            else if (boşkontrol == false)
            {
                MessageBox.Show("Geçerli bir Değer ile Tekrar Deneyin");
                
                txtŞifre.Text = "";
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız veya Şifreniz Yanlış");
                
                txtŞifre.Text = "";
                
            }
            
        }

        private void Kontrol()
        {            
            yetkiver = true;
            onaykontrol = true;
            textkontrol = true;
            boşkontrol = true;
            adminkontrol = true;
            user1kontrol = true;
            user2kontrol = true;
            user3kontrol = true;
            
            baglanti.DataRead("select * from Kullanıcı");           
            while (SqlBaglanti.read.Read())
            {
                if (txtKullanıcıAdı.Text == SqlBaglanti.read["ID"].ToString() && txtŞifre.Text == SqlBaglanti.read["Şifre"].ToString() && admin == SqlBaglanti.read["Yetki"].ToString())
                {
                    
                    textkontrol =false;
                    adminkontrol = false;
                    yetkiver = false;
                    
                }
                else if (txtKullanıcıAdı.Text == SqlBaglanti.read["ID"].ToString() && txtŞifre.Text == SqlBaglanti.read["Şifre"].ToString() && user1 == SqlBaglanti.read["Yetki"].ToString())
                {
                    textkontrol = false;
                    user1kontrol = false;
                    yetkiver = false;
                    
                }
                else if (txtKullanıcıAdı.Text == SqlBaglanti.read["ID"].ToString() && txtŞifre.Text == SqlBaglanti.read["Şifre"].ToString() && user2 == SqlBaglanti.read["Yetki"].ToString())
                {
                    textkontrol = false;
                    user2kontrol = false;
                    yetkiver = false;
                   
                }
                else if (txtKullanıcıAdı.Text == SqlBaglanti.read["ID"].ToString() && txtŞifre.Text == SqlBaglanti.read["Şifre"].ToString() && user3 == SqlBaglanti.read["Yetki"].ToString())
                {
                    textkontrol = false;
                    user3kontrol = false;
                    yetkiver = false;       
                }
                
                else if (txtKullanıcıAdı.Text == "" || txtŞifre.Text == "")
                {
                    boşkontrol = false;
                }

                else if(txtKullanıcıAdı.Text == SqlBaglanti.read["ID"].ToString() && txtŞifre.Text == SqlBaglanti.read["Şifre"].ToString() && boş == SqlBaglanti.read["Yetki"].ToString())
                {
                    onaykontrol = false;
                    yetkiver = true;
                }
                /*/else
                {
                    MessageBox.Show("Kullanıcı Adınız veya Şifreniz Yanlış");
                }/*/                
            }                      
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void frmGiriş_Load(object sender, EventArgs e)
        {
            baglanti.SqlConn();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtŞifre.PasswordChar = '\0';
            }
            else
            {
                txtŞifre.PasswordChar = '*';
            }
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            SqlBaglanti.conn.Close();
            frmGiriş.ActiveForm.Close();
        }
    }
}
