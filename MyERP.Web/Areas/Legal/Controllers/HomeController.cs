using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.Legal.Controllers
{
    [Area("Legal")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}