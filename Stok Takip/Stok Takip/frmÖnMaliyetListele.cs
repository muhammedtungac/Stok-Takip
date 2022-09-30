using Microsoft.Office.Interop.Excel;
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
    public partial class frmÖnMaliyetListele : Form
    {
        public frmÖnMaliyetListele()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();  
        bool durum;
        private void frmÖnMaliyetListele_Load(object sender, EventArgs e)
        {
            
            ÜrünGetir();

        }


        string belirleme;
        string place;
        
        private void ÜrünGetir()
        {
            baglanti.SqlComm("select Count(*) from ÖnMaliyet");
            string verisayisi = SqlBaglanti.comm.ExecuteScalar().ToString();  
            string[] kontrol=new string[int.Parse(verisayisi)];
            int i = 0;
            baglanti.DataRead("select * from ÖnMaliyet");
            while (SqlBaglanti.read.Read() && i < kontrol.Length)
            {
                kontrol[i] = "";
                kontrol[i] = SqlBaglanti.read["UrunNo"].ToString();
                i++;               
            }                      
            baglanti.DataRead("select * from ÖnMaliyet");
            i = 0;
            while (SqlBaglanti.read.Read() && i < kontrol.Length)
            {
                if (kontrol[i]==SqlBaglanti.read["UrunNo"].ToString() && kontrol[i]!="")
                {
                    comboÜrün.Items.Add(SqlBaglanti.read["UrunNo"].ToString());
                    for (int c = 0; c < kontrol.Length; c++)
                    {
                        if (kontrol[c]==SqlBaglanti.read["UrunNo"].ToString())
                        {
                            kontrol[c] = "";
                        }
                        
                    }
                }
                i++;
            }
            /*/while (SqlBaglanti.read.Read())
            {
                for (int k = 0; k <= kontrol.Length; k++)
                { 
                    if (kontrol[k] == SqlBaglanti.read["UrunNo"].ToString())
                    {
                        comboÜrün.Items.Add(SqlBaglanti.read["UrunNo"].ToString());
                        belirleme = SqlBaglanti.read["UrunNo"].ToString();
                        for (int l = 0; l <= kontrol.Length; l++)
                        {
                            if (belirleme==kontrol[l])
                            {
                                kontrol[l] = "";
                            }
                        }
                        
                    }
                }
                
            }/*/
            
        }

        private void Göster()
        {
            if (comboÜrün.SelectedItem != null)
            {
                baglanti.SqlComm("select * from ÖnMaliyet where UrunNo='" + comboÜrün.SelectedItem.ToString() + "'");

                dataGridView1.DataSource = baglanti.SqlTable("select * from ÖnMaliyet where UrunNo='" + comboÜrün.SelectedItem.ToString() + "' ");

            }
            else
            {
                baglanti.SqlComm("select * from ÖnMaliyet order by UrunNo ASC");
                dataGridView1.DataSource = baglanti.SqlTable("select * from ÖnMaliyet order by UrunNo ASC");
            }
            //komut.Parameters.AddWithValue("@UrunNo",comboBox1.SelectedItem.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Göster();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmÖnMaliyetListele.ActiveForm.Close();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
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

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.PDF_Disa_Aktar(dataGridView1);
        }

        private void dataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            contextMenuStrip1.Show();
        }
      
        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.SqlComm("select * from ÖnMaliyet where Tarih between '"+dateTimePicker1.Value.ToString("yyyy/M/d")+"'  and  '"+dateTimePicker2.Value.ToString("yyyy/M/d")+"'");
            dataGridView1.DataSource = baglanti.SqlTable("select * from ÖnMaliyet where order by Tarih between '"+dateTimePicker1.Value.ToString("yyyy/M/d")+"'  and  '"+dateTimePicker2.Value.ToString("yyyy/M/d")+"'");
           
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            pnlTarih.Visible = false;
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value is DateTime)
            {
                pnlTarih.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ürünİsmineGöreFiltreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlUrunİsmi.Visible = true;
            pnlTarih.Visible = false;
        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlTarih.Visible = true;
            pnlUrunİsmi.Visible = false;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            pnlUrunİsmi.Visible = false;
        }

        private void btnÜrünAra_Click(object sender, EventArgs e)
        {
            baglanti.SqlComm("select * from ÖnMaliyet where Aciklama like '%"+txtÜrünAdi.Text+"%'");
            dataGridView1.DataSource = baglanti.SqlTable("select * from ÖnMaliyet where Aciklama like '%" + txtÜrünAdi.Text + "%'");
        }
    }
}
