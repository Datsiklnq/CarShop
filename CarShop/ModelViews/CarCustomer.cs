using CarShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.ModelViews
{
    public class CarCustomer
    {
        public Car Car { get; set; }
        public Customer Customer { get; set; }
        public Purchase Purchase { get; set; }
    }
}
