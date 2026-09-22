using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class PayrollController : Controller
    {
        // صفحة إعداد المسير
        public IActionResult Generate()
        {
            return View();
        }

        // أمر الحساب (التجميع)
        [HttpPost]
        public IActionResult CalculateCycle(int month, int year)
        {
            // Logic to collect data and calc salaries
            return RedirectToAction(nameof(Generate));
        }

        // تفاصيل مفردات مرتب موظف
        public IActionResult Payslip(int id)
        {
            return View();
        }
    }
}