﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatAdekunle.Data;
using RecruitCatAdekunle.Models;

namespace RecruitCatAdekunle.Pages.Industries
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatAdekunle.Data.RecruitCatAdekunleContext _context;

        public DeleteModel(RecruitCatAdekunle.Data.RecruitCatAdekunleContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Industry Industry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var industry = await _context.Industry.FirstOrDefaultAsync(m => m.Id == id);

            if (industry == null)
            {
                return NotFound();
            }
            else
            {
                Industry = industry;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var industry = await _context.Industry.FindAsync(id);
            if (industry != null)
            {
                Industry = industry;
                _context.Industry.Remove(Industry);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
