using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class CarService : ICarRepository
    {
        private readonly CarShopContext _context;

        public CarService(CarShopContext context)
        {
            _context = context;
        }

        public void AddNewCar(Car car)
        {
            _context.Add(car);
            _context.SaveChanges();
        }

        public List<Car> GetCar()
        {
            return _context.Car.ToList();
        }

        public Car GetCarById(int? id)
        {
            var car = _context.Car
                .FirstOrDefault(p => p.Id == id);

            return car;
        }

        public void RemoveCar(Car car)
        {
            _context.Car.Remove(car);
            _context.SaveChanges();
        }

        public void UpdateCar(Car car)
        {
            _context.Update(car);
            _context.SaveChanges();
        }
    }
}
