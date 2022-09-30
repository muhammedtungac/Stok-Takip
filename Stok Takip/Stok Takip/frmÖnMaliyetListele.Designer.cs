namespace Stok_Takip
{
    partial class frmÖnMaliyetListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÖnMaliyetListele));
            this.btnListele = new System.Windows.Forms.Button();
            this.comboÜrün = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAktar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filtreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİsmineGöreFiltreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTarih = new System.Windows.Forms.Panel();
            this.pnlUrunİsmi = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtÜrünAdi = new System.Windows.Forms.TextBox();
            this.btnÜrünAra = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlTarih.SuspendLayout();
            this.pnlUrunİsmi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Gray;
            this.btnListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnListele.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnListele.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListele.Location = new System.Drawing.Point(723, 199);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(143, 35);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboÜrün
            // 
            this.comboÜrün.BackColor = System.Drawing.Color.Gray;
            this.comboÜrün.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboÜrün.ForeColor = System.Drawing.SystemColors.Window;
            this.comboÜrün.FormattingEnabled = true;
            this.comboÜrün.Location = new System.Drawing.Point(723, 156);
            this.comboÜrün.Name = "comboÜrün";
            this.comboÜrün.Size = new System.Drawing.Size(143, 27);
            this.comboÜrün.TabIndex = 1;
            this.comboÜrün.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(627, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün No";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(689, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "PDF\'ye Çıkart";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.Gray;
            this.btnAktar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAktar.Location = new System.Drawing.Point(689, 403);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(186, 53);
            this.btnAktar.TabIndex = 3;
            this.btnAktar.Text = "Excel\'e Çıkart";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(26, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(595, 488);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtreleToolStripMenuItem,
            this.ürünİsmineGöreFiltreleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 52);
            // 
            // filtreleToolStripMenuItem
            // 
            this.filtreleToolStripMenuItem.Name = "filtreleToolStripMenuItem";
            this.filtreleToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.filtreleToolStripMenuItem.Text = "Tarihe Göre Filtrele";
            this.filtreleToolStripMenuItem.Click += new System.EventHandler(this.filtreleToolStripMenuItem_Click);
            // 
            // ürünİsmineGöreFiltreleToolStripMenuItem
            // 
            this.ürünİsmineGöreFiltreleToolStripMenuItem.Name = "ürünİsmineGöreFiltreleToolStripMenuItem";
            this.ürünİsmineGöreFiltreleToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.ürünİsmineGöreFiltreleToolStripMenuItem.Text = "Ürün İsmine Göre Filtrele";
            this.ürünİsmineGöreFiltreleToolStripMenuItem.Click += new System.EventHandler(this.ürünİsmineGöreFiltreleToolStripMenuItem_Click);
            // 
            // pnlTarih
            // 
            this.pnlTarih.Controls.Add(this.pnlUrunİsmi);
            this.pnlTarih.Controls.Add(this.label3);
            this.pnlTarih.Controls.Add(this.dateTimePicker1);
            this.pnlTarih.Controls.Add(this.dateTimePicker2);
            this.pnlTarih.Controls.Add(this.panel7);
            this.pnlTarih.Controls.Add(this.btnAra);
            this.pnlTarih.Location = new System.Drawing.Point(203, 186);
            this.pnlTarih.Name = "pnlTarih";
            this.pnlTarih.Size = new System.Drawing.Size(266, 170);
            this.pnlTarih.TabIndex = 32;
            this.pnlTarih.Visible = false;
            // 
            // pnlUrunİsmi
            // 
            this.pnlUrunİsmi.Controls.Add(this.label2);
            this.pnlUrunİsmi.Controls.Add(this.txtÜrünAdi);
            this.pnlUrunİsmi.Controls.Add(this.btnÜrünAra);
            this.pnlUrunİsmi.Controls.Add(this.panel9);
            this.pnlUrunİsmi.Location = new System.Drawing.Point(0, 0);
            this.pnlUrunİsmi.Name = "pnlUrunİsmi";
            this.pnlUrunİsmi.Size = new System.Drawing.Size(266, 170);
            this.pnlUrunİsmi.TabIndex = 33;
            this.pnlUrunİsmi.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ürün İsmi";
            // 
            // txtÜrünAdi
            // 
            this.txtÜrünAdi.Location = new System.Drawing.Point(66, 64);
            this.txtÜrünAdi.Name = "txtÜrünAdi";
            this.txtÜrünAdi.Size = new System.Drawing.Size(146, 22);
            this.txtÜrünAdi.TabIndex = 19;
            this.txtÜrünAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnÜrünAra
            // 
            this.btnÜrünAra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnÜrünAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrünAra.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜrünAra.ForeColor = System.Drawing.Color.White;
            this.btnÜrünAra.Location = new System.Drawing.Point(66, 110);
            this.btnÜrünAra.Name = "btnÜrünAra";
            this.btnÜrünAra.Size = new System.Drawing.Size(146, 32);
            this.btnÜrünAra.TabIndex = 2;
            this.btnÜrünAra.Text = "Filtrele";
            this.btnÜrünAra.UseVisualStyleBackColor = true;
            this.btnÜrünAra.Click += new System.EventHandler(this.btnÜrünAra_Click);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(234, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(32, 26);
            this.panel9.TabIndex = 18;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(41, 83);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(195, 22);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(234, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(32, 26);
            this.panel7.TabIndex = 18;
            this.panel7.Click += new System.EventHandler(this.panel7_Click);
            // 
            // btnAra
            // 
            this.btnAra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(65, 123);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(146, 32);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Filtrele";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmÖnMaliyetListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(929, 541);
            this.Controls.Add(this.pnlTarih);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboÜrün);
            this.Controls.Add(this.btnListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmÖnMaliyetListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ön Maliyet Listele";
            this.Load += new System.EventHandler(this.frmÖnMaliyetListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlTarih.ResumeLayout(false);
            this.pnlTarih.PerformLayout();
            this.pnlUrunİsmi.ResumeLayout(false);
            this.pnlUrunİsmi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboÜrün;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filtreleToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTarih;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem ürünİsmineGöreFiltreleToolStripMenuItem;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnlUrunİsmi;
        private System.Windows.Forms.TextBox txtÜrünAdi;
        private System.Windows.Forms.Button btnÜrünAra;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}