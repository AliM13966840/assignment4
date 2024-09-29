using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatAdekunle.Data;
using RecruitCatAdekunle.Models;

namespace RecruitCatAdekunle.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatAdekunle.Data.RecruitCatAdekunleContext _context;

        public CreateModel(RecruitCatAdekunle.Data.RecruitCatAdekunleContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Company.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
