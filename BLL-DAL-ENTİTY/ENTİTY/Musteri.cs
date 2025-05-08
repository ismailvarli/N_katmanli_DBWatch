using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ENTİTY
{
    public class Musteri
    {

        public int MusteriId { get; set; }
       
        [StringLength(20)]
        public string İsim { get; set; }

        [Display(Name ="SoyAdı")]
        [StringLength(20)]
        public string Soyadi { get; set; }

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "Telefon Numarası")]
        [MaxLength(12)]
        public int TelefonNo { get; set; }

        
    }
}
