using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EflatunNakliyeTakip
{
    public class GelirOlusturDuzenleDto
    {
        [Required]
        [DisplayFormat(DataFormatString = "{0:d MMM \\'yy}")]       
        public DateTime IslemTarihi { get; set; }
        [Required]
        [StringLength(128)]
        public string Vasita { get; set; }
        [Required]
        [StringLength(128)]
        public string YukCikisNoktasi { get; set; }
        [Required]
        [StringLength(128)]
        public string YukVarisNoktasi { get; set; }
       
        [StringLength(128)]
        public string YuklenenFirma { get; set; }
        
        [StringLength(128)]
        public string GoturulecekFirma { get; set; }
        public int YukTonaj { get; set; }
        public int VasitaKm { get; set; }
        public string Aciklama { get; set; }
        [Required]
        public double Miktar { get; set; }
    }
}
