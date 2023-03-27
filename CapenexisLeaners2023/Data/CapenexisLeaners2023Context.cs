using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapenexisLeaners2023.Models;

namespace CapenexisLeaners2023.Data
{
    public class CapenexisLeaners2023Context : DbContext
    {
        public CapenexisLeaners2023Context (DbContextOptions<CapenexisLeaners2023Context> options)
            : base(options)
        {
        }

        public DbSet<CapenexisLeaners2023.Models.Courses> Courses { get; set; } = default!;

        public DbSet<CapenexisLeaners2023.Models.Learners> Learners { get; set; } = default!;

        public DbSet<CapenexisLeaners2023.Models.Facilitators> Facilitators { get; set; } = default!;
    }
}
