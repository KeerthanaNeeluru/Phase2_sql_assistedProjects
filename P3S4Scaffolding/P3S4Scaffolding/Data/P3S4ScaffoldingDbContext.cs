using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P3S4Scaffolding.Models;

namespace P3S4Scaffolding.Data
{
    public class P3S4ScaffoldingDbContext : DbContext
    {
        public P3S4ScaffoldingDbContext (DbContextOptions<P3S4ScaffoldingDbContext> options)
            : base(options)
        {
        }

        public DbSet<P3S4Scaffolding.Models.Student> Student { get; set; } = default!;
    }
}
