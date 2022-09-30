namespace Stok_Takip
{
    partial class frmBarkodOkut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarkodOkut));
            this.comboKamera = new System.Windows.Forms.ComboBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaşlat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboKamera
            // 
            this.comboKamera.BackColor = System.Drawing.Color.Gray;
            this.comboKamera.ForeColor = System.Drawing.Color.White;
            this.comboKamera.FormattingEnabled = true;
            resources.ApplyResources(this.comboKamera, "comboKamera");
            this.comboKamera.Name = "comboKamera";
            // 
            // txtKod
            // 
            this.txtKod.BackColor = System.Drawing.Color.Gray;
            this.txtKod.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtKod, "txtKod");
            this.txtKod.Name = "txtKod";
            this.txtKod.ReadOnly = true;
            this.txtKod.TextChanged += new System.EventHandler(this.txtKod_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // btnBaşlat
            // 
            this.btnBaşlat.BackColor = System.Drawing.Color.Gray;
            this.btnBaşlat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnBaşlat, "btnBaşlat");
            this.btnBaşlat.ForeColor = System.Drawing.Color.White;
            this.btnBaşlat.Name = "btnBaşlat";
            this.btnBaşlat.UseVisualStyleBackColor = false;
            this.btnBaşlat.Click += new System.EventHandler(this.btnBaşlat_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBarkodOkut
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btnBaşlat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.comboKamera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBarkodOkut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBarcode_FormClosing);
            this.Load += new System.EventHandler(this.frmBarcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboKamera;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaşlat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}