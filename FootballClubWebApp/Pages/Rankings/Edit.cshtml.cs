using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FootballClubWebApp.BusinessLayer;
using FootballClubWebApp.Data;

namespace FootballClubWebApp.Pages.Rankings
{
    public class EditModel : PageModel
    {
        private readonly FootballClubWebApp.Data.FootballClubDBContext _context;

        public EditModel(FootballClubWebApp.Data.FootballClubDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ranking Ranking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ranking = await _context.Rankings.FirstOrDefaultAsync(m => m.Id == id);

            if (Ranking == null)
            {
                return NotFound();
            }
            ViewData["TeamId"] = new SelectList(_context.TeamInfos, "Id", "TeamName");
            ViewData["YearId"] = new SelectList(_context.YearInfos, "Id", "YearName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Ranking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RankingExists(Ranking.Id))
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

        private bool RankingExists(int id)
        {
            return _context.Rankings.Any(e => e.Id == id);
        }
    }
}
