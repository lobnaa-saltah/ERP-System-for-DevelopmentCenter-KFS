using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.Inventory.Controllers
{
    [Area("Inventory")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}