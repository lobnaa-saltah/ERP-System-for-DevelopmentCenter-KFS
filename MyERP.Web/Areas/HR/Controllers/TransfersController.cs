using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class TransfersController : Controller
    {
        // الصفحة الرئيسية (تحتوي على التبويبين)
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateInternal(IFormCollection form)
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult CreateExternal(IFormCollection form)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}