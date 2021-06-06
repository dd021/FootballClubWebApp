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

namespace FootballClubWebApp.Pages.TeamInfos
{
    public class EditModel : PageModel
    {
        private readonly FootballClubWebApp.Data.FootballClubDBContext _context;

        public EditModel(FootballClubWebApp.Data.FootballClubDBContext context)
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
            ViewData["CountryId"] = new SelectList(_context.CountryInfos, "Id", "CountryName");
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

            _context.Attach(TeamInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamInfoExists(TeamInfo.Id))
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

        private bool TeamInfoExists(int id)
        {
            return _context.TeamInfos.Any(e => e.Id == id);
        }
    }
}
