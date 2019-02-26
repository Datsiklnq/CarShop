

using CarShop.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop.Tests.MockRepos
{
    public class RepositoryMocks
    {
        public static Mock<ICarRepository> GetCarRepos()
        {
            var cars = new List<Car>
            {
                new Car
                {
             Brand = "BMW" ,
             Model  = "I8" ,
             Engine  = 3.0,
             Year = 2018,
             Price = 100000,
             Description = "Wrrrrrr",
             ImageUrl = "https://photos7.motorcar.com/new-2019-bmw-i8-roadster-8436-18318286-3-1024.jpg"
    },
           
            };

            var mockCarRepository = new Mock<ICarRepository>();
            mockCarRepository.Setup(repo => repo.GetCar()).Returns(cars);
            mockCarRepository.Setup(repo => repo.GetCarById(It.IsAny<int>())).Returns(cars[0]);
            return mockCarRepository;
        }
    }
}
