namespace Stok_Takip
{
    partial class frmFiltre
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
            this.dateİlk = new System.Windows.Forms.DateTimePicker();
            this.dateSon = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateİlk
            // 
            this.dateİlk.Location = new System.Drawing.Point(65, 123);
            this.dateİlk.Name = "dateİlk";
            this.dateİlk.Size = new System.Drawing.Size(200, 22);
            this.dateİlk.TabIndex = 44;
            // 
            // dateSon
            // 
            this.dateSon.Location = new System.Drawing.Point(65, 168);
            this.dateSon.Name = "dateSon";
            this.dateSon.Size = new System.Drawing.Size(200, 22);
            this.dateSon.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Seçili İki Tarih Arasında Filtrele";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Gray;
            this.btnListele.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(112, 209);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(107, 33);
            this.btnListele.TabIndex = 47;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // frmFiltre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(345, 288);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateSon);
            this.Controls.Add(this.dateİlk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFiltre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtre";
            this.Load += new System.EventHandler(this.frmFiltre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateİlk;
        public System.Windows.Forms.DateTimePicker dateSon;
        public System.Windows.Forms.Button btnListele;
    }
}