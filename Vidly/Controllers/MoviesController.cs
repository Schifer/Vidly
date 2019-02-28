﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!" };
            var costumers = new List<Customer>
            {
                new Customer { Name = "Hitsugaya" },
                new Customer { Name = "Renji" },
                new Customer { Name = "Minamino" },
                new Customer { Name = "Danna" },
            };

            return View(movie);
        }
    }
}