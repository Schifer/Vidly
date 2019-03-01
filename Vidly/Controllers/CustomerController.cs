﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
           // GET: Customer
            public ViewResult Index()
            {
                var customers = _context.Customers.Include(c => c.MembershipType).ToList(); // Getting Costumers from database

                return View(customers);
            }

            public ActionResult Details(int? id)
            {
                var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);

                if (customer == null)
                {
                    return HttpNotFound();
                }

                return View(customer);
            }
    }
}