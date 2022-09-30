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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        public string id;
        public string şifre;

        private void frmSatışYap_Load(object sender, EventArgs e)
        {
            btnMenüAç.Location = new Point(x:0,y:0);
            panelKullanıcı.BackColor = TransparencyKey;
            panelKullanıcı.Visible = false;
            panelMüşteri.Visible = false;
            panelÜrün.Visible = false;
            panelSatış.Visible = false;
            panelKategori.Visible = false;
            panelMarka.Visible = false;
            panelÖnMaliyet.Visible = false;
            panelAnaMenü.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void circleMüşteri1_Click(object sender, EventArgs e)
        {
            
        }
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnKullanıcı_Click_1(object sender, EventArgs e)
        {
            if (panelKullanıcı.Visible == false)
            {
                panelKullanıcı.Visible = true;               
                panelMüşteri.Visible = false;
                panelÜrün.Visible = false;
                panelSatış.Visible = false;
                panelMarka.Visible = false;
                panelKategori.Visible = false;
                panelÖnMaliyet.Visible = false;
            }
            else
            {
                panelKullanıcı.Visible = false;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmMüşteriListele mlistele = new frmMüşteriListele();
            mlistele.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panelMüşteri.Visible == false)
            {
                panelMüşteri.Visible = true;
                panelKullanıcı.Visible = false;     
                panelÜrün.Visible = false;
                panelSatış.Visible = false;
                panelMarka.Visible = false;
                panelKategori.Visible = false;
                panelÖnMaliyet.Visible = false;
            }
            else
            {
                panelMüşteri.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (panelÜrün.Visible == false)
            {
                panelÜrün.Visible = true;
                panelKullanıcı.Visible = false;
                panelMüşteri.Visible = false;
                panelSatış.Visible = false;
                panelMarka.Visible = false;
                panelKategori.Visible = false;
                panelÖnMaliyet.Visible = false;
            }
            else
            {
                panelÜrün.Visible = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (panelSatış.Visible == false)
            {
                panelSatış.Visible = true;
                panelKullanıcı.Visible = false;
                panelMüşteri.Visible = false;
                panelÜrün.Visible = false;
                panelMarka.Visible = false;
                panelKategori.Visible = false;
                panelÖnMaliyet.Visible = false;
            }
            else
            {
                panelSatış.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (panelMarka.Visible == false)
            {
                panelMarka.Visible = true;
                panelKullanıcı.Visible = false;
                panelMüşteri.Visible = false;
                panelÜrün.Visible = false;
                panelSatış.Visible = false;
                panelKategori.Visible = false;
                panelÖnMaliyet.Visible = false;
            }
            else
            {
                panelMarka.Visible = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (panelKategori.Visible == false)
            {
                panelKategori.Visible = true;
                panelKullanıcı.Visible = false;
                panelMüşteri.Visible = false;
                panelÜrün.Visible = false;
                panelSatış.Visible = false;
                panelMarka.Visible = false;
                panelÖnMaliyet.Visible = false;
            }
            else
            {
                panelKategori.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (panelÖnMaliyet.Visible == false)
            {
                panelÖnMaliyet.Visible = true;
                panelKullanıcı.Visible = false;
                panelMüşteri.Visible = false;
                panelÜrün.Visible = false;
                panelSatış.Visible = false;
                panelMarka.Visible = false;
                panelKategori.Visible = false;

            }
            else
            {
                panelÖnMaliyet.Visible = false;
            }
        }

        private void btnMenüAç_Click(object sender, EventArgs e)
        {
            /*/panelKullanıcı.Visible = false;
            panelMüşteri.Visible = false;
            panelÜrün.Visible = false;
            panelSatış.Visible = false;
            panelMarka.Visible = false;
            panelKategori.Visible = false;
            panelÖnMaliyet.Visible = false;/*/
            if (btnMenüAç.Location.X==0 && btnMenüAç.Location.Y==0)
            {
                btnMenüAç.Location = new Point(x: 188, y: 0);
                btnMenüAç.BackgroundImage = ımageList1.Images[1];
                panelAnaMenü.Visible = true;
            }
            else
            {
                btnMenüAç.Location = new Point(x: 0, y: 0);
                btnMenüAç.BackgroundImage = ımageList1.Images[0];
                panelAnaMenü.Visible = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle mekle = new frmMüşteriEkle();
            mekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmÜrünEkle üekle = new frmÜrünEkle();
            üekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmÜrünListele ülistele = new frmÜrünListele();
            ülistele.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            frmSatış satış = new frmSatış();
            satış.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            frmSatışListele slistele = new frmSatışListele();
            slistele.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmMarka mekle = new frmMarka();
            mekle.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            frmKategori kekle = new frmKategori();
            kekle.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmÖnMaliyet ömhesapla = new frmÖnMaliyet();
            ömhesapla.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmÖnMaliyetListele ömlistele = new frmÖnMaliyetListele();
            ömlistele.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmKullanıcıAyarları ayar = new frmKullanıcıAyarları();
            //ayar.txtID.Text = lblID.Text;
            //ayar.txtŞifre.Text = lblŞifre.Text;
            //ayar.txtID.Text = id;
            //ayar.txtŞifre.Text = şifre;
            ayar.ShowDialog();
        }
    }
            
}
    
