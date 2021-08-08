using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LaptopCornor.Data;
using LaptopCornor.Models;

namespace LaptopCornor.Pages.AsusLap
{
    public class DeleteModel : PageModel
    {
        private readonly LaptopCornor.Data.LaptopCornorContext _context;

        public DeleteModel(LaptopCornor.Data.LaptopCornorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Asus Asus { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Asus = await _context.Asus.FirstOrDefaultAsync(m => m.Id == id);

            if (Asus == null)
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

            Asus = await _context.Asus.FindAsync(id);

            if (Asus != null)
            {
                _context.Asus.Remove(Asus);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
