using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.Projects.Controllers
{
    [Area("Projects")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}