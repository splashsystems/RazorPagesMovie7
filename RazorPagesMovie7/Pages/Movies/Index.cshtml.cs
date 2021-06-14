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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie7.Data.RazorPagesMovie7Context _context;

        public IndexModel(RazorPagesMovie7.Data.RazorPagesMovie7Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
