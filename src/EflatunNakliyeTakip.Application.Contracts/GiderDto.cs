using System;
using Volo.Abp.Application.Dtos;

namespace EflatunNakliyeTakip
{
    public class GiderDto : AuditedEntityDto<Guid>
    {
        public string Vasita { get; set; }
        public MasrafTipi Masraf { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string Aciklama { get; set; }
        public float Miktar { get; set; }
    }
    
    
}
