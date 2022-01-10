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

            KitapListForm kitapL = new KitapListForm();
            kitapL.MdiParent = this;
            kitapL.Show();

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

        private void BtnKullaniciDuzenle_Click(object sender, EventArgs e)
        {
            KullaniciGuncelle kGun = new KullaniciGuncelle();
            kGun.MdiParent = this;
            kGun.Show();
        }

        private void BtnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkleForm ekleKForm = new KitapEkleForm();
            ekleKForm.MdiParent = this;
            ekleKForm.Show();
        }

        private void BtnKitapSil_Click(object sender, EventArgs e)
        {
            KitapSilForm silKForm = new KitapSilForm();
            silKForm.MdiParent = this;
            silKForm.Show();
        }

        private void BtnKitapDuzenle_Click(object sender, EventArgs e)
        {
            KitapDuzenleForm dznKForm = new KitapDuzenleForm();
            dznKForm.MdiParent = this;
            dznKForm.Show();
        }

        private void BtnOduncİslem_Click(object sender, EventArgs e)
        {
            OduncForm oduncF = new OduncForm();
            oduncF.MdiParent = this;
            oduncF.Show();
        }

        private void BtnTeslimAl_Click(object sender, EventArgs e)
        {
            TeslimAlForm teslimF = new TeslimAlForm();
            teslimF.MdiParent = this;
            teslimF.Show();
        }
    }
}
