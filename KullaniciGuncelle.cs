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
    public partial class KullaniciGuncelle : Form
    {
        Context c = new Context();
        public KullaniciGuncelle()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            var kullanicililar = c.Kullanicis.ToList();
            dataGridView1.DataSource = kullanicililar.ToList();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void KullaniciGuncelle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            TxtTCNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtAdSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TxtTipi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TxtMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = c.Kullanicis.Where(x => x.kullaniciId == secilenId).FirstOrDefault();

            kullanici.kullaniciTc = Convert.ToInt32(TxtTCNo.Text);
            kullanici.kullaniciSifre = TxtSifre.Text;
            kullanici.kullaniciAdSoyad = TxtAdSoyad.Text;
            kullanici.kullaniciTipi = TxtTipi.Text;
            kullanici.KullaniciMail = TxtMail.Text;

            c.SaveChanges();
            Listele();
        }
    }
}
