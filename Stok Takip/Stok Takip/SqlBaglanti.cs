using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing;

namespace Stok_Takip
{
    class SqlBaglanti
    {       
        public static SqlConnection conn ;
        public static SqlCommand     comm ;
        public static SqlDataAdapter adap ;
        public static SqlDataReader  read;
        public static string filtreadres;
        public static string id;
        public static string şifre;
        public string adres = System.IO.File.ReadAllText(@"C:\Connection.txt");
        public void SqlConn()
        {           
            conn=new SqlConnection(adres);
            conn.Open();
        } 
        public void SqlComm(string queryText)
        {
           comm = new SqlCommand(queryText, conn);     
        }
        public DataTable SqlTable(string queryText)
        {
            DataTable table=new DataTable();
            table.Clear();
            adap = new SqlDataAdapter(comm);
            adap.Fill(table);
            return table;
        }  
        public DataTable TableTemizle(string queryText)
        {
            DataTable table = new DataTable();
            adap = new SqlDataAdapter(comm);
            adap.Fill(table);
            table.Clear();
            return table;
        }
        public void DataRead(string queryText)
        {            
            comm = new SqlCommand(queryText, conn);
            read = comm.ExecuteReader();          
        }
        public void PDF_Disa_Aktar(DataGridView dataGridView1)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);

                // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.
                pdfTable.DefaultCell.Padding = 3; // hücre duvarı ve veri arasında mesafe
                pdfTable.WidthPercentage = 80; // hücre genişliği
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; // yazı hizalaması
                pdfTable.DefaultCell.BorderWidth = 1; // kenarlık kalınlığı
                // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240); // hücre arka plan rengi
                    pdfTable.AddCell(cell);
                }
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                using (FileStream stream = new FileStream(save.FileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);// sayfa boyutu.
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
    }
    }
    


