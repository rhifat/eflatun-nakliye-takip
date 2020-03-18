using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EflatunNakliyeTakip
{
    public interface IGiderAppService :
        ICrudAppService<
            GiderDto,
            Guid,
            PagedAndSortedResultRequestDto,
            GiderOlusturDuzenleDto,
            GiderOlusturDuzenleDto>
    {
    }
}
