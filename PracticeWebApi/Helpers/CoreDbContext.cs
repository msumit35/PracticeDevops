using Microsoft.EntityFrameworkCore;
using PracticeWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeWebApi.Helpers
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
