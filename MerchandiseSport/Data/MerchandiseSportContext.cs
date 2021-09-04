using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MerchandiseSport.Models;

namespace MerchandiseSport.Data
{
    public class MerchandiseSportContext : DbContext
    {
        public MerchandiseSportContext (DbContextOptions<MerchandiseSportContext> options)
            : base(options)
        {
        }

        public DbSet<MerchandiseSport.Models.Users> Users { get; set; }

        public DbSet<MerchandiseSport.Models.Product> Product { get; set; }

        public DbSet<MerchandiseSport.Models.Category> Category { get; set; }

        
    }
}
