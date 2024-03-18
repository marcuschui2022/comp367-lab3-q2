using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAgileProcess.Models;

namespace MVCAgileProcess.Data
{
    public class MVCAgileProcessContext : DbContext
    {
        public MVCAgileProcessContext (DbContextOptions<MVCAgileProcessContext> options)
            : base(options)
        {
        }

        public DbSet<MVCAgileProcess.Models.Movie> Movie { get; set; } = default!;
    }
}
