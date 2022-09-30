namespace Stok_Takip
{
    partial class frmŞifreÖğrenme
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
            this.btnSorgula = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtŞifreGetir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboSoru = new System.Windows.Forms.ComboBox();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackColor = System.Drawing.Color.Gray;
            this.btnSorgula.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorgula.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSorgula.Location = new System.Drawing.Point(207, 184);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(114, 47);
            this.btnSorgula.TabIndex = 4;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = false;
            this.btnSorgula.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtŞifreGetir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboSoru);
            this.groupBox1.Controls.Add(this.btnSorgula);
            this.groupBox1.Controls.Add(this.txtKullanıcıAdı);
            this.groupBox1.Controls.Add(this.txtCevap);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(150, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 286);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifremi Unuttum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtŞifreGetir
            // 
            this.txtŞifreGetir.BackColor = System.Drawing.Color.Gray;
            this.txtŞifreGetir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtŞifreGetir.ForeColor = System.Drawing.Color.Gray;
            this.txtŞifreGetir.Location = new System.Drawing.Point(207, 237);
            this.txtŞifreGetir.Name = "txtŞifreGetir";
            this.txtŞifreGetir.ReadOnly = true;
            this.txtŞifreGetir.Size = new System.Drawing.Size(114, 15);
            this.txtŞifreGetir.TabIndex = 16;
            this.txtŞifreGetir.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soru :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cevap :";
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
            this.comboSoru.Location = new System.Drawing.Point(178, 98);
            this.comboSoru.Name = "comboSoru";
            this.comboSoru.Size = new System.Drawing.Size(304, 24);
            this.comboSoru.TabIndex = 2;
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.BackColor = System.Drawing.Color.Gray;
            this.txtKullanıcıAdı.ForeColor = System.Drawing.SystemColors.Window;
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(178, 62);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(143, 22);
            this.txtKullanıcıAdı.TabIndex = 1;
            // 
            // txtCevap
            // 
            this.txtCevap.BackColor = System.Drawing.Color.Gray;
            this.txtCevap.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCevap.Location = new System.Drawing.Point(178, 133);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(128, 22);
            this.txtCevap.TabIndex = 3;
            // 
            // frmŞifreÖğrenme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmŞifreÖğrenme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Öğrenme";
            this.Load += new System.EventHandler(this.frmŞifreÖğrenme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSoru;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtŞifreGetir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}