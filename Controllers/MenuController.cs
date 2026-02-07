using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using cozynibi.Data;
using cozynibi.Models;



namespace cozynibi.Controllers
{
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MenuController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            int pageSize = 6; // 👈 BẮT BUỘC

            var menus = _context.Menus
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            int totalItems = _context.Menus.Count();
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            ViewBag.CurrentPage = page;

            return View(menus);
        }

    }
}
