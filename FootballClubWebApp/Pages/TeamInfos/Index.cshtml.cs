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
    public class IndexModel : PageModel
    {
        private readonly FootballClubWebApp.Data.FootballClubDBContext _context;

        public IndexModel(FootballClubWebApp.Data.FootballClubDBContext context)
        {
            _context = context;
        }

        public IList<TeamInfo> TeamInfo { get;set; }

        public async Task OnGetAsync()
        {
            TeamInfo = await _context.TeamInfos.ToListAsync();
            foreach(TeamInfo team in TeamInfo)
            {
                team.CountryInfo = _context.CountryInfos.First(m => m.Id == team.CountryID);
            }
        }
    }
}
