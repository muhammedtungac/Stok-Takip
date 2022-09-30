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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        bool durum;
        SqlBaglanti baglanti = new SqlBaglanti();
        
        private void kategorikontrol()
        {
            durum = true;
            baglanti.SqlComm("select * from kategoribilgileri");
            
            
            
            while (SqlBaglanti.read.Read())
            {
                if(textBox1.Text== SqlBaglanti.read["kategori"].ToString() || textBox1.Text == "")
                {
                    durum = false;
                }
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            kategorikontrol();
            
            if (durum == true)
            {
                baglanti.SqlComm("insert into KategoriBilgileri(kategori) values ('" + textBox1.Text + "')");
                
                textBox1.Text = "";
                MessageBox.Show("Kategori Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir Kategori Var", "Uyarı");
            }
            textBox1.Text = "";
            
        }

        private void frmKategori_Load(object sender, EventArgs e)
        {
            //baglanti.SqlConn();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmKategori.ActiveForm.Close();
        }
    }
}
