using CarShop.Controllers;
using CarShop.Models;
using CarShop.Tests.MockRepos;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop.Tests
{
    class CarsControllerTests
    {
        [Test]
        public void Index_ReturnViewResult_ContainsAllCars()
        {
            // Call method of repositoryMocks GetCar Repo
            var mockCarRepository = RepositoryMocks.GetCarRepos();
            // Create an object
            var carsController = new CarsController(mockCarRepository.Object);
            // return list of object 
            ViewResult result = carsController.Index() as ViewResult;

            // Strore object of cars in list 
            List<Car> cars = result.ViewData.Model as List<Car>;

            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsAssignableFrom<List<Car>>(result.ViewData.Model);
            //Check count of my list , Do i have one car on my list? 
            
            Assert.AreEqual(1, cars.Count);

        }
    }
}
