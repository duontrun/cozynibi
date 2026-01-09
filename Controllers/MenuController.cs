using Microsoft.AspNetCore.Mvc;

namespace cozynibi.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
