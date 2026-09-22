using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.Education.Controllers
{
    [Area("Education")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}