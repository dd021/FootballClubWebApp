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

namespace FootballClubWebApp.Pages.YearInfos
{
    public class EditModel : PageModel
    {
        private readonly FootballClubWebApp.Data.FootballClubDBContext _context;

        public EditModel(FootballClubWebApp.Data.FootballClubDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public YearInfo YearInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            YearInfo = await _context.YearInfos.FirstOrDefaultAsync(m => m.Id == id);

            if (YearInfo == null)
            {
                return NotFound();
            }
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

            _context.Attach(YearInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YearInfoExists(YearInfo.Id))
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

        private bool YearInfoExists(int id)
        {
            return _context.YearInfos.Any(e => e.Id == id);
        }
    }
}
