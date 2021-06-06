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
    public class IndexModel : PageModel
    {
        private readonly FootballClubWebApp.Data.FootballClubDBContext _context;

        public IndexModel(FootballClubWebApp.Data.FootballClubDBContext context)
        {
            _context = context;
        }

        public IList<Ranking> Ranking { get;set; }

        public async Task OnGetAsync()
        {
            Ranking = await _context.Rankings.OrderByDescending(r => r.YearID)
                .ThenByDescending(r => r.ValueInMillions).ToListAsync();
            foreach(Ranking ranking in Ranking)
            {
                ranking.TeamInfo = _context.TeamInfos.First(t => t.Id == ranking.TeamID);
                ranking.YearInfo = _context.YearInfos.First(t => t.Id == ranking.YearID);
            }
        }
    }
}
