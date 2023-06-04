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
    public class IndexModel : PageModel
    {
        private readonly AnimalsContext _context;

        public IndexModel(AnimalsContext context)
        {
            _context = context;
        }

        public IList<Animal> Animal { get;set; }

        public async Task OnGetAsync()
        {
            Animal = await _context.Animal.ToListAsync();
        }
    }
}
