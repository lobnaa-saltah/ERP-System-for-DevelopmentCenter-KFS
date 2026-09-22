using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class RetirementController : Controller
    {
        public IActionResult Pending()
        {
            return View();
        }

        // ملفات تم تسليمها (Files)
        public IActionResult Files()
        {
            return View();
        }
    }
}