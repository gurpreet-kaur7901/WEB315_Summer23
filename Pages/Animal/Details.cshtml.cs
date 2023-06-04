using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Animals.Models;

namespace Animals.Pages_Animals
{
    public class DetailsModel : PageModel
    {
        private readonly AnimalsContext _context;

        public DetailsModel(AnimalsContext context)
        {
            _context = context;
        }

        public Animal Animal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Animal = await _context.Animal.FirstOrDefaultAsync(m => m.ID == id);

            if (Animal == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
