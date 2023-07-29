using Microsoft.AspNetCore.Mvc;
using mvc_crud.Data;
using mvc_crud.Models;

namespace mvc_crud.employee
{
    public class EmployeeController : Controller
    {
        private readonly  ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            IEnumerable<emp> objCatlist = _context.emps;
            return View(objCatlist);
        }

        public IActionResult Create()
        {
            return View();
        }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create(emp empobj)
            {
                if (ModelState.IsValid)
                {
                    _context.emps.Add(empobj);
                    _context.SaveChanges();
                    TempData["ResultOk"] = "Record Added Successfully !";
                    return RedirectToAction("Index");
                }

                return View(empobj);
            }

            public IActionResult Edit(int? id)
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }
                var empfromdb = _context.emps.Find(id);

                if (empfromdb == null)
                {
                    return NotFound();
                }
                return View(empfromdb);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Edit(emp empobj)
            {
                if (ModelState.IsValid)
                {
                    _context.emps.Update(empobj);
                    _context.SaveChanges();
                    TempData["ResultOk"] = "Data Updated Successfully !";
                    return RedirectToAction("Index");
                }

                return View(empobj);
            }

            public IActionResult Delete(int? id)
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }
                var empfromdb = _context.emps.Find(id);

                if (empfromdb == null)
                {
                    return NotFound();
                }
                return View(empfromdb);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult DeleteEmp(int? id)
            {
                var deleterecord = _context.emps.Find(id);
                if (deleterecord == null)
                {
                    return NotFound();
                }
                _context.emps.Remove(deleterecord);
                _context.SaveChanges();
                TempData["ResultOk"] = "Data Deleted Successfully !";
                return RedirectToAction("Index");
            


        }
    }
}
