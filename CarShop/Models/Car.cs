using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class Car
    {
        public int Id{ get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Engine { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
