using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FootballClubWebApp.BusinessLayer;
using FootballClubWebApp.Data;

namespace FootballClubWebApp.Pages.Rankings
{
    public class DeleteModel : PageModel
    {
        private readonly FootballClubWebApp.Data.FootballClubDBContext _context;

        public DeleteModel(FootballClubWebApp.Data.FootballClubDBContext context)
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

            Ranking.TeamInfo = _context.TeamInfos.First(t => t.Id == Ranking.TeamID);
            Ranking.YearInfo = _context.YearInfos.First(t => t.Id == Ranking.YearID);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ranking = await _context.Rankings.FindAsync(id);

            if (Ranking != null)
            {
                _context.Rankings.Remove(Ranking);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
