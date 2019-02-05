using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarShop.Models;

namespace CarShop.Models
{
    public class CarShopContext : DbContext
    {
        public CarShopContext (DbContextOptions<CarShopContext> options)
            : base(options)
        {
        }

        public DbSet<CarShop.Models.Car> Car { get; set; }

        public DbSet<CarShop.Models.Customer> Customer { get; set; }

        public DbSet<CarShop.Models.Purchase> Purchase { get; set; }
    }
}
