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
        public IActionResult Index(int page = 1)
        {
            int pageSize = 4; // số phòng mỗi trang

            var totalRooms = _context.Rooms.Count();

            var rooms = _context.Rooms
                .OrderBy(r => r.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalRooms / pageSize);

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
