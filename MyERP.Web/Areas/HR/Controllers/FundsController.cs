using Microsoft.AspNetCore.Mvc;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class FundsController : Controller
    {
        // صفحة إدارة الصناديق
        public IActionResult Fellowship()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMember(IFormCollection form)
        {
            return RedirectToAction(nameof(Fellowship));
        }
    }
}