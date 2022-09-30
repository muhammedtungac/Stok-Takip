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
    public partial class frmÜrünListele : Form
    {
        public frmÜrünListele()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        
        private void KategoriGetir()
        {
            baglanti.DataRead("select *from kategoribilgileri");
          
            while (SqlBaglanti.read.Read())
            {
                comboKategori.Items.Add(SqlBaglanti.read["kategori"].ToString());
            }
            
        }
        private void frmÜrünListele_Load(object sender, EventArgs e)
        {
            KategoriGetir();
            ÜrünListele();
            
        }

        private void ÜrünListele()
        {
            
            baglanti.SqlComm("select * from Ürün"); 
            dataGridView1.DataSource = baglanti.SqlTable("select * from Ürün");
            
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            ÜrünAdıtxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            Miktartxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            AlışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            SatışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.SqlComm("update Ürün set urunadi=@urunadi,miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno");
            SqlBaglanti.comm.Parameters.AddWithValue("@barkodno",BarkodNotxt.Text);
            SqlBaglanti.comm.Parameters.AddWithValue("@urunadi", ÜrünAdıtxt.Text);
            SqlBaglanti.comm.Parameters.AddWithValue("@miktari", int.Parse(Miktartxt.Text));
            SqlBaglanti.comm.Parameters.AddWithValue("@alisfiyati", double.Parse(AlışFiyatıtxt.Text));
            SqlBaglanti.comm.Parameters.AddWithValue("@satisfiyati", double.Parse(SatışFiyatıtxt.Text));
            SqlBaglanti.comm.ExecuteNonQuery();
           
            
            ÜrünListele();
            MessageBox.Show("Güncelleme Yapıldı");           
            foreach (Control item in this.Controls)
            {
                if (this.Controls is TextBox)
                { 
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGüncelle_Click(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text != "")
            {
                baglanti.SqlComm("update Ürün set kategori=@kategori,marka=@marka where barkodno=@barkodno");
                
                SqlBaglanti.comm.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@kategori", comboKategori.Text);
                SqlBaglanti.comm.Parameters.AddWithValue("@marka", comboMarka.Text);
                SqlBaglanti.comm.ExecuteNonQuery();
                
                ÜrünListele();
                MessageBox.Show("Güncelleme Yapıldı");

            }
            else
            {
                MessageBox.Show("BarkodNo Yazılı Değil");
            }

            foreach (Control item in this.Controls)
                {
                    if (this.Controls is ComboBox)
                    {
                        item.Text = "";
                    }
                    
                }
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.SqlComm("delete from Ürün where barkodno = '" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'");
            
            SqlBaglanti.comm.ExecuteNonQuery();
            
            
            ÜrünListele();
            MessageBox.Show("Kayıt Silindi");
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            
            baglanti.SqlComm("select *from Ürün where barkodno like '%" + txtBarkodNoAra.Text + "%'");
            dataGridView1.DataSource = baglanti.SqlTable("select *from Ürün where barkodno like '%" + txtBarkodNoAra.Text + "%'");
            
            

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmÜrünListele.ActiveForm.Close();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            ÜrünAdıtxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            Miktartxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            AlışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            SatışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();

        }
    }
    }

