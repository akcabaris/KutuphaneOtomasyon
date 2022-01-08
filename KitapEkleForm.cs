using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class KitapEkleForm : Form
    {
        
        public KitapEkleForm()
        {
            InitializeComponent();
        }
        Context c = new Context();

        private void BtnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitap k = new Kitap();
            k.kitapAd = TxtKitapAdi.Text;
            k.kitapYazar = TxtYazarAdi.Text;
            k.kitapKonum = TxtBolumveRaf.Text;
            // kitap yazar bilinmiyor olabilir, raf bilgisi sonradan eklenecek olabilir o nedenle isim yeterli
            if (k.kitapAd == null){
                MessageBox.Show("Kitabın Adı boş bırakılamaz. Lütfen kitabın adını giriniz.");
            }
            else {
                c.Kitaps.Add(k);
                c.SaveChanges();
                MessageBox.Show("Kitap eklendi");
            }
        }

    }
}
