using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FootballClubWebApp.BusinessLayer;
using FootballClubWebApp.Data;

namespace FootballClubWebApp.Pages.TeamInfos
{
    public class DeleteModel : PageModel
    {
        private readonly FootballClubWebApp.Data.FootballClubDBContext _context;

        public DeleteModel(FootballClubWebApp.Data.FootballClubDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TeamInfo TeamInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TeamInfo = await _context.TeamInfos.FirstOrDefaultAsync(m => m.Id == id);

            if (TeamInfo == null)
            {
                return NotFound();
            }
            TeamInfo.CountryInfo = _context.CountryInfos.First(m => m.Id == TeamInfo.CountryID);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TeamInfo = await _context.TeamInfos.FindAsync(id);

            if (TeamInfo != null)
            {
                _context.TeamInfos.Remove(TeamInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
