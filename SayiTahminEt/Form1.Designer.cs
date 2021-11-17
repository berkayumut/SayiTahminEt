namespace SayiTahminEt
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAltSinir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUstSinir = new System.Windows.Forms.TextBox();
            this.btnSayiOlustur = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSayiOlustur);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUstSinir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAltSinir);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 105);
            this.panel1.TabIndex = 0;
            // 
            // txtAltSinir
            // 
            this.txtAltSinir.Location = new System.Drawing.Point(65, 10);
            this.txtAltSinir.Name = "txtAltSinir";
            this.txtAltSinir.Size = new System.Drawing.Size(100, 20);
            this.txtAltSinir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alt Sınır:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Üst Sınır:";
            // 
            // txtUstSinir
            // 
            this.txtUstSinir.Location = new System.Drawing.Point(65, 36);
            this.txtUstSinir.Name = "txtUstSinir";
            this.txtUstSinir.Size = new System.Drawing.Size(100, 20);
            this.txtUstSinir.TabIndex = 2;
            // 
            // btnSayiOlustur
            // 
            this.btnSayiOlustur.Location = new System.Drawing.Point(65, 63);
            this.btnSayiOlustur.Name = "btnSayiOlustur";
            this.btnSayiOlustur.Size = new System.Drawing.Size(100, 23);
            this.btnSayiOlustur.TabIndex = 4;
            this.btnSayiOlustur.Text = "Sayı Oluştur";
            this.btnSayiOlustur.UseVisualStyleBackColor = true;
            this.btnSayiOlustur.Click += new System.EventHandler(this.btnSayiOlustur_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTahminEt);
            this.panel2.Controls.Add(this.txtTahmin);
            this.panel2.Location = new System.Drawing.Point(223, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 105);
            this.panel2.TabIndex = 1;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(36, 13);
            this.txtTahmin.Multiline = true;
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(129, 27);
            this.txtTahmin.TabIndex = 0;
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(60, 47);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(75, 23);
            this.btnTahminEt.TabIndex = 1;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(12, 135);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 15);
            this.lblDurum.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 184);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSayiOlustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUstSinir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAltSinir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Label lblDurum;
    }
}

