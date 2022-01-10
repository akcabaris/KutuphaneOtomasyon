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
    public partial class OduncForm : Form
    {
        public OduncForm()
        {
            InitializeComponent();
        }

        Context c = new Context();
        

        private void OduncForm_Load(object sender, EventArgs e)
        {
            var oduncL = c.Oduncs.ToList();
            dataGridView1.DataSource = oduncL.ToList();
            dataGridView1.Columns[3].Visible = false;

            var kitapL = c.Kitaps.ToList();
            dataGridView2.DataSource = kitapL.ToList();

            // kitap id gizle
            dataGridView2.Columns[0].Visible = false;
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            /*
             * int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = c.Kullanicis.Where(x => x.kullaniciId == secilenId).FirstOrDefault();
             */
            int arananTC = Convert.ToInt32(TxtTcBul.Text);
            var kullaniciVarMi = c.Kullanicis.Where(x => x.kullaniciTc == arananTC).FirstOrDefault();

            if (kullaniciVarMi != null)
            {
                labelKullanici.Text = kullaniciVarMi.kullaniciAdSoyad;
            }
            else
            {
                labelKullanici.Text = "Üye Bulunamadı.";
            }
        }

        private void TxtBoxKitap_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = TxtBoxKitap.Text;
            var bulunanKitap = c.Kitaps.Where(x => x.kitapAd.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunanKitap;
            dataGridView2.Columns[0].Visible = false;
        }

        private void BtnOduncVer_Click(object sender, EventArgs e)
        {
            int secilenKisiTc = Convert.ToInt32(TxtTcBul.Text);
            var secilenKisi = c.Kullanicis.Where(x => x.kullaniciTc.Equals(secilenKisiTc)).FirstOrDefault();

            int secilenKitapId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKitap = c.Kitaps.Where(x => x.kitapId == secilenKitapId).FirstOrDefault();

            Odunc kayit = new Odunc();
            kayit.oduncKitapId = secilenKitap.kitapId;
            kayit.oduncKullaniciId = secilenKisi.kullaniciId;

            c.Oduncs.Add(kayit);
            c.SaveChanges();

            var oduncL = c.Oduncs.ToList();
            dataGridView1.DataSource = oduncL.ToList();
            dataGridView1.Columns[3].Visible = false;



        }
    }
}
