using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarShop.Models;
using CarShop.ModelViews;

namespace CarShop.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly ICarRepository _carRepository;
        private readonly ICustomerRepository _customerRepository;

        public PurchasesController(IPurchaseRepository purchaseRepository, ICarRepository carRepository, ICustomerRepository customerRepository)
        {
            _purchaseRepository = purchaseRepository;
            _carRepository = carRepository;
            _customerRepository = customerRepository;
        }

        // GET: Purchases
        public IActionResult Index()
        {
            List<CarCustomer> carCustomers = new List<CarCustomer>();
            foreach (Purchase purchase in _purchaseRepository.GetPurchases())
            {
                CarCustomer carCustomer = new CarCustomer
                {
                    Car = _carRepository.GetCarById(purchase.CarId),
                    Customer = _customerRepository.GetCustomerById(purchase.CustomerId),
                    Purchase = purchase
                };

                carCustomers.Add(carCustomer);
            }

            return View(carCustomers);
        
    }

        // GET: Purchases/Details/5
        public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var purchase = _purchaseRepository.GetPurchaseById(id);
        CarCustomer carCustomer = new CarCustomer
        {
            Car = _carRepository.GetCarById(purchase.CarId),
            Customer = _customerRepository.GetCustomerById(purchase.CustomerId),
            Purchase = purchase
        };

        if (purchase == null)
        {
            return NotFound();
        }

        return View(carCustomer);
    }

    // GET: Purchases/Create
    public IActionResult Create()
        {
            ViewData["CarId"] = new SelectList(_carRepository.GetCar(), "Id", "Name");
            ViewData["CustomerId"] = new SelectList(_customerRepository.GetCustomers(), "Id", "Name");
            return View();
        }
    

    // POST: Purchases/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CarId,Id")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
            _purchaseRepository.AddNewPurchase(purchase);
            return RedirectToAction(nameof(Index));
            }
            return View(purchase);
        }

        // GET: Purchases/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = _purchaseRepository.GetPurchaseById(id);
            if (purchase == null)
            {
                return NotFound();
            }
            ViewData["PieId"] = new SelectList(_carRepository.GetCar(), "Id", "Brand", _carRepository.GetCarById(purchase.CarId).Brand );
            ViewData["CustomerId"] = new SelectList(_customerRepository.GetCustomers(), "Id", "Brand", _customerRepository.GetCustomerById(purchase.CustomerId).Name);
            return View(purchase);
        }

        // POST: Purchases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("CarId,Id")] Purchase purchase)
        {
            if (id != purchase.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _purchaseRepository.UpdatePurchase(purchase);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseExists(purchase.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(purchase);
        }

        // GET: Purchases/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = _purchaseRepository.GetPurchaseById(id);
            if (purchase == null)
            {
                return NotFound();
            }

            return View(purchase);
        }

        // POST: Purchases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchase = _purchaseRepository.GetPurchaseById(id);
            _purchaseRepository.RemovePurchase(purchase);
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseExists(int id)
        {
            return _purchaseRepository.GetPurchaseById(id) != null; 
        }
    }
}
