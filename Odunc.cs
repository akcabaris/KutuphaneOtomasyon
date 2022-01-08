using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{


    public class Odunc
    {
        [Key]
        public int oduncId { get; set; }
        public int oduncKitapId { get; set; }
        public string oduncKitapAd { get; set; }
        public string oduncKullaniciTc { get; set; }
        public Boolean oduncTeslimDurum { get; set; }
    }
}
