using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P3SectionHttp.Models;

namespace P3SectionHttp.Data
{
    public class P3SectionHttpContext : DbContext
    {
        public P3SectionHttpContext (DbContextOptions<P3SectionHttpContext> options)
            : base(options)
        {
        }

        public DbSet<P3SectionHttp.Models.Student> Student { get; set; } = default!;
    }
}
