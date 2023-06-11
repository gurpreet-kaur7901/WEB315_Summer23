using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Animal.Models;

namespace Animal.Pages_Infos
{
    public class DetailsModel : PageModel
    {
        private readonly AnimalContext _context;

        public DetailsModel(AnimalContext context)
        {
            _context = context;
        }

        public Info Info { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Info = await _context.Info.FirstOrDefaultAsync(m => m.ID == id);

            if (Info == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
