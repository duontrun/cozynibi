using Microsoft.AspNetCore.Mvc;
using cozynibi.Data;
using cozynibi.Models;
using System.Linq;

namespace cozynibi.Controllers
{
    public class AccommodationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccommodationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // DANH SÁCH PHÒNG
        public IActionResult Index()
        {
            var rooms = _context.Rooms.ToList();
            return View(rooms);
        }

        // CHI TIẾT PHÒNG
        public IActionResult Detail(int id)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);

            if (room == null)
                return NotFound();

            ViewBag.OtherRooms = _context.Rooms
                .Where(r => r.Id != id)
                .ToList();

            return View(room);
        }
    }
}
