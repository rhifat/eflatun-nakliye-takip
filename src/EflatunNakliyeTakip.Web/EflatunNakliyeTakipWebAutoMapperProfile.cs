using AutoMapper;

namespace EflatunNakliyeTakip.Web
{
    public class EflatunNakliyeTakipWebAutoMapperProfile : Profile
    {
        public EflatunNakliyeTakipWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            CreateMap<GiderDto, GiderOlusturDuzenleDto>();

        }
    }
}
