using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FootballClubWebApp.BusinessLayer;
using FootballClubWebApp.Data;

namespace FootballClubWebApp.Pages.CountryInfos
{
    public class CreateModel : PageModel
    {
        private readonly FootballClubWebApp.Data.FootballClubDBContext _context;

        public CreateModel(FootballClubWebApp.Data.FootballClubDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CountryInfo CountryInfo { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CountryInfos.Add(CountryInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
