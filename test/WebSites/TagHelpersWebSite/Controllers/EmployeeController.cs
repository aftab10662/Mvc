using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using TagHelpersWebSite.Models;

namespace TagHelpersWebSite.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        // GET: Employee
        public IActionResult Index()
        {
            return View(Enumerable.Empty<Employee>());
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                return View("Details", employee);
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        public IActionResult Edit(int id)
        {
            Employee employee = db.Employee.Single(m => m.EmployeeId == id);
            if (employee == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employee.Update(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employee/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            Employee employee = db.Employee.Single(m => m.EmployeeId == id);
            if (employee == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employee.Single(m => m.EmployeeId == id);
            db.Employee.Remove(employee);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
