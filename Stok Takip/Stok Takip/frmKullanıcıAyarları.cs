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
    public partial class frmKullanıcıAyarları : Form
    {
        public frmKullanıcıAyarları()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if(item is ComboBox)
                {
                    item.Text = "";
                }
                txtID.Text = txtMevcutID.Text;
            }

            if (groupBox2.Visible == false)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;                                
            }
        }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox1.Checked)
                {
                    txtEskiŞifre.PasswordChar = '\0';
                    txtYeniŞifre.PasswordChar = '\0';
                }
                else
                {
                    txtEskiŞifre.PasswordChar = '*';
                    txtYeniŞifre.PasswordChar = '*';
                }
            }

            private void panel1_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void frmKullanıcıAyarları_Load(object sender, EventArgs e)
        {
            
           
            
            groupBox2.Visible = false;
            
        }
        bool güncelle;
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            YeniŞifreKontrol();

            if (güncelle == true)
            {
               
                    baglanti.SqlComm("update Kullanıcı set Şifre='" + txtYeniŞifre.Text + "' where ID='" + txtID.Text + "' and Şifre='" + txtEskiŞifre.Text + "'");
                    SqlBaglanti.comm.ExecuteNonQuery();
                    MessageBox.Show("Şifreniz Değiştirildi");
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış girildi");
            }
            
            
        }

        private void YeniŞifreKontrol()
        {
            güncelle = false;
            baglanti.DataRead("select * from Kullanıcı");
            while (SqlBaglanti.read.Read())
            {
                if (txtID.Text == SqlBaglanti.read["ID"].ToString() && txtEskiŞifre.Text == SqlBaglanti.read["Şifre"].ToString() && comboMevcutSoru.SelectedItem.ToString() == SqlBaglanti.read["Soru"].ToString() && txtMevcutCevap.Text == SqlBaglanti.read["Cevap"].ToString())
                {
                    güncelle = true;
                    
                }
               
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmKullanıcıAyarları_Load_1(object sender, EventArgs e)
        {
            txtMevcutID.Text = SqlBaglanti.id;
            //txtMevcutŞifre.Text = SqlBaglanti.şifre;
        }
    }
}


