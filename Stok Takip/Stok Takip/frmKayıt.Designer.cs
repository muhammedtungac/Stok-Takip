namespace Stok_Takip
{
    partial class frmKayıt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboSoru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtŞifreTekrar = new System.Windows.Forms.TextBox();
            this.btnGirişeDön = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soru :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cevap :";
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.BackColor = System.Drawing.Color.Gray;
            this.txtKullanıcıAdı.ForeColor = System.Drawing.SystemColors.Window;
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(143, 69);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(140, 22);
            this.txtKullanıcıAdı.TabIndex = 1;
            // 
            // txtŞifre
            // 
            this.txtŞifre.BackColor = System.Drawing.Color.Gray;
            this.txtŞifre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtŞifre.Location = new System.Drawing.Point(143, 98);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.PasswordChar = '*';
            this.txtŞifre.Size = new System.Drawing.Size(126, 22);
            this.txtŞifre.TabIndex = 2;
            // 
            // txtCevap
            // 
            this.txtCevap.BackColor = System.Drawing.Color.Gray;
            this.txtCevap.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCevap.Location = new System.Drawing.Point(143, 187);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(140, 22);
            this.txtCevap.TabIndex = 6;
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.Color.Gray;
            this.btnKayıtOl.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtOl.Location = new System.Drawing.Point(173, 258);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(135, 47);
            this.btnKayıtOl.TabIndex = 7;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboSoru);
            this.groupBox1.Controls.Add(this.txtKullanıcıAdı);
            this.groupBox1.Controls.Add(this.btnKayıtOl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCevap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtŞifreTekrar);
            this.groupBox1.Controls.Add(this.txtŞifre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(124, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 362);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(296, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboSoru
            // 
            this.comboSoru.BackColor = System.Drawing.Color.Gray;
            this.comboSoru.ForeColor = System.Drawing.SystemColors.Window;
            this.comboSoru.FormattingEnabled = true;
            this.comboSoru.Items.AddRange(new object[] {
            "Anne kızlık soyadınız nedir ?",
            "Evcil hayvanınız oldu mu ? Olduysa ismi neydi ?",
            "İlkokul öğretmeninizin ismi neydi?",
            "Herhangi bir şeye alerjiniz var mı ? Varsa nedir ?",
            "Burcunuz nedir ?"});
            this.comboSoru.Location = new System.Drawing.Point(143, 156);
            this.comboSoru.Name = "comboSoru";
            this.comboSoru.Size = new System.Drawing.Size(312, 24);
            this.comboSoru.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şifre (Tekrar) :";
            // 
            // txtŞifreTekrar
            // 
            this.txtŞifreTekrar.BackColor = System.Drawing.Color.Gray;
            this.txtŞifreTekrar.ForeColor = System.Drawing.SystemColors.Window;
            this.txtŞifreTekrar.Location = new System.Drawing.Point(143, 127);
            this.txtŞifreTekrar.Name = "txtŞifreTekrar";
            this.txtŞifreTekrar.PasswordChar = '*';
            this.txtŞifreTekrar.Size = new System.Drawing.Size(126, 22);
            this.txtŞifreTekrar.TabIndex = 4;
            // 
            // btnGirişeDön
            // 
            this.btnGirişeDön.BackColor = System.Drawing.Color.Gray;
            this.btnGirişeDön.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnGirişeDön.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirişeDön.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGirişeDön.Location = new System.Drawing.Point(667, 347);
            this.btnGirişeDön.Name = "btnGirişeDön";
            this.btnGirişeDön.Size = new System.Drawing.Size(102, 72);
            this.btnGirişeDön.TabIndex = 8;
            this.btnGirişeDön.Text = "Giriş Ekranına Dön";
            this.btnGirişeDön.UseVisualStyleBackColor = false;
            this.btnGirişeDön.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmKayıt
            // 
            this.AcceptButton = this.btnKayıtOl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGirişeDön);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.frmKayıt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSoru;
        private System.Windows.Forms.Button btnGirişeDön;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtŞifreTekrar;
    }
}