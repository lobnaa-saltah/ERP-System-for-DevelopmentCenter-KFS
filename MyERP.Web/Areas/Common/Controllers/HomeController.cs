using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.Common.Controllers
{
    [Area("Common")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}