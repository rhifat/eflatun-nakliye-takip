using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EflatunNakliyeTakip.Web.Pages.Giderler
{
    public class CreateModalModel : EflatunNakliyeTakipPageModel
    {
        [BindProperty]
        public GiderOlusturDuzenleDto Gider { get; set; }

        private readonly IGiderAppService _giderAppService;

        public CreateModalModel(IGiderAppService bookAppService)
        {
            _giderAppService = bookAppService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _giderAppService.CreateAsync(Gider);
            return NoContent();
        }
    }
}