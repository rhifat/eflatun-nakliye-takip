using System;
using Volo.Abp.Application.Dtos;

namespace EflatunNakliyeTakip
{
    public class GelirDto : AuditedEntityDto<Guid>
    {
        public DateTime IslemTarihi { get; set; }
        public string Vasita { get; set; }
        public string YukCikisNoktasi { get; set; }
        public string YukVarisNoktasi { get; set; }
        public string YuklenenFirma { get; set; }
        public string GoturulecekFirma { get; set; }
        public int YukTonaj { get; set; }
        public int VasitaKm { get; set; }
        public string Aciklama { get; set; }
        public double Miktar { get; set; }
    }


}
