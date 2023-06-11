using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Animal.Models;

namespace Animal.Pages_Infos
{
    public class CreateModel : PageModel
    {
        private readonly AnimalContext _context;

        public CreateModel(AnimalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Info Info { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Info.Add(Info);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
