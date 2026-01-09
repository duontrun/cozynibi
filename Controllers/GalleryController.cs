using Microsoft.AspNetCore.Mvc;

namespace cozynibi.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
