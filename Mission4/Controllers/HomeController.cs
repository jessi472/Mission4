﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private NewMovieContext _blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, NewMovieContext someMovie)
        {
            _logger = logger;
            _blahContext = someMovie;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View("Podcasts");
        }
        [HttpGet]
        public IActionResult NewMovieForm ()
        {
            return View("NewMovieForm");
        }
        [HttpPost]
        public IActionResult NewMovieForm (MovieResponse mr)
        {
            

            _blahContext.Add(mr);
            _blahContext.SaveChanges();
            return View("Confirmation");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
