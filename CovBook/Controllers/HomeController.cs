﻿using BusinessLayer.Concrete;
using CovBook.Models;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CovBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        BookManager bm = new BookManager(new EfBookDal(),new WriterManager(new EfWriterDal()));

        public IActionResult Index()
        {
            var values = bm.GetBookDetails();
            if(values.Success==false)
            {
                 
                return RedirectToAction("Maintenance");
            }
            ViewBag.v1 = values.Message;
            return View(values.Data);
        }
       
        public IActionResult Maintenance()
        {
            ViewBag.v1 = bm.GetBookDetails().Message;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
