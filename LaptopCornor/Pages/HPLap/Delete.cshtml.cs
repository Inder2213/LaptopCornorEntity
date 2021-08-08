using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LaptopCornor.Data;
using LaptopCornor.Models;

namespace LaptopCornor.Pages.HPLap
{
    public class DeleteModel : PageModel
    {
        private readonly LaptopCornor.Data.LaptopCornorContext _context;

        public DeleteModel(LaptopCornor.Data.LaptopCornorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HP HP { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HP = await _context.HP.FirstOrDefaultAsync(m => m.Id == id);

            if (HP == null)
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

            HP = await _context.HP.FindAsync(id);

            if (HP != null)
            {
                _context.HP.Remove(HP);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
