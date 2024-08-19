namespace Personel_Kayit
{
    partial class İstatistik
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
            this.lbltoplam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.evliper = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bekarper = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.topmaas = new System.Windows.Forms.Label();
            this.farklısehir = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ortmaas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.Location = new System.Drawing.Point(268, 32);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(29, 32);
            this.lbltoplam.TabIndex = 1;
            this.lbltoplam.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Evli Personel:";
            // 
            // evliper
            // 
            this.evliper.AutoSize = true;
            this.evliper.Location = new System.Drawing.Point(268, 64);
            this.evliper.Name = "evliper";
            this.evliper.Size = new System.Drawing.Size(29, 32);
            this.evliper.TabIndex = 3;
            this.evliper.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bekar Personel:";
            // 
            // bekarper
            // 
            this.bekarper.AutoSize = true;
            this.bekarper.Location = new System.Drawing.Point(268, 96);
            this.bekarper.Name = "bekarper";
            this.bekarper.Size = new System.Drawing.Size(29, 32);
            this.bekarper.TabIndex = 5;
            this.bekarper.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Farklı Şehir:";
            // 
            // topmaas
            // 
            this.topmaas.AutoSize = true;
            this.topmaas.Location = new System.Drawing.Point(268, 160);
            this.topmaas.Name = "topmaas";
            this.topmaas.Size = new System.Drawing.Size(29, 32);
            this.topmaas.TabIndex = 7;
            this.topmaas.Text = "0";
            // 
            // farklısehir
            // 
            this.farklısehir.AutoSize = true;
            this.farklısehir.Location = new System.Drawing.Point(268, 128);
            this.farklısehir.Name = "farklısehir";
            this.farklısehir.Size = new System.Drawing.Size(29, 32);
            this.farklısehir.TabIndex = 9;
            this.farklısehir.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 32);
            this.label10.TabIndex = 8;
            this.label10.Text = "Toplam Maaş:";
            // 
            // ortmaas
            // 
            this.ortmaas.AutoSize = true;
            this.ortmaas.Location = new System.Drawing.Point(268, 192);
            this.ortmaas.Name = "ortmaas";
            this.ortmaas.Size = new System.Drawing.Size(29, 32);
            this.ortmaas.TabIndex = 11;
            this.ortmaas.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 32);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ortalama Maaş:";
            // 
            // İstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 256);
            this.Controls.Add(this.ortmaas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.farklısehir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.topmaas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bekarper);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.evliper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltoplam);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "İstatistik";
            this.Text = "İstatistik";
            this.Load += new System.EventHandler(this.İstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltoplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label evliper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bekarper;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label topmaas;
        private System.Windows.Forms.Label farklısehir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ortmaas;
        private System.Windows.Forms.Label label12;
    }
}