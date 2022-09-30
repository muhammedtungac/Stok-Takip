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
    public partial class frmMüşteriListele : Form
    {
        public frmMüşteriListele()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            
            baglanti.SqlComm("update Müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where musterino=@musterino");
            SqlBaglanti.comm.Parameters.AddWithValue("@musterino", txtMüşteriNo.Text);
            SqlBaglanti.comm.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            SqlBaglanti.comm.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            SqlBaglanti.comm.Parameters.AddWithValue("@adres", txtAdres.Text);
            SqlBaglanti.comm.Parameters.AddWithValue("@email", txtEmail.Text);
            SqlBaglanti.comm.ExecuteNonQuery();
            Kayıt_Goster();
            MessageBox.Show("Müşteri Kaydı Güncellendi");
            foreach (Control İtem in this.Controls)
            {
                if (İtem is TextBox)
                {
                    İtem.Text = "";
                }
            }
        }
      
            private void frmMüşteriListele_Load(object sender, EventArgs e)
        {
            //baglanti.SqlConn();
            Kayıt_Goster();
        }

        private void Kayıt_Goster()
        {
            
            baglanti.SqlComm("select * from Müşteri");
            dataGridView1.DataSource = baglanti.SqlTable("select * from Müşteri");
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMüşteriNo.Text = dataGridView1.CurrentRow.Cells["musterino"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            
            baglanti.SqlComm("select *from Müşteri where MusteriNo like '%" + txtMüşteriNoAra.Text + "%'");
            dataGridView1.DataSource = baglanti.SqlTable("select *from Müşteri where MusteriNo like '%" + txtMüşteriNoAra.Text + "%'");
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.SqlComm("delete from Müşteri where MusteriNo = '" + dataGridView1.CurrentRow.Cells["MusteriNo"].Value.ToString() + "'");

            SqlBaglanti.comm.ExecuteNonQuery();


            Kayıt_Goster();
            MessageBox.Show("Kayıt Silindi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmMüşteriListele.ActiveForm.Close();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
