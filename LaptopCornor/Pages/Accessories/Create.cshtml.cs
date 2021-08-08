using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LaptopCornor.Data;
using LaptopCornor.Models;

namespace LaptopCornor.Pages.Accessories
{
    public class CreateModel : PageModel
    {
        private readonly LaptopCornor.Data.LaptopCornorContext _context;

        public CreateModel(LaptopCornor.Data.LaptopCornorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Acessory Acessory { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Acessory.Add(Acessory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
