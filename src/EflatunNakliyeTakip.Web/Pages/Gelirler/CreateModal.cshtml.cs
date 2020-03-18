using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EflatunNakliyeTakip.Web.Pages.Gelirler

{
    public class CreateModalModel : EflatunNakliyeTakipPageModel
    {
        [BindProperty]
        public GelirOlusturDuzenleDto Gelir { get; set; }

        private readonly IGelirAppService _gelirAppService;

        public CreateModalModel(IGelirAppService gelirAppService)
        {
            _gelirAppService = gelirAppService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _gelirAppService.CreateAsync(Gelir);
            return NoContent();
        }
    }
}