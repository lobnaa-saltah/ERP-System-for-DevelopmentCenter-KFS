using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class LoansController : Controller
    {
        // صفحة الطلبات (سلف / شراء مدد)
        public IActionResult Requests()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateLoan(IFormCollection form)
        {
            // حفظ السلفة وجدولة الأقساط
            return RedirectToAction(nameof(Requests));
        }
    }
}