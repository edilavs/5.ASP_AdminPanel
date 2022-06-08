using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok_AdminPanel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok_AdminPanel.Areas.Manage.Controllers
{
    [Area("manage")]
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController (AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var book = _context.Books.Include(x=>x.Author).Include(x=>x.Genre).ToList();
            return View(book);
        }
    }
}
