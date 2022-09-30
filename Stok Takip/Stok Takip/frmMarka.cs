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
    public partial class frmMarka : Form
    {
       
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        
        DataSet daset = new DataSet();
        bool durum;
        private void Markakontrol()
        {
            durum = true;
            baglanti.DataRead("select * from markabilgileri");
            
            while (SqlBaglanti.read.Read())
            {
                if (comboBox1.Text == SqlBaglanti.read["kategori"].ToString() && textBox1.Text == SqlBaglanti.read["marka"].ToString() || comboBox1.Text == "" || textBox1.Text == "")
                {
                    durum = false;
                }
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Markakontrol();
            if (durum == true)
            {
                baglanti.SqlComm("insert into MarkaBilgileri(kategori,marka) values ('" + comboBox1.Text + "','" + textBox1.Text + "')");             
                SqlBaglanti.comm.ExecuteNonQuery();
                textBox1.Text = "";
                comboBox1.Text = "";
                MessageBox.Show("Marka Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir Kategori ve Marka Var ", "Uyarı");
            }

        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            //baglanti.SqlConn();
            KategoriGetir();


        }


        private void KategoriGetir()
        {
            baglanti.DataRead("select *from kategoribilgileri");
            
            while (SqlBaglanti.read.Read())
            {
                comboBox1.Items.Add(SqlBaglanti.read["kategori"].ToString());
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmMarka.ActiveForm.Close();
        }
    }
}
    
    

