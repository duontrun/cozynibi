using Microsoft.AspNetCore.Mvc;
using cozynibi.Data;
using System.Linq;

namespace cozynibi.Controllers
{
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AboutController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var abouts = _context.Abouts
                .OrderBy(x => x.Position)
                .ToList();

            return View(abouts);
        }
    }
}
