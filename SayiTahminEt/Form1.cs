using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminEt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int altsinir;
        int ustsinir;
        int sayi;
        int tahmin;
        Random rnd = new Random();
        private void btnSayiOlustur_Click(object sender, EventArgs e)
        {
            lblDurum.Text = "";
            txtTahmin.Text = "";
            altsinir = int.Parse(txtAltSinir.Text);
            ustsinir = int.Parse(txtUstSinir.Text);
            sayi = rnd.Next(altsinir, ustsinir + 1);
            MessageBox.Show("Sayı Oluşturulmuştur. Tahmin Etmeye Başlayın.");
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            tahmin = int.Parse(txtTahmin.Text);
            if (tahmin == sayi)
            {
                lblDurum.Text = "Doğru Tahmin Ettiniz. Sayı: " + sayi;

            }
            else if (tahmin < sayi)
            {
                altsinir = tahmin;
                lblDurum.Text = "Yanlış Tahmin Ettiniz. Lütfen "+ altsinir +" İle "+ustsinir +" Arasında Bir Sayı Giriniz.";
                
            }
            else if (tahmin > sayi)
            {
                ustsinir = tahmin;
                lblDurum.Text = "Yanlış Tahmin Ettiniz. Lütfen " + altsinir + " İle " + ustsinir + " Arasında Bir Sayı Giriniz.";
            }
        }
    }
}
