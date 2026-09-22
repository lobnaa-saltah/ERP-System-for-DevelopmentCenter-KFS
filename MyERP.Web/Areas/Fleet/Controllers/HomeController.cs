using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.Fleet.Controllers
{
    [Area("Fleet")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}