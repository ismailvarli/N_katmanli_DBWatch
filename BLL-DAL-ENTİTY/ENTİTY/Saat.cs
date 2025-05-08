using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTİTY
{
    public class Saat
    {
        public int SaatId { get; set; }

        [StringLength(80)]
        public string İsim { get; set; }

        [Display(Name = "Stok Sayısı")]
        public  int Stok_Sayisi { get; set; }

        [StringLength(50)]
        public string Marka { get; set; }

        public decimal Fiyat { get; set; }

        public string Cinsiyet { get; set; }
    }
}
