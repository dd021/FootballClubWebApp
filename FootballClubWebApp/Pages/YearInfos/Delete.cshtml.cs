using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FootballClubWebApp.BusinessLayer;
using FootballClubWebApp.Data;

namespace FootballClubWebApp.Pages.YearInfos
{
    public class DeleteModel : PageModel
    {
        private readonly FootballClubWebApp.Data.FootballClubDBContext _context;

        public DeleteModel(FootballClubWebApp.Data.FootballClubDBContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            YearInfo = await _context.YearInfos.FindAsync(id);

            if (YearInfo != null)
            {
                _context.YearInfos.Remove(YearInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
