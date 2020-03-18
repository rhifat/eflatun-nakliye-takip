using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EflatunNakliyeTakip.Web.Pages.Giderler
{
    public class EditModalModel : EflatunNakliyeTakipPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet =true)]
        public Guid Id { get; set; }
        [BindProperty]
        public GiderOlusturDuzenleDto Gider { get; set; }

        private readonly IGiderAppService _giderAppService;
        public EditModalModel(IGiderAppService giderAppService)
        {
            _giderAppService = giderAppService;
        }

        public async Task GetTaskAsync()
        {
            var giderDto = await _giderAppService.GetAsync(Id);
            Gider = ObjectMapper.Map<GiderDto, GiderOlusturDuzenleDto>(giderDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _giderAppService.UpdateAsync(Id, Gider);
            return NoContent();
        }
    }
}