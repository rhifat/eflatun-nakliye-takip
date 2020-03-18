using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EflatunNakliyeTakip
{
    public class GiderOlusturDuzenleDto
    {
        [Required]
        [StringLength(128)]
        public string Vasita { get; set; }
        [Required]
        public MasrafTipi Masraf { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:d MMM \\'yy}")]
        public DateTime IslemTarihi { get; set; }
        [Required]
        public string Aciklama { get; set; }
        [Required]
        public float Miktar { get; set; }
    }
}
