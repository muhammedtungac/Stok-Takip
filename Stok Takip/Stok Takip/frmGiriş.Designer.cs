namespace Stok_Takip
{
    partial class frmGiriş
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
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblŞifre = new System.Windows.Forms.LinkLabel();
            this.btnGiriş = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.BackColor = System.Drawing.Color.Gray;
            this.txtKullanıcıAdı.ForeColor = System.Drawing.SystemColors.Window;
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(216, 102);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(135, 22);
            this.txtKullanıcıAdı.TabIndex = 4;
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.Color.Gray;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtOl.ForeColor = System.Drawing.Color.White;
            this.btnKayıtOl.Location = new System.Drawing.Point(216, 273);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(114, 47);
            this.btnKayıtOl.TabIndex = 9;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // txtŞifre
            // 
            this.txtŞifre.BackColor = System.Drawing.Color.Gray;
            this.txtŞifre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtŞifre.Location = new System.Drawing.Point(216, 137);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.PasswordChar = '*';
            this.txtŞifre.Size = new System.Drawing.Size(135, 22);
            this.txtŞifre.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.lblŞifre);
            this.groupBox1.Controls.Add(this.btnKayıtOl);
            this.groupBox1.Controls.Add(this.btnGiriş);
            this.groupBox1.Controls.Add(this.txtKullanıcıAdı);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtŞifre);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(147, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 342);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(378, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Şifre Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // lblŞifre
            // 
            this.lblŞifre.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.ForeColor = System.Drawing.SystemColors.Window;
            this.lblŞifre.LinkColor = System.Drawing.SystemColors.Window;
            this.lblŞifre.Location = new System.Drawing.Point(213, 177);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(108, 17);
            this.lblŞifre.TabIndex = 7;
            this.lblŞifre.TabStop = true;
            this.lblŞifre.Text = "Şifremi Unuttum";
            this.lblŞifre.Click += new System.EventHandler(this.lblŞifre_Click);
            // 
            // btnGiriş
            // 
            this.btnGiriş.BackColor = System.Drawing.Color.Gray;
            this.btnGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiriş.ForeColor = System.Drawing.Color.White;
            this.btnGiriş.Location = new System.Drawing.Point(216, 220);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(114, 47);
            this.btnGiriş.TabIndex = 8;
            this.btnGiriş.Text = "Giriş";
            this.btnGiriş.UseVisualStyleBackColor = false;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // frmGiriş
            // 
            this.AcceptButton = this.btnGiriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.frmGiriş_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txtKullanıcıAdı;
        public System.Windows.Forms.Button btnKayıtOl;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtŞifre;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnGiriş;
        public System.Windows.Forms.LinkLabel lblŞifre;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}