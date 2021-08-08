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
    public class DetailsModel : PageModel
    {
        private readonly LaptopCornor.Data.LaptopCornorContext _context;

        public DetailsModel(LaptopCornor.Data.LaptopCornorContext context)
        {
            _context = context;
        }

        public Acessory Acessory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Acessory = await _context.Acessory.FirstOrDefaultAsync(m => m.Id == id);

            if (Acessory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
