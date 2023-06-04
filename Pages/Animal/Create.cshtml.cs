using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Animals.Models;

namespace Animals.Pages_Animals
{
    public class CreateModel : PageModel
    {
        private readonly AnimalsContext _context;

        public CreateModel(AnimalsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Animal Animal { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Animal.Add(Animal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
