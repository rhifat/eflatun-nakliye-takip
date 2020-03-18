using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace EflatunNakliyeTakip
{
    public class Gider : AuditedAggregateRoot<Guid>
    {
        public string Vasita { get; set; }
        public MasrafTipi Masraf { get; set; }

        [DisplayFormat(DataFormatString = "{0:d MMM \\'yy}")]        
        public DateTime IslemTarihi { get; set; }
        public string Aciklama { get; set; }
        public float Miktar { get; set; }

        protected Gider()
        {

        }

        public Gider(Guid id, string vasita, MasrafTipi masraf, DateTime islemTarihi, float miktar) :
            base(id)
        {
            Vasita = vasita;
            Masraf = masraf;
            IslemTarihi = islemTarihi;
            Miktar = miktar;
        }
    }
}
