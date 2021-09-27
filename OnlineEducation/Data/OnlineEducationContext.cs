using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineEducation.Model;

namespace OnlineEducation.Data
{
    public class OnlineEducationContext : DbContext
    {
        public OnlineEducationContext (DbContextOptions<OnlineEducationContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineEducation.Model.Education> Education { get; set; }

        public DbSet<OnlineEducation.Model.Message> Message { get; set; }
    }
}
