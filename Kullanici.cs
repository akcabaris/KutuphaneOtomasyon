using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Kullanici
    {

        [Key]
        public int kullaniciId { get; set; }
        public int kullaniciTc { get; set; }
        public string kullaniciSifre { get; set; }

        public string kullaniciAdSoyad { get; set; }
        public string kullaniciTipi { get; set; }
        public string KullaniciMail { get; set; }
        public int kullaniciCeza { get; set; }
    }
}
