using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
   public interface ICarRepository
    {

        List<Car> GetCar();
        Car GetCarById(int? id);
        void AddNewCar(Car car);
        void UpdateCar(Car car);
        void RemoveCar(Car car);
    }
}
