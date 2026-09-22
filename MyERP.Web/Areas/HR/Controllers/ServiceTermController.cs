using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class ServiceTermController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection collection)
        {
            // كود الحفظ
            return RedirectToAction(nameof(Index));
        }
    }
}