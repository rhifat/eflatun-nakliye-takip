using AutoMapper;

namespace EflatunNakliyeTakip
{
    public class EflatunNakliyeTakipApplicationAutoMapperProfile : Profile
    {
        public EflatunNakliyeTakipApplicationAutoMapperProfile()
        {

            CreateMap<Gider, GiderDto>();
            CreateMap<Gelir, GelirDto>();

            CreateMap<GiderOlusturDuzenleDto, Gider>();
            CreateMap<GelirOlusturDuzenleDto, Gelir>();

            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
        }
    }
}
