using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FootballClubWebApp.BusinessLayer;
using FootballClubWebApp.Data;

namespace FootballClubWebApp.Pages.CountryInfos
{
    public class IndexModel : PageModel
    {
        private readonly FootballClubWebApp.Data.FootballClubDBContext _context;

        public IndexModel(FootballClubWebApp.Data.FootballClubDBContext context)
        {
            _context = context;
        }

        public IList<CountryInfo> CountryInfo { get;set; }

        public async Task OnGetAsync()
        {
            CountryInfo = await _context.CountryInfos.ToListAsync();
        }
    }
}
