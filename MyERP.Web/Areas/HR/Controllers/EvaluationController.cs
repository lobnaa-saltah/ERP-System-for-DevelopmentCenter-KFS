using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class EvaluationController : Controller
    {
        public IActionResult AnnualReport()
        {
            return View();
        }


        // صفحة التظلمات
        public IActionResult Grievances()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateGrievance(IFormCollection form)
        {
            return RedirectToAction(nameof(Grievances));
        }
    }
}