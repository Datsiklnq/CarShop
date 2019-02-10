using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class CustomerService : ICustomerRepository
    {
        private readonly CarShopContext _context;

        public CustomerService(CarShopContext context)
        {
            _context = context;
        }
        public void AddNewCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
        }

        public Customer GetCustomerById(int? id)
        {
            var customer = _context.Customer.FirstOrDefault(p => p.Id == id);

            return customer;
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customer.ToList();
           
        }

        public void RemoveCustomer(Customer customer)
        {
            _context.Customer.Remove(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
        }
    }
}
