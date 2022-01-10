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
    public partial class TeslimAlForm : Form
    {
        public TeslimAlForm()
        {
            InitializeComponent();
        }

        Context c = new Context();

        private void TeslimAlForm_Load(object sender, EventArgs e)
        {
            // sadece teslim edilmemiş kitaplar listelenir.
            var oduncList = c.Oduncs.Where(x => x.oduncTeslimDurum == false).ToList();
            dataGridView1.DataSource = oduncList.ToList();
            dataGridView1.Columns[3].Visible = false;
        }

        private void BtnTslm_Click(object sender, EventArgs e)
        {
            int secilenOduncId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = c.Oduncs.Where(x => x.oduncId == secilenOduncId).FirstOrDefault();

            kayit.oduncTeslimDurum = true;
            c.SaveChanges();

            var oduncList = c.Oduncs.Where(x => x.oduncTeslimDurum == false).ToList();
            dataGridView1.DataSource = oduncList.ToList();
            dataGridView1.Columns[3].Visible = false;
        }
    }
}
