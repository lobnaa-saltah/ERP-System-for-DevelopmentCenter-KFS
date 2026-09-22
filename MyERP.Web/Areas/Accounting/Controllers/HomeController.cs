using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.Accounting.Controllers
{
    [Area("Accounting")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}