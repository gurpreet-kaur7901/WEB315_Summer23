using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Animal.Models;

namespace Animal.Pages_Infos
{
    public class IndexModel : PageModel
    {
        private readonly AnimalContext _context;

        public IndexModel(AnimalContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Color { get; set; }
         [BindProperty(SupportsGet = true)]
        public string InfoColor { get; set; }
        public IList<Info> Info { get;set; }


        public async Task OnGetAsync()
        {

             IQueryable<string> ColorQuery = from m in _context.Info
                                    orderby m.Color
                                    select m.Color;

            var Infos = from m in _context.Info
                        select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                Infos = Infos.Where(s => s.Name.Contains(SearchString));
            }

             if (!string.IsNullOrEmpty(InfoColor))
            {
                Infos = Infos.Where(x => x.Color == InfoColor);
            } 
        Color = new SelectList(await ColorQuery.Distinct().ToListAsync());
             

           Info = await Infos.ToListAsync();
        }
    }
}
