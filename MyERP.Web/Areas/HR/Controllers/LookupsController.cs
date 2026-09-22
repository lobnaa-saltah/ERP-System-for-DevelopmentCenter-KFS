using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class LookupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}