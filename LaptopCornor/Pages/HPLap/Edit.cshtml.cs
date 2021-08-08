using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaptopCornor.Data;
using LaptopCornor.Models;

namespace LaptopCornor.Pages.HPLap
{
    public class EditModel : PageModel
    {
        private readonly LaptopCornor.Data.LaptopCornorContext _context;

        public EditModel(LaptopCornor.Data.LaptopCornorContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HP).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HPExists(HP.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HPExists(int id)
        {
            return _context.HP.Any(e => e.Id == id);
        }
    }
}
