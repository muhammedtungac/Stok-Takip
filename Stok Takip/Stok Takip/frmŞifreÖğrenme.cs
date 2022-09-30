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
    public partial class frmŞifreÖğrenme : Form
    {
        public frmŞifreÖğrenme()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        bool şifrekontrol;
        bool textkontrol;
        private void ŞifreKontrol()
        {
            şifrekontrol = true;
            textkontrol = true;
            baglanti.DataRead("select* from Kullanıcı");
            
            while (SqlBaglanti.read.Read())
            {
                if (txtKullanıcıAdı.Text == SqlBaglanti.read["ID"].ToString() && comboSoru.SelectedItem.ToString() == SqlBaglanti.read["Soru"].ToString() && txtCevap.Text == SqlBaglanti.read["Cevap"].ToString())
                {
                    şifrekontrol = false;
                    txtŞifreGetir.Text = SqlBaglanti.read["Şifre"].ToString();
                }
                else if (txtKullanıcıAdı.Text == "" || comboSoru.SelectedItem.ToString() == "" || txtCevap.Text=="")
                {
                    textkontrol = false;
                }
                
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ŞifreKontrol();
            if (şifrekontrol==false && textkontrol==true)
            {
                MessageBox.Show("Şifreniz = " +txtŞifreGetir.Text + "  " + "                                                                                Bir Yere Yazın veya Kaydedin ki Bir daha Unutmayın :)");
                txtKullanıcıAdı.Text = "";
                txtCevap.Text = "";
                comboSoru.Text = "";
            }
            else if(şifrekontrol=true && textkontrol== false)
            {
                MessageBox.Show("Geçerli bir Değer Girin");
            }
            else
            {
                MessageBox.Show("Tekrar Deneyin");
            }
            
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmŞifreÖğrenme.ActiveForm.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmŞifreÖğrenme_Load(object sender, EventArgs e)
        {
            //baglanti.SqlConn();
        }
    }
}
