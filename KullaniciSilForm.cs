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
    public partial class KullaniciSilForm : Form
    {

        public KullaniciSilForm()
        {
            InitializeComponent();
        }
        Context c = new Context();
        public void Listele()
        {
            var kullanicililar = c.Kullanicis.ToList();
            dataGridView1.DataSource = kullanicililar.ToList();
        }
        private void KullaniciSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = c.Kullanicis.Where(x => x.kullaniciId == secilenId).FirstOrDefault();
            c.Kullanicis.Remove(kullanici);
            c.SaveChanges();
            Listele();
        }
    }
}
