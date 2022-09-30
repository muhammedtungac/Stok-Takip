namespace Stok_Takip
{
    partial class frmSatış
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatış));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hücreyiFiltreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hücreyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMüşteriNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSatışKodu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.txtSatışFiyatı = new System.Windows.Forms.TextBox();
            this.txtMiktarı = new System.Windows.Forms.TextBox();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSatışYap = new System.Windows.Forms.Button();
            this.btnSatışİptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıBilgileriniDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıÇıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satınAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünÖnMaliyetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.önMaliyetHesaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.önMaliyetleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(350, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 606);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hücreyiFiltreleToolStripMenuItem,
            this.hücreyiSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 52);
            // 
            // hücreyiFiltreleToolStripMenuItem
            // 
            this.hücreyiFiltreleToolStripMenuItem.Name = "hücreyiFiltreleToolStripMenuItem";
            this.hücreyiFiltreleToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.hücreyiFiltreleToolStripMenuItem.Text = "Hücreyi Filtrele";
            // 
            // hücreyiSilToolStripMenuItem
            // 
            this.hücreyiSilToolStripMenuItem.Name = "hücreyiSilToolStripMenuItem";
            this.hücreyiSilToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.hücreyiSilToolStripMenuItem.Text = "Hücreyi Sil";
            this.hücreyiSilToolStripMenuItem.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMüşteriNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(31, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(304, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.Gray;
            this.txtTelefon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTelefon.Location = new System.Drawing.Point(142, 78);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(153, 27);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.Gray;
            this.txtAdSoyad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAdSoyad.Location = new System.Drawing.Point(142, 49);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(153, 27);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMüşteriNo
            // 
            this.txtMüşteriNo.BackColor = System.Drawing.Color.Gray;
            this.txtMüşteriNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMüşteriNo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMüşteriNo.Location = new System.Drawing.Point(142, 21);
            this.txtMüşteriNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMüşteriNo.Name = "txtMüşteriNo";
            this.txtMüşteriNo.Size = new System.Drawing.Size(153, 27);
            this.txtMüşteriNo.TabIndex = 1;
            this.txtMüşteriNo.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Müşteri No";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSatışKodu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtToplamFiyat);
            this.groupBox2.Controls.Add(this.txtSatışFiyatı);
            this.groupBox2.Controls.Add(this.txtMiktarı);
            this.groupBox2.Controls.Add(this.txtÜrünAdı);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(31, 317);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(304, 238);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(5, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(5, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Satış Kodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(5, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Miktarı";
            // 
            // txtSatışKodu
            // 
            this.txtSatışKodu.BackColor = System.Drawing.Color.Gray;
            this.txtSatışKodu.ForeColor = System.Drawing.Color.White;
            this.txtSatışKodu.Location = new System.Drawing.Point(142, 33);
            this.txtSatışKodu.Name = "txtSatışKodu";
            this.txtSatışKodu.Size = new System.Drawing.Size(153, 27);
            this.txtSatışKodu.TabIndex = 5;
            this.txtSatışKodu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "BarkodNo";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.BackColor = System.Drawing.Color.Gray;
            this.txtToplamFiyat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamFiyat.ForeColor = System.Drawing.SystemColors.Window;
            this.txtToplamFiyat.Location = new System.Drawing.Point(142, 198);
            this.txtToplamFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(153, 27);
            this.txtToplamFiyat.TabIndex = 10;
            this.txtToplamFiyat.TextChanged += new System.EventHandler(this.txtToplamFiyat_TextChanged);
            // 
            // txtSatışFiyatı
            // 
            this.txtSatışFiyatı.BackColor = System.Drawing.Color.Gray;
            this.txtSatışFiyatı.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatışFiyatı.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSatışFiyatı.Location = new System.Drawing.Point(142, 171);
            this.txtSatışFiyatı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSatışFiyatı.Name = "txtSatışFiyatı";
            this.txtSatışFiyatı.Size = new System.Drawing.Size(153, 27);
            this.txtSatışFiyatı.TabIndex = 9;
            this.txtSatışFiyatı.TextChanged += new System.EventHandler(this.txtSatışFiyatı_TextChanged);
            // 
            // txtMiktarı
            // 
            this.txtMiktarı.BackColor = System.Drawing.Color.Gray;
            this.txtMiktarı.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktarı.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMiktarı.Location = new System.Drawing.Point(142, 144);
            this.txtMiktarı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMiktarı.Name = "txtMiktarı";
            this.txtMiktarı.Size = new System.Drawing.Size(153, 27);
            this.txtMiktarı.TabIndex = 8;
            this.txtMiktarı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktarı.TextChanged += new System.EventHandler(this.txtMiktarı_TextChanged);
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.BackColor = System.Drawing.Color.Gray;
            this.txtÜrünAdı.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜrünAdı.ForeColor = System.Drawing.SystemColors.Window;
            this.txtÜrünAdı.Location = new System.Drawing.Point(142, 117);
            this.txtÜrünAdı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.Size = new System.Drawing.Size(153, 27);
            this.txtÜrünAdı.TabIndex = 7;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.Color.Gray;
            this.txtBarkodNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBarkodNo.Location = new System.Drawing.Point(142, 90);
            this.txtBarkodNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(153, 27);
            this.txtBarkodNo.TabIndex = 6;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(680, 728);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Genel Toplam";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Gray;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEkle.Location = new System.Drawing.Point(203, 572);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(132, 57);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.BackColor = System.Drawing.Color.Gray;
            this.btnSatışYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatışYap.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSatışYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatışYap.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatışYap.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSatışYap.Location = new System.Drawing.Point(1048, 709);
            this.btnSatışYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(132, 57);
            this.btnSatışYap.TabIndex = 11;
            this.btnSatışYap.Text = "Satış Yap";
            this.btnSatışYap.UseVisualStyleBackColor = false;
            this.btnSatışYap.Click += new System.EventHandler(this.btnSatışYap_Click);
            // 
            // btnSatışİptal
            // 
            this.btnSatışİptal.BackColor = System.Drawing.Color.Gray;
            this.btnSatışİptal.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSatışİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatışİptal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatışİptal.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSatışİptal.Location = new System.Drawing.Point(1214, 207);
            this.btnSatışİptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSatışİptal.Name = "btnSatışİptal";
            this.btnSatışİptal.Size = new System.Drawing.Size(132, 57);
            this.btnSatışİptal.TabIndex = 13;
            this.btnSatışİptal.Text = "Satış İptal";
            this.btnSatışİptal.UseVisualStyleBackColor = false;
            this.btnSatışİptal.Click += new System.EventHandler(this.btnSatışİptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Gray;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSil.Location = new System.Drawing.Point(1214, 127);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(132, 57);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.ürünToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.kategoriToolStripMenuItem,
            this.markaToolStripMenuItem,
            this.ürünÖnMaliyetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(693, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıBilgileriniDüzenleToolStripMenuItem,
            this.kullanıcıÇıkışToolStripMenuItem});
            this.kullanıcıToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.kullanıcıToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcıToolStripMenuItem.Image")));
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // kullanıcıBilgileriniDüzenleToolStripMenuItem
            // 
            this.kullanıcıBilgileriniDüzenleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.kullanıcıBilgileriniDüzenleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.kullanıcıBilgileriniDüzenleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcıBilgileriniDüzenleToolStripMenuItem.Image")));
            this.kullanıcıBilgileriniDüzenleToolStripMenuItem.Name = "kullanıcıBilgileriniDüzenleToolStripMenuItem";
            this.kullanıcıBilgileriniDüzenleToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.kullanıcıBilgileriniDüzenleToolStripMenuItem.Text = "Kullanıcı Bilgilerini Düzenle";
            this.kullanıcıBilgileriniDüzenleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıBilgileriniDüzenleToolStripMenuItem_Click);
            // 
            // kullanıcıÇıkışToolStripMenuItem
            // 
            this.kullanıcıÇıkışToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.kullanıcıÇıkışToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.kullanıcıÇıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcıÇıkışToolStripMenuItem.Image")));
            this.kullanıcıÇıkışToolStripMenuItem.Name = "kullanıcıÇıkışToolStripMenuItem";
            this.kullanıcıÇıkışToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.kullanıcıÇıkışToolStripMenuItem.Text = "Kullanıcı Çıkış";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşteriToolStripMenuItem1});
            this.müşteriToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.müşteriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("müşteriToolStripMenuItem.Image")));
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.müşteriEkleToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriEkleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.müşteriEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("müşteriEkleToolStripMenuItem.Image")));
            this.müşteriEkleToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Gray;
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.button5_Click);
            // 
            // müşteriToolStripMenuItem1
            // 
            this.müşteriToolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.müşteriToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.müşteriToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("müşteriToolStripMenuItem1.Image")));
            this.müşteriToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Gray;
            this.müşteriToolStripMenuItem1.Name = "müşteriToolStripMenuItem1";
            this.müşteriToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.müşteriToolStripMenuItem1.Text = "Müşteri Listele";
            this.müşteriToolStripMenuItem1.Click += new System.EventHandler(this.button6_Click);
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.ürünToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEkleToolStripMenuItem,
            this.ürünListeleToolStripMenuItem});
            this.ürünToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ürünToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ürünToolStripMenuItem.Image")));
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.ürünToolStripMenuItem.Text = "Ürün";
            this.ürünToolStripMenuItem.Click += new System.EventHandler(this.ürünToolStripMenuItem_Click);
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.ürünEkleToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünEkleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ürünEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ürünEkleToolStripMenuItem.Image")));
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.button7_Click);
            // 
            // ürünListeleToolStripMenuItem
            // 
            this.ürünListeleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.ürünListeleToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünListeleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ürünListeleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ürünListeleToolStripMenuItem.Image")));
            this.ürünListeleToolStripMenuItem.Name = "ürünListeleToolStripMenuItem";
            this.ürünListeleToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.ürünListeleToolStripMenuItem.Text = "Ürün Listele";
            this.ürünListeleToolStripMenuItem.Click += new System.EventHandler(this.button8_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.satışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışListeleToolStripMenuItem,
            this.satınAlmaToolStripMenuItem});
            this.satışToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satışToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.satışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("satışToolStripMenuItem.Image")));
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.satışToolStripMenuItem.Text = "Satış";
            // 
            // satışListeleToolStripMenuItem
            // 
            this.satışListeleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.satışListeleToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satışListeleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.satışListeleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("satışListeleToolStripMenuItem.Image")));
            this.satışListeleToolStripMenuItem.Name = "satışListeleToolStripMenuItem";
            this.satışListeleToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.satışListeleToolStripMenuItem.Text = "Satış Listele";
            this.satışListeleToolStripMenuItem.Click += new System.EventHandler(this.button9_Click);
            // 
            // satınAlmaToolStripMenuItem
            // 
            this.satınAlmaToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.satınAlmaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.satınAlmaToolStripMenuItem.Name = "satınAlmaToolStripMenuItem";
            this.satınAlmaToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.satınAlmaToolStripMenuItem.Text = "Satın Alma";
            this.satınAlmaToolStripMenuItem.Click += new System.EventHandler(this.satınAlmaToolStripMenuItem_Click);
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.kategoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriEkleToolStripMenuItem});
            this.kategoriToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kategoriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kategoriToolStripMenuItem.Image")));
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            // 
            // kategoriEkleToolStripMenuItem
            // 
            this.kategoriEkleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.kategoriEkleToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoriEkleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kategoriEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kategoriEkleToolStripMenuItem.Image")));
            this.kategoriEkleToolStripMenuItem.Name = "kategoriEkleToolStripMenuItem";
            this.kategoriEkleToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.kategoriEkleToolStripMenuItem.Text = "Kategori Ekle";
            this.kategoriEkleToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // markaToolStripMenuItem
            // 
            this.markaToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.markaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaEkleToolStripMenuItem});
            this.markaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.markaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("markaToolStripMenuItem.Image")));
            this.markaToolStripMenuItem.Name = "markaToolStripMenuItem";
            this.markaToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.markaToolStripMenuItem.Text = "Marka";
            // 
            // markaEkleToolStripMenuItem
            // 
            this.markaEkleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.markaEkleToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markaEkleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.markaEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("markaEkleToolStripMenuItem.Image")));
            this.markaEkleToolStripMenuItem.Name = "markaEkleToolStripMenuItem";
            this.markaEkleToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.markaEkleToolStripMenuItem.Text = "Marka Ekle";
            this.markaEkleToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // ürünÖnMaliyetToolStripMenuItem
            // 
            this.ürünÖnMaliyetToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.ürünÖnMaliyetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.önMaliyetHesaplaToolStripMenuItem,
            this.önMaliyetleriListeleToolStripMenuItem});
            this.ürünÖnMaliyetToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünÖnMaliyetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ürünÖnMaliyetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ürünÖnMaliyetToolStripMenuItem.Image")));
            this.ürünÖnMaliyetToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ürünÖnMaliyetToolStripMenuItem.Name = "ürünÖnMaliyetToolStripMenuItem";
            this.ürünÖnMaliyetToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.ürünÖnMaliyetToolStripMenuItem.Text = "Ön Maliyet";
            // 
            // önMaliyetHesaplaToolStripMenuItem
            // 
            this.önMaliyetHesaplaToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.önMaliyetHesaplaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.önMaliyetHesaplaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.önMaliyetHesaplaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("önMaliyetHesaplaToolStripMenuItem.Image")));
            this.önMaliyetHesaplaToolStripMenuItem.Name = "önMaliyetHesaplaToolStripMenuItem";
            this.önMaliyetHesaplaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.önMaliyetHesaplaToolStripMenuItem.Text = "Ön Maliyet Hesapla";
            this.önMaliyetHesaplaToolStripMenuItem.Click += new System.EventHandler(this.önMaliyetHesaplaToolStripMenuItem_Click);
            // 
            // önMaliyetleriListeleToolStripMenuItem
            // 
            this.önMaliyetleriListeleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.önMaliyetleriListeleToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.önMaliyetleriListeleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.önMaliyetleriListeleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("önMaliyetleriListeleToolStripMenuItem.Image")));
            this.önMaliyetleriListeleToolStripMenuItem.Name = "önMaliyetleriListeleToolStripMenuItem";
            this.önMaliyetleriListeleToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.önMaliyetleriListeleToolStripMenuItem.Text = "Ön Maliyetleri Listele";
            this.önMaliyetleriListeleToolStripMenuItem.Click += new System.EventHandler(this.önMaliyetleriListeleToolStripMenuItem_Click);
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.BackColor = System.Drawing.Color.Gray;
            this.txtGenelToplam.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGenelToplam.ForeColor = System.Drawing.Color.White;
            this.txtGenelToplam.Location = new System.Drawing.Point(819, 725);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.ReadOnly = true;
            this.txtGenelToplam.Size = new System.Drawing.Size(126, 27);
            this.txtGenelToplam.TabIndex = 15;
            this.txtGenelToplam.TextChanged += new System.EventHandler(this.txtGenelToplam_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(36, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "Önceki Satışlar";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gray;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(36, 557);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 19);
            this.label12.TabIndex = 31;
            this.label12.Text = "-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(203, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 57);
            this.button1.TabIndex = 29;
            this.button1.Text = "Qr Code ile Okut";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmSatış
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1372, 781);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtGenelToplam);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSatışİptal);
            this.Controls.Add(this.btnSatışYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSatış";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.FormSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMüşteriNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.TextBox txtSatışFiyatı;
        private System.Windows.Forms.TextBox txtMiktarı;
        private System.Windows.Forms.TextBox txtÜrünAdı;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSatışYap;
        private System.Windows.Forms.Button btnSatışİptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaEkleToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.ToolStripMenuItem ürünÖnMaliyetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem önMaliyetHesaplaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem önMaliyetleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıBilgileriniDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıÇıkışToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSatışKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hücreyiFiltreleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hücreyiSilToolStripMenuItem;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem satınAlmaToolStripMenuItem;
    }
}

