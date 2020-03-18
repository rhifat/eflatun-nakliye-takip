using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace EflatunNakliyeTakip
{
    public class GelirAppService :
        CrudAppService<Gelir, GelirDto, Guid, PagedAndSortedResultRequestDto,
                       GelirOlusturDuzenleDto, GelirOlusturDuzenleDto>,
        IGelirAppService
    {
        public GelirAppService(IRepository<Gelir, Guid> repository)
            : base(repository)
        {

        }
    }
}