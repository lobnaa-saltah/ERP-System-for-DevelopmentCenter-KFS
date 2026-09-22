using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class PermissionsController : Controller
    {
        // صفحة سجل الأذونات والتأخير
        public IActionResult Index()
        {
            return View();
        }
    }
}