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
    public partial class KitapSilForm : Form
    {
        public KitapSilForm()
        {
            InitializeComponent();
        }

        Context c = new Context();
        private void KitapSilForm_Load(object sender, EventArgs e)
        {
            var kitaplar = c.Kitaps.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var silinenKitap = c.Kitaps.Where(x => x.kitapId == secilenId).FirstOrDefault();

            c.Kitaps.Remove(silinenKitap);
            c.SaveChanges();


            var kitaplar = c.Kitaps.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
        }
    }
}
