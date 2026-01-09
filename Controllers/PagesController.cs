using cozynibi.Data;
using Microsoft.AspNetCore.Mvc;

namespace cozynibi.Controllers
{
    public class PagesController : Controller
    {
        private ApplicationDbContext _context;

        public PagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Accommodation()
        {
            var rooms = _context.Rooms.ToList();
            return View(rooms);
        }

        public IActionResult RoomDetail(int id)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            if (room == null) return NotFound();

            return View(room);
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Tour()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
