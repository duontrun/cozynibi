using Microsoft.AspNetCore.Mvc;

public class TourController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Detail(int id)
    {
        return View();
    }
}
