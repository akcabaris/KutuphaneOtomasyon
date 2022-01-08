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
    public partial class AnaForm : Form
    {
        Context c = new Context();
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

            BtnKullaniciEkle.Visible = false;
            BtnKullaniciSil.Visible = false;
            BtnKullaniciDuzenle.Visible = false;
            BtnKitapEkle.Visible = false;
            BtnKitapSil.Visible = false;
            BtnKitapDuzenle.Visible = false;

        }

        private void BtnKullanicilar_Click(object sender, EventArgs e)
        {
            if (BtnKullaniciEkle.Visible == false) {
                BtnKullaniciEkle.Visible = true;
                BtnKullaniciSil.Visible = true;
                BtnKullaniciDuzenle.Visible = true;
            }
            else
            {
                BtnKullaniciEkle.Visible = false;
                BtnKullaniciSil.Visible = false;
                BtnKullaniciDuzenle.Visible = false;
            }

            KullaniciListForm kListeForm = new KullaniciListForm();
            kListeForm.MdiParent = this;
            kListeForm.Show();

        }

        private void BtnKitaplar_Click(object sender, EventArgs e)
        {
            if (BtnKitapEkle.Visible == false) {
                BtnKitapEkle.Visible = true;
                BtnKitapSil.Visible = true;
                BtnKitapDuzenle.Visible = true;
            }

            else
            {
                BtnKitapEkle.Visible = false;
                BtnKitapSil.Visible = false;
                BtnKitapDuzenle.Visible = false;
            }

        }

        private void BtnKullaniciEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }

        private void BtnKullaniciSil_Click(object sender, EventArgs e)
        {
            KullaniciSilForm kSil = new KullaniciSilForm();
            kSil.MdiParent = this;
            kSil.Show();
        }
    }
}
