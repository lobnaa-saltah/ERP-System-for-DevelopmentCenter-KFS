using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Action لتسجيل حضور يدوي (Post)
        [HttpPost]
        public IActionResult CreateManual(IFormCollection form)
        {
            // Code here...
            return RedirectToAction(nameof(Index));
        }
    }
}