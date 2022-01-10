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
    public partial class KitapDuzenleForm : Form
    {
        public KitapDuzenleForm()
        {
            InitializeComponent();
        }
        Context c = new Context();
        private void KitapDuzenleForm_Load(object sender, EventArgs e)
        {
            var kitaplar = c.Kitaps.ToList();
            dataGridView1.DataSource = kitaplar.ToList();

        }



        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtKitapAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtYazarAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtBolumRaf.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void BtnKtpEkle_Click(object sender, EventArgs e)
        {
            int secilenKitap = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var gkitap = c.Kitaps.Where(x => x.kitapId == secilenKitap).FirstOrDefault();

            gkitap.kitapAd = TxtKitapAdi.Text;
            gkitap.kitapYazar = TxtYazarAdi.Text;
            gkitap.kitapKonum = TxtBolumRaf.Text;
            c.SaveChanges();

            var kitaplar = c.Kitaps.ToList();
            dataGridView1.DataSource = kitaplar.ToList();


        }

    }
}
