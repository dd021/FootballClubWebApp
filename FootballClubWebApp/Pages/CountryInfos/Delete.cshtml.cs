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
    public class DeleteModel : PageModel
    {
        private readonly FootballClubWebApp.Data.FootballClubDBContext _context;

        public DeleteModel(FootballClubWebApp.Data.FootballClubDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CountryInfo CountryInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CountryInfo = await _context.CountryInfos.FirstOrDefaultAsync(m => m.Id == id);

            if (CountryInfo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CountryInfo = await _context.CountryInfos.FindAsync(id);

            if (CountryInfo != null)
            {
                _context.CountryInfos.Remove(CountryInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
