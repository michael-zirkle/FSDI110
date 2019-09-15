using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Project.Models
{


    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Representative> Representatives { get; set; }
    }
}