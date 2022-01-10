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
    public partial class KitapListForm : Form
    {
        public KitapListForm()
        {
            InitializeComponent();
        }
        Context c = new Context();
        public void Listele()
        {

            var kitaplar = c.Kitaps.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
        }
        private void KitapListForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
