using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MUTLUHAN;Database=ReCapProject;Integrated Security=True");
        }
        public DbSet<Color> Color { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Brand> Brand { get; set; }
    }
}
