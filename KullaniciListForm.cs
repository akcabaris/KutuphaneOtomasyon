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
    public partial class KullaniciListForm : Form
    {
        public KullaniciListForm()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            Context c = new Context();
            var kullanicililar = c.Kullanicis.ToList();
            dataGridView1.DataSource = kullanicililar.ToList();
            dataGridView1.Columns[2].Visible = false;

            dataGridView1.Columns[6].Visible = false;
        }
        private void KullaniciListForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
