using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class PromotionsController : Controller
    {
        // صفحة بحث الأحقية (Eligibility)
        public IActionResult Eligibility()
        {
            return View();
        }

        // تنفيذ الترقية/العلاوة للمختارين
        [HttpPost]
        public IActionResult ExecuteCycle(IFormCollection form)
        {
            // هنا كود الترحيل للدرجة الأعلى وتعديل الراتب
            return RedirectToAction(nameof(Eligibility));
        }
    }
}