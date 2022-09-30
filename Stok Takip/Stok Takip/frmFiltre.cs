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
    public partial class frmFiltre : Form
    {
        public frmFiltre()
        {
            InitializeComponent();
        }
        public static string ilktarih;
        public static string sontarih;
        

        SqlBaglanti baglanti = new SqlBaglanti();
        
        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string filtreadres;
        public static string tabloadı;
        private void btnListele_Click(object sender, EventArgs e)
        {
            //baglanti.SqlComm("select * from Satış where Tarih between '" + dateİlk.Value.ToString("yyyy/M/d") + "' and '" + dateSon.Value.ToString("yyyy/M/d") + "'");
            //dataGridView1.DataSource = baglanti.SqlTable("select * from Satış where Tarih between '" + dateİlk.Value.ToString("yyyy/M/d") + "' and '" + dateSon.Value.ToString("yyyy/M/d") + "'");
            //satışListele.dataGridView1.DataSource = dataGridView1.DataSource;
            filtreadres = SqlBaglanti.filtreadres;
            tabloadı=filtreadres+   "" +dateİlk.Value.ToString("yyyy / M / d") + "' and '" + dateSon.Value.ToString("yyyy / M / d") + "'";
            frmSatışListele frmSatış = (frmSatışListele)Application.OpenForms["frmSatışListele"];
            baglanti.SqlComm(tabloadı);
            frmSatış.dataGridView1.DataSource = baglanti.SqlTable(tabloadı);
            
        }

        private void frmFiltre_Load(object sender, EventArgs e)
        {
        }
    }
}
