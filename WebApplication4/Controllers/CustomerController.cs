﻿using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer { id = 1, name = "Fatma", email = "Fatma@gmail.com", phone = "23456789" },
            new Customer { id = 2, name = "Awdhah", email = "Awdhah@gmail.com", phone = "98765432" }
            
        };
        
        public IActionResult Index()
        {
            return View(customers);
        }
        public IActionResult Details(int id)
        {
            var customer = customers.SingleOrDefault(a => a.id == id);
            if (customers == null)
            {
                return RedirectToAction("Index");

            }
            return View(customer);
        }

    }

}
