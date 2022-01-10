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
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }


        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //uj
            Context c = new Context();
            Kullanici k = new Kullanici();
            k.kullaniciTc = Convert.ToInt32(TxtTCNo.Text);
            k.kullaniciSifre = TxtSifre.Text;
            k.kullaniciAdSoyad = TxtAdSoyad.Text;
            k.kullaniciTipi = TxtTipi.Text;
            k.KullaniciMail = TxtMail.Text;

            c.Kullanicis.Add(k);
            c.SaveChanges();
        }
    }
}
