using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LaptopCornor.Data;
using LaptopCornor.Models;

namespace LaptopCornor.Pages.Accessories
{
    public class IndexModel : PageModel
    {
        private readonly LaptopCornor.Data.LaptopCornorContext _context;

        public IndexModel(LaptopCornor.Data.LaptopCornorContext context)
        {
            _context = context;
        }

        public IList<Acessory> Acessory { get;set; }

        public async Task OnGetAsync()
        {
            Acessory = await _context.Acessory.ToListAsync();
        }
    }
}
