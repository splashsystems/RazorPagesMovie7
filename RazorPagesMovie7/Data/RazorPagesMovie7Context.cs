using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie7.Models;

namespace RazorPagesMovie7.Data
{
    public class RazorPagesMovie7Context : DbContext
    {
        public RazorPagesMovie7Context (DbContextOptions<RazorPagesMovie7Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie7.Models.Movie> Movie { get; set; }
    }
}
