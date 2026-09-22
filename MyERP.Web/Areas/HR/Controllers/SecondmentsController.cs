using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class SecondmentsController : Controller
    {
        // صفحة الإعارات والندب
        public IActionResult Index()
        {
            return View();
        }

        // إنشاء إعارة جديدة
        public IActionResult Create()
        {
            return View();
        }
    }
}