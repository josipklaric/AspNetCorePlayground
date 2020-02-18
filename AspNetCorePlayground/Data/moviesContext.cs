using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCorePlayground.Models;

namespace AspNetCorePlayground.Data
{
    public class moviesContext : DbContext
    {
        public moviesContext (DbContextOptions<moviesContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCorePlayground.Models.Movie> Movie { get; set; }
    }
}
