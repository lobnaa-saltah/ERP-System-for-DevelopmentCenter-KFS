using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyERP.Web.Areas.HR.Models;
using MyERP.Web.Data;
using MyERP.Web.Models.Common;

namespace MyERP.Web.Areas.HR.Controllers
{
    [Area("HR")]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Employee
        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employees.ToListAsync();
            return View(employees);
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }

        private string GenerateEmployeeCode()
        {
            return $"EMP-{DateTime.Now:yyyyMMddHHmmss}";
        }
        [HttpGet]
        public JsonResult GetVillages(int cityCenterId)
        {
            var villages = _context.Villages
                .Where(v => v.LocalUnit.CityCenterId == cityCenterId)
                .Select(v => new { v.Id, v.Name })
                .ToList();

            return Json(villages);
        }

        // GET: Employee/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CityCenterId = new SelectList(_context.CityCenters, "Id", "Name");
            ViewBag.VillageId = new SelectList(Enumerable.Empty<Village>(), "Id", "Name");

            ViewBag.EmploymentTypeId = new SelectList(_context.EmploymentTypes, "Id", "Name");
            ViewBag.JobTitleId = new SelectList(_context.JobTitles, "Id", "Name");
            ViewBag.JobGradeId = new SelectList(_context.JobGrades, "Id", "Name");
            ViewBag.FunctionalGroupId = new SelectList(_context.FunctionalGroups, "Id", "Name");
            ViewBag.OrgUnitId = new SelectList(_context.OrgUnits, "Id", "Name");
            ViewBag.QualificationTypeId = new SelectList(_context.QualificationTypes, "Id", "Name");

            var model = new Employee
            {
              //  Code = GenerateEmployeeCode(),
                IsActive = true
            };

            return View(model);
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                // إعادة تحميل القوائم
                ViewBag.CityCenterId = new SelectList(_context.CityCenters, "Id", "Name", employee.CityCenterId);
                ViewBag.VillageId = new SelectList(
                    _context.Villages.Where(v => v.LocalUnit.CityCenterId == employee.CityCenterId),
                    "Id", "Name", employee.VillageId);

                ViewBag.EmploymentTypeId = new SelectList(_context.EmploymentTypes, "Id", "Name", employee.EmploymentTypeId);
                ViewBag.JobTitleId = new SelectList(_context.JobTitles, "Id", "Name", employee.JobTitleId);
                ViewBag.JobGradeId = new SelectList(_context.JobGrades, "Id", "Name", employee.JobGradeId);
                ViewBag.FunctionalGroupId = new SelectList(_context.FunctionalGroups, "Id", "Name", employee.FunctionalGroupId);
                ViewBag.OrgUnitId = new SelectList(_context.OrgUnits, "Id", "Name", employee.OrgUnitId);
                ViewBag.QualificationTypeId = new SelectList(_context.QualificationTypes, "Id", "Name", employee.QualificationTypeId);

                return View(employee);
            }

            employee.CreatedAt = DateTime.Now;

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }



    }
}
