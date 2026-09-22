using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class PenaltiesController : Controller
    {
        // الصفحة الرئيسية (السجل العام)
        public IActionResult Index()
        {
            return View();
        }

        // تسجيل جزاء جديد
        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}