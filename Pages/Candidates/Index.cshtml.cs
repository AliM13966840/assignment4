using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatAdekunle.Data;
using RecruitCatAdekunle.Models;

namespace RecruitCatAdekunle.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatAdekunle.Data.RecruitCatAdekunleContext _context;

        public IndexModel(RecruitCatAdekunle.Data.RecruitCatAdekunleContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate.ToListAsync();
        }
    }
}
