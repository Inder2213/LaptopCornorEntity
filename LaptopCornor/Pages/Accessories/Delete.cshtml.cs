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
    public class DeleteModel : PageModel
    {
        private readonly LaptopCornor.Data.LaptopCornorContext _context;

        public DeleteModel(LaptopCornor.Data.LaptopCornorContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Acessory = await _context.Acessory.FindAsync(id);

            if (Acessory != null)
            {
                _context.Acessory.Remove(Acessory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
