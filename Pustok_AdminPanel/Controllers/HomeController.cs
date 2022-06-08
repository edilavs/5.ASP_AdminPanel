﻿using Microsoft.AspNetCore.Mvc;
using Pustok_AdminPanel.DAL;
using Pustok_AdminPanel.Models;
using Pustok_AdminPanel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok_AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; set; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            List<Feature> features = _context.Features.ToList();

            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = sliders,
                Features = features
            };
            return View(homeVM);

    }
    }
}
