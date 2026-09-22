using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class LegalController : Controller
    {
        // صفحة متابعة تنفيذ الأحكام
        public IActionResult Rulings()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ExecuteRuling(IFormCollection form)
        {
            return RedirectToAction(nameof(Rulings));
        }
    }
}