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
    public partial class frmÖnMaliyet : Form
    {
        public frmÖnMaliyet()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();        
        private void GenelToplamHesapla()
        {
            baglanti.SqlComm("select sum(Toplam) from ÖnMaliyet where UrunNo='" + txtÜrünNo.Text + "'");
            textBox1.Text = (SqlBaglanti.comm.ExecuteScalar() + "TL").ToString();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {            
            ÜrünKontrol();
           
                if (ekledurum == true && boşkontrol == false)
                {
                    baglanti.SqlComm("insert into ÖnMaliyet (UrunNo,Aciklama,Maliyet,Adet,Toplam,Tarih) values (@UrunNo,@Aciklama,@Maliyet,@Adet,@Toplam,@Tarih)");
                    SqlBaglanti.comm.Parameters.AddWithValue("@UrunNo", txtÜrünNo.Text);
                    SqlBaglanti.comm.Parameters.AddWithValue("@Aciklama", txtAçıklama.Text);
                    SqlBaglanti.comm.Parameters.AddWithValue("@Maliyet", int.Parse(txtMaliyet.Text));
                    SqlBaglanti.comm.Parameters.AddWithValue("@Adet", int.Parse(txtAdet.Text));
                    SqlBaglanti.comm.Parameters.AddWithValue("@Toplam", (int.Parse(txtMaliyet.Text) * int.Parse(txtAdet.Text)));
                    SqlBaglanti.comm.Parameters.AddWithValue("@Tarih", DateTime.Now);
                    SqlBaglanti.comm.ExecuteNonQuery();
                    GenelToplamHesapla();
                    Göster();
                }              
                else if (güncelledurum == true && boşkontrol == false)
                {
                    baglanti.SqlComm("update ÖnMaliyet set Maliyet='" + int.Parse(txtMaliyet.Text) + "',Adet=Adet+'" + int.Parse(txtAdet.Text) + "',Toplam=Toplam+'" + int.Parse(txtAdet.Text) * int.Parse(txtMaliyet.Text) + "', Tarih=@Tarih where UrunNo='" + txtÜrünNo.Text + "' and Aciklama='" + txtAçıklama.Text + "'");
                    //komut.Parameters.AddWithValue("@UrunNo", txtÜrünNo.Text);
                    //komut.Parameters.AddWithValue("@Aciklama",txtAçıklama.Text);
                    SqlBaglanti.comm.Parameters.AddWithValue("@Tarih", DateTime.Now);
                    SqlBaglanti.comm.ExecuteNonQuery();
                    GenelToplamHesapla();
                    Göster();
                }
                else if(yenionmaliyet==true)
                {
                MessageBox.Show("Yeni Bir ÖnMaliyet Sayfası Açın");
            }
                else if (boşkontrol == true)
                {
                    MessageBox.Show("Bir Değer Girmediniz");
                }

                txtAçıklama.Text = "";
                txtMaliyet.Text = "0";
                txtAdet.Text = "1";
                
          
            
            
        }
        static bool ekledurum;
        static bool güncelledurum;
        static bool boşkontrol;
        static int verisayisi;
        static bool yenionmaliyet;
        public void ÜrünKontrol()
        {
            //VeriSayısı();
            ekledurum = false;
            güncelledurum = false;          
            boşkontrol = false;
            yenionmaliyet = false;

            if (txtÜrünNo.Text == "" || txtAçıklama.Text == "" || txtMaliyet.Text == "" || txtAdet.Text == "")
            {
                boşkontrol = true;
            }         
            else if (int.Parse(dataGridView1.RowCount.ToString())== 1)
                {
                    ekledurum = true;
                }
               
                else
                {
                    baglanti.DataRead("select * from ÖnMaliyet");
                    while (SqlBaglanti.read.Read())
                    {

                        if (SqlBaglanti.read["UrunNo"].ToString() == txtÜrünNo.Text)
                        {
                            if (SqlBaglanti.read["Aciklama"].ToString() != txtAçıklama.Text)
                            {
                                ekledurum = true;
                            }
                            else
                            {
                                güncelledurum = true;
                            }
                        }

                        else if (SqlBaglanti.read["UrunNo"].ToString() != txtÜrünNo.Text)
                        {

                        yenionmaliyet = true;
                        }
                    }
                }

            

        }

        private void VeriSayısı()
        {
            baglanti.SqlComm("select count(*) from ÖnMaliyet where UrunNo='"+txtÜrünNo.Text+"'");
            verisayisi = int.Parse(SqlBaglanti.comm.ExecuteScalar().ToString());
        }



        /*/private void GenelToplamHesapla()
        {
            boşkontrol = true;
            if (txtÜrünNo.Text != "" && comboÜrün.SelectedItem.ToString() == "")
            {
                boşkontrol = false;
                baglanti.SqlComm("select sum(Toplam) from ÖnMaliyet where UrunNo='" + txtÜrünNo.Text + "'");
                textBox1.Text = (SqlBaglanti.comm.ExecuteScalar() + "TL").ToString();
            }
            else if (comboÜrün.SelectedItem.ToString() != "" && txtÜrünNo.Text != "")
            {
                boşkontrol = false;
                baglanti.SqlComm("select sum(Toplam) from ÖnMaliyet where UrunNo='"+ comboÜrün.SelectedItem.ToString() + "'");
                textBox1.Text = (SqlBaglanti.comm.ExecuteScalar() + "TL").ToString();
            
                
            }
            else if (txtÜrünNo.Text=="")
            {
                boşkontrol = true; 
            }           
        }/*/

        private void Göster()
        {
            
            baglanti.SqlComm("select * from ÖnMaliyet where UrunNo='" + txtÜrünNo.Text + "'");
            dataGridView1.DataSource = baglanti.SqlTable("select * from ÖnMaliyet where UrunNo='" + txtÜrünNo.Text + "'");
            
        }
        private void frmÖnMaliyet_Load(object sender, EventArgs e)
        {           
            ÜrünGetir();
            baglanti.SqlComm("select * from ÖnMaliyet");
            dataGridView1.DataSource = baglanti.TableTemizle("select * from ÖnMaliyet");
        }

        string kontrol;
        public string[] ürünliste;
        public string[] ürünliste2;

        private void ÜrünGetir()
        {
            baglanti.SqlComm("select count(*) from ÖnMaliyet");
            string verisayısı = SqlBaglanti.comm.ExecuteScalar().ToString();
            ürünliste = new string[int.Parse(verisayısı)];
            ürünliste2 = new string[int.Parse(verisayısı)];
            baglanti.DataRead("select * from ÖnMaliyet");
            int i = 0;
            while(SqlBaglanti.read.Read() && i<ürünliste.Length)
            {
                ürünliste[i] = "";
                ürünliste[i] = SqlBaglanti.read["UrunNo"].ToString();                
                i++;
            }
            baglanti.DataRead("select * from ÖnMaliyet");
            i = 0;
            while (SqlBaglanti.read.Read() && i < ürünliste.Length)
            {
                if (ürünliste[i] == SqlBaglanti.read["UrunNo"].ToString() && ürünliste[i]!="")
                {
                    comboÜrün.Items.Add(SqlBaglanti.read["UrunNo"].ToString());
                    ürünliste2[i] = SqlBaglanti.read["UrunNo"].ToString();
                    for (int k = 0; k < ürünliste.Length; k++)
                    {
                        if (ürünliste[k]==SqlBaglanti.read["UrunNo"].ToString())
                        {
                            ürünliste[k] = "";
                        }
                        
                    }
                }
                i++;
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtÜrünNo.Text = dataGridView1.CurrentRow.Cells["UrunNo"].Value.ToString();
            txtAçıklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
            txtMaliyet.Text = dataGridView1.CurrentRow.Cells["Maliyet"].Value.ToString();
            txtAdet.Text = dataGridView1.CurrentRow.Cells["Adet"].Value.ToString();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.SqlComm("delete from ÖnMaliyet where UrunNo='" + dataGridView1.CurrentRow.Cells["UrunNo"].Value.ToString() + "' and Aciklama='" + dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString() + "'");
            
            SqlBaglanti.comm.ExecuteNonQuery();
            
            Göster();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            frmÖnMaliyetListele listele = new frmÖnMaliyetListele();
            listele.Show();
            
        }

        private void comboÜrün_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmÖnMaliyet.ActiveForm.Close();
        }
    }
}
