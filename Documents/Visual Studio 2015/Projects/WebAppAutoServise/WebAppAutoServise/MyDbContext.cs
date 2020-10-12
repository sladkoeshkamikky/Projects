using System;
using System.Data.Entity;
using WebAppAutoServise.Class;

namespace WebAppAutoServise
{
    public class MyDbContext : DbContext
    {

        public MyDbContext() 
        {
        }
        public DbSet<Auto> Auto { get; set; }
        public DbSet<Car_Brand> Car_Brand { get; set; }


    }
}