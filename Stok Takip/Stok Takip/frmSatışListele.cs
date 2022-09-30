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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace Stok_Takip
{
    public partial class frmSatışListele : Form
    {
        public frmSatışListele()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        string satışkontrol;
        string toplamsatış;
        string toplammiktar;
        public static string tabloadı = "select * from Satış where Tarih between '";
        
        private void frmSatışListele_Load(object sender, EventArgs e)
        {
            //baglanti.SqlConn();
            baglanti.DataRead("select * from Satış");
            SatışKoduGetir();
            SatışListele();
            baglanti.SqlComm("select sum(Miktari) from Satış");
            toplammiktar = SqlBaglanti.comm.ExecuteScalar().ToString();
            txtAdetler.Text = toplammiktar;
            baglanti.SqlComm("select sum(ToplamFiyati) from Satış ");
            toplamsatış = SqlBaglanti.comm.ExecuteScalar().ToString();
            txtTümSatış.Text = toplamsatış;
        }

        private void SatışKoduGetir()
        {
            while (SqlBaglanti.read.Read())
            {
                if (satışkontrol != SqlBaglanti.read["SatisKodu"].ToString())
                {
                    comboSatışKodu.Items.Add(SqlBaglanti.read["SatisKodu"].ToString());
                }

            }
        }

        private void SatışListele()
        {
            baglanti.SqlComm("select *from Satış");
            dataGridView1.DataSource = baglanti.SqlTable("select *from Satış");
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;


        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();


                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmSatışListele.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboSatışKodu.SelectedItem != null)
            {
                baglanti.SqlComm("select * from Satış where SatisKodu='" + comboSatışKodu.SelectedItem.ToString() + "'");
                dataGridView1.DataSource = baglanti.SqlTable("select * from Satış where SatisKodu='" + comboSatışKodu.SelectedItem.ToString() + "'");
                baglanti.SqlComm("select sum(Miktari) from Satış where SatisKodu='" + comboSatışKodu.SelectedItem + "'");
                toplammiktar = SqlBaglanti.comm.ExecuteScalar().ToString();
                txtAdetler.Text = toplammiktar;
                baglanti.SqlComm("select sum(ToplamFiyati) from Satış where SatisKodu='" + comboSatışKodu.SelectedItem + "'");
                toplamsatış = SqlBaglanti.comm.ExecuteScalar().ToString();
                txtTümSatış.Text = toplamsatış;
            }
            else
            {
                MessageBox.Show("Değer Giriniz");
            }
            
            }

        private void hücreyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.PDF_Disa_Aktar(dataGridView1);
        }

        private void tariheGöreFiltreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlBaglanti.filtreadres=tabloadı;
            frmFiltre filtre = new frmFiltre();
            filtre.Show();
        }
        public static string filtre;
        public void FiltreleGöster()
        {
            baglanti.SqlComm(filtre);
            dataGridView1.DataSource = baglanti.SqlTable(filtre);
        }
    }
}
