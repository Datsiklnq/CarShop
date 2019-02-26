using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CarShop.Models
{
    public class CarShopContext : IdentityDbContext<IdentityUser>
    {
        public CarShopContext (DbContextOptions<CarShopContext> options)
            : base(options)
        {
        }

        public DbSet<CarShop.Models.Car> Car { get; set; }

        public DbSet<CarShop.Models.Customer> Customer { get; set; }

        public DbSet<CarShop.Models.Purchase> Purchase { get; set; }

        public DbSet<CarShop.Models.Feedback> Feedback { get; set; }

    }
}
