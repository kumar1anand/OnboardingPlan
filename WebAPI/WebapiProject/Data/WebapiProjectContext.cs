using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebapiProject;

namespace WebapiProject.Data
{
    public class WebapiProjectContext : DbContext
    {
        public WebapiProjectContext (DbContextOptions<WebapiProjectContext> options)
            : base(options)
        {
        }

        public DbSet<WebapiProject.Employee> Employee { get; set; } = default!;
        public DbSet<WebapiProject.AlphaEmployee> AlphaEmployee { get; set; } = default!;
    }
}
