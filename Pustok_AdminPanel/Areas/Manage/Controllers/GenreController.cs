using Microsoft.AspNetCore.Mvc;
using Pustok_AdminPanel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok_AdminPanel.Areas.Manage.Controllers
{
    [Area("manage")]
    public class GenreController : Controller
    {
        private readonly AppDbContext _context;
        public GenreController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var genre = _context.Genres.ToList();
            return View(genre);
        }
    }
}
