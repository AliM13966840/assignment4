using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatAdekunle.Data;
using RecruitCatAdekunle.Models;
using Microsoft.EntityFrameworkCore;

namespace RecruitCatAdekunle.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatAdekunle.Data.RecruitCatAdekunleContext _context;

        public CreateModel(RecruitCatAdekunle.Data.RecruitCatAdekunleContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> OnGetAsync()
        {
            // Fetch job titles from the database
            var jobTitles = await _context.JobTitle.ToListAsync();

            // Populate the SelectList
            ViewData["JobTitleId"] = new SelectList(jobTitles, "Id", "Title");

            // Fetch job titles from the database
            var companies = await _context.Company.ToListAsync();

            // Populate the SelectList
            ViewData["CompanyId"] = new SelectList(companies, "Id", "Name");

            return Page();
        }

        //public IActionResult OnGet()
        //{
            
        //   ViewData["JobTitleId"] = new SelectList(_context.JobTitles, "Id", "Title");
        //   //ViewData["JobTitleId"] = new SelectList(_context.JobTitles?.ToList() ?? new List<JobTitle>(), "Id", "Title");

        //    return Page();
        //}

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["JobTitleId"] = new SelectList(_context.JobTitles, "Id", "Title");

                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
