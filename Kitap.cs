using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Kitap
    {
        [Key]
        public int kitapId { get; set; }
        public string kitapAd { get; set; }
        public string kitapYazar { get; set; }
        public string kitapKonum { get; set; }

    }
}
