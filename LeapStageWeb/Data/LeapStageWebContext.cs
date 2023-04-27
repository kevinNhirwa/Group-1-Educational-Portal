using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LeapStageWeb.Models
{
    public class LeapStageWebContext : DbContext
    {
        public LeapStageWebContext (DbContextOptions<LeapStageWebContext> options)
            : base(options)
        {
        }

        public DbSet<LeapStageWeb.Models.Course> Course { get; set; }
    }
}
