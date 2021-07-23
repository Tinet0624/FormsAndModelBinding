using FormsAndModelBinding.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsAndModelBinding.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult AddWithoutModelBinding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWithoutModelBinding(IFormCollection form)
        {
            Customer customer = new Customer()
            {
                FirstName = form["first-name"],
                LastName = form["last-name"],
                DateOfBirth = Convert.ToDateTime(form["dob"]),
                Email = form["email"]
            };

            //Added to database

            ViewData["addedWOBinding"] = $"{customer.FirstName} {customer.LastName} with the email {customer.Email} has been registered.";

            return View();
        }

        // ModelBinding ----------------------------------------------------------------------
        [HttpGet]
        public IActionResult AddWithModelBinding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWithModelBinding(Customer c)
        {
            if (ModelState.IsValid)
            {
                ViewData["Message"] = $"{c.FirstName} {c.LastName} with the email {c.Email} has been registered.";
            }
            return View();
        }
    }
}
