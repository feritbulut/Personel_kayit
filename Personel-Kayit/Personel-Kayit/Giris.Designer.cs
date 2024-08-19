namespace Personel_Kayit
{
    partial class Giris
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
            this.kullanıcıad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Takip Sistemi Giriş Paneli";
            // 
            // kullanıcıad
            // 
            this.kullanıcıad.Location = new System.Drawing.Point(196, 78);
            this.kullanıcıad.Name = "kullanıcıad";
            this.kullanıcıad.Size = new System.Drawing.Size(193, 40);
            this.kullanıcıad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı adı:";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(196, 124);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(193, 40);
            this.sifre.TabIndex = 3;
            this.sifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre:";
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(196, 170);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(149, 51);
            this.btngiris.TabIndex = 5;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "**admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "**1245";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(521, 245);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullanıcıad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Giris";
            this.Text = "Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullanıcıad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}