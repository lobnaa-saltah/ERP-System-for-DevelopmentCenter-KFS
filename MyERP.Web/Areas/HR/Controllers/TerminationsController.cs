using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class TerminationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDecision(IFormCollection form)
        {
            // إيقاف الموظف وتحديث حالته في قاعدة البيانات
            return RedirectToAction(nameof(Index));
        }
    }
}