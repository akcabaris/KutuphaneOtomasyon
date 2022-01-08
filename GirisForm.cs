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
    public partial class GirisForm : Form
    {
        
        public GirisForm()
        {
            
            InitializeComponent();
            
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            //*context c yi yukardan aldım tekrar denicem 
            Context c = new Context();
            string gelenTc = TxtGirisTC.Text;
            string gelenSifre = TxtGirisSifre.Text;
            /*
            var kkk = c.Kullanicis.Where(x => x.kullaniciTc.Equals(gelenTc) && x.kullaniciSifre.Equals(gelenSifre)).FirstOrDefault();

            if (kkk == null)
            {
                MessageBox.Show(text: "Giriş Başarısız. Şifre ya da Kullanıcı adı Hatalı!");
            }
            else
            {
                MessageBox.Show(text: "Giriş Başarılı");
            }

            */
            this.Hide();
            AnaForm anaF = new AnaForm();
            anaF.Show();
        }
        
    }
}
