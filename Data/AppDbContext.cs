using System;
using Microsoft.EntityFrameworkCore;
using uppfinnaren_1_0_seb_kvist.Models;

namespace uppfinnaren_1_0_seb_kvist.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Product> Products {get; set;} = default!;
    }
    
}

