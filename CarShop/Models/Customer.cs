using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        [Display(Name = "Date Of birth ")]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Town{ get; set; }
        public string County { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
    }
}
