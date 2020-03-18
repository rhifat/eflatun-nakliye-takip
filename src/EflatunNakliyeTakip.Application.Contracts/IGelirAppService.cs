using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EflatunNakliyeTakip
{
    public interface IGelirAppService :
        ICrudAppService<
            GelirDto,
            Guid,
            PagedAndSortedResultRequestDto,
            GelirOlusturDuzenleDto,
            GelirOlusturDuzenleDto>
    {
    }
}
