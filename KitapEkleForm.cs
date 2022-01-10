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
        private void BtnKtpEkle_Click(object sender, EventArgs e)
        {
            Kitap kitaplar = new Kitap();
            kitaplar.kitapAd = TxtKitapAdi.Text;
            kitaplar.kitapYazar = TxtYazarAdi.Text;
            kitaplar.kitapKonum = TxtBolumRaf.Text;
            c.Kitaps.Add(kitaplar);
            c.SaveChanges();

            var kList = c.Kitaps.ToList();
            dataGridView1.DataSource = kList.ToList();
            //dataGridView1.Columns[1].HeaderText = "Kitabın Adı";

        }
        public void Listele()
        {
            var kitaplar = c.Kitaps.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
        }

        private void KitapEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

    }
}
