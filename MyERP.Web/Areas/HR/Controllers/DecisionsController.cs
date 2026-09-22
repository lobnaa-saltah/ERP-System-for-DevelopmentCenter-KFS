using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class DecisionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // صفحة لتسجيل قرار جديد
        public IActionResult Create()
        {
            return View();
        }
    }
}