namespace Stok_Takip
{
    partial class frmKullanıcıAyarları
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
            this.btnDeğiştir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMevcutID = new System.Windows.Forms.TextBox();
            this.txtMevcutŞifre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.comboMevcutSoru = new System.Windows.Forms.ComboBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtMevcutCevap = new System.Windows.Forms.TextBox();
            this.txtYeniŞifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEskiŞifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeğiştir
            // 
            this.btnDeğiştir.BackColor = System.Drawing.Color.Gray;
            this.btnDeğiştir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeğiştir.ForeColor = System.Drawing.Color.White;
            this.btnDeğiştir.Location = new System.Drawing.Point(133, 238);
            this.btnDeğiştir.Name = "btnDeğiştir";
            this.btnDeğiştir.Size = new System.Drawing.Size(96, 41);
            this.btnDeğiştir.TabIndex = 1;
            this.btnDeğiştir.Text = "Değiştir";
            this.btnDeğiştir.UseVisualStyleBackColor = false;
            this.btnDeğiştir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 32;
            this.label1.Tag = "";
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Şifre";
            // 
            // txtMevcutID
            // 
            this.txtMevcutID.BackColor = System.Drawing.Color.Gray;
            this.txtMevcutID.ForeColor = System.Drawing.Color.White;
            this.txtMevcutID.Location = new System.Drawing.Point(108, 131);
            this.txtMevcutID.Name = "txtMevcutID";
            this.txtMevcutID.ReadOnly = true;
            this.txtMevcutID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMevcutID.Size = new System.Drawing.Size(121, 22);
            this.txtMevcutID.TabIndex = 33;
            // 
            // txtMevcutŞifre
            // 
            this.txtMevcutŞifre.BackColor = System.Drawing.Color.Gray;
            this.txtMevcutŞifre.ForeColor = System.Drawing.Color.White;
            this.txtMevcutŞifre.Location = new System.Drawing.Point(108, 175);
            this.txtMevcutŞifre.Name = "txtMevcutŞifre";
            this.txtMevcutŞifre.PasswordChar = '*';
            this.txtMevcutŞifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMevcutŞifre.Size = new System.Drawing.Size(121, 22);
            this.txtMevcutŞifre.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.comboMevcutSoru);
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.txtMevcutCevap);
            this.groupBox2.Controls.Add(this.txtYeniŞifre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEskiŞifre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(281, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 323);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Ayarları";
            this.groupBox2.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(242, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Gray;
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(115, 52);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(121, 22);
            this.txtID.TabIndex = 2;
            // 
            // comboMevcutSoru
            // 
            this.comboMevcutSoru.BackColor = System.Drawing.Color.Gray;
            this.comboMevcutSoru.ForeColor = System.Drawing.Color.White;
            this.comboMevcutSoru.FormattingEnabled = true;
            this.comboMevcutSoru.Items.AddRange(new object[] {
            "Anne kızlık soyadınız nedir ?",
            "Evcil hayvanınız oldu mu ? Olduysa ismi neydi ?",
            "İlkokul öğretmeninizin ismi neydi?",
            "Herhangi bir şeye alerjiniz var mı ? Varsa nedir ?",
            "Burcunuz nedir ?"});
            this.comboMevcutSoru.Location = new System.Drawing.Point(115, 174);
            this.comboMevcutSoru.Name = "comboMevcutSoru";
            this.comboMevcutSoru.Size = new System.Drawing.Size(314, 24);
            this.comboMevcutSoru.TabIndex = 6;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Gray;
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGüncelle.ForeColor = System.Drawing.Color.White;
            this.btnGüncelle.Location = new System.Drawing.Point(255, 268);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(123, 37);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtMevcutCevap
            // 
            this.txtMevcutCevap.BackColor = System.Drawing.Color.Gray;
            this.txtMevcutCevap.ForeColor = System.Drawing.Color.White;
            this.txtMevcutCevap.Location = new System.Drawing.Point(115, 215);
            this.txtMevcutCevap.Name = "txtMevcutCevap";
            this.txtMevcutCevap.Size = new System.Drawing.Size(121, 22);
            this.txtMevcutCevap.TabIndex = 7;
            // 
            // txtYeniŞifre
            // 
            this.txtYeniŞifre.BackColor = System.Drawing.Color.Gray;
            this.txtYeniŞifre.ForeColor = System.Drawing.Color.White;
            this.txtYeniŞifre.Location = new System.Drawing.Point(115, 136);
            this.txtYeniŞifre.Name = "txtYeniŞifre";
            this.txtYeniŞifre.PasswordChar = '*';
            this.txtYeniŞifre.Size = new System.Drawing.Size(121, 22);
            this.txtYeniŞifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 32;
            this.label3.Tag = "";
            this.label3.Text = "ID";
            // 
            // txtEskiŞifre
            // 
            this.txtEskiŞifre.BackColor = System.Drawing.Color.Gray;
            this.txtEskiŞifre.ForeColor = System.Drawing.Color.White;
            this.txtEskiŞifre.Location = new System.Drawing.Point(115, 96);
            this.txtEskiŞifre.Name = "txtEskiŞifre";
            this.txtEskiŞifre.PasswordChar = '*';
            this.txtEskiŞifre.Size = new System.Drawing.Size(121, 22);
            this.txtEskiŞifre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Yeni Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cevap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Soru";
            // 
            // frmKullanıcıAyarları
            // 
            this.AcceptButton = this.btnGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMevcutID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMevcutŞifre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeğiştir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKullanıcıAyarları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ayarları";
            this.Load += new System.EventHandler(this.frmKullanıcıAyarları_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnDeğiştir;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMevcutID;
        public System.Windows.Forms.TextBox txtMevcutŞifre;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.ComboBox comboMevcutSoru;
        public System.Windows.Forms.Button btnGüncelle;
        public System.Windows.Forms.TextBox txtMevcutCevap;
        public System.Windows.Forms.TextBox txtYeniŞifre;
        public System.Windows.Forms.TextBox txtEskiŞifre;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
    }
}