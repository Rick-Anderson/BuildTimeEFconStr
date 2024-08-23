using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BuildTimeEFconStr.Data
{
    public class BuildTimeEFconStrContext : DbContext
    {
        public BuildTimeEFconStrContext (DbContextOptions<BuildTimeEFconStrContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
