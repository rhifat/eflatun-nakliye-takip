using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace EflatunNakliyeTakip
{
    public class Gelir : AuditedAggregateRoot<Guid>
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

        protected Gelir()
        {

        }

        public Gelir(Guid id, DateTime islemTarihi, string vasita, string yukCikisNoktasi, string yukVarisNoktasi, string yuklenenFirma, 
            string goturulecekFirma, int yukTonaj, int vasitaKm, string aciklama, double miktar) :
            base(id)
        {
            IslemTarihi = islemTarihi;
            YukCikisNoktasi = yukCikisNoktasi;
            YukVarisNoktasi = yukVarisNoktasi;
            YuklenenFirma = yuklenenFirma;
            GoturulecekFirma = goturulecekFirma;
            YukTonaj = yukTonaj;
            VasitaKm = vasitaKm;
            Aciklama = aciklama;
            Vasita = vasita; 
            Miktar = miktar;
        }
    }
}
