using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using TagHelpersWebSite.Models;

namespace TagHelpersWebSite.Controllers
{
    public class EmployeeController : Controller
    {
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
            if (ModelState.IsValid)
            {
                return View("Details", employee);
            }
            return View(employee);
        }

    }
}
