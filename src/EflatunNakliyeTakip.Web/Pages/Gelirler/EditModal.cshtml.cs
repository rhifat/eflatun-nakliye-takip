using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EflatunNakliyeTakip.Web.Pages.Gelirler
{
    public class EditModalModel : EflatunNakliyeTakipPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }
        [BindProperty]
        public GelirOlusturDuzenleDto Gelir { get; set; }

        private readonly IGelirAppService _gelirAppService;
        public EditModalModel(IGelirAppService gelirAppService)
        {
            _gelirAppService = gelirAppService;
        }

        public async Task GetTaskAsync()
        {
            var gelirDto = await _gelirAppService.GetAsync(Id);
            Gelir = ObjectMapper.Map<GelirDto, GelirOlusturDuzenleDto>(gelirDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _gelirAppService.UpdateAsync(Id, Gelir);
            return NoContent();
        }
    }
}