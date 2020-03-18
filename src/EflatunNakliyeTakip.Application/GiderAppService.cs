using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace EflatunNakliyeTakip
{
    public class GiderAppService :
        CrudAppService<Gider, GiderDto, Guid, PagedAndSortedResultRequestDto,
                       GiderOlusturDuzenleDto, GiderOlusturDuzenleDto>,
        IGiderAppService
    {
        public GiderAppService(IRepository<Gider, Guid> repository)
            : base(repository)
        {

        }
    }
}