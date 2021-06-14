using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie7.Data;
using RazorPagesMovie7.Models;

namespace RazorPagesMovie7.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie7.Data.RazorPagesMovie7Context _context;

        public DetailsModel(RazorPagesMovie7.Data.RazorPagesMovie7Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
