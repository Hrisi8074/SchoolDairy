using Microsoft.AspNetCore.Mvc;
using SchoolDairy.Data;
using SchoolDairy.Data.Models;

namespace SchoolDairy.Controllers
{
    public class StudentController : Controller
    {
        private readonly SchoolDairyDbContext schoolDairyDbContext;

        public StudentController(SchoolDairyDbContext schoolDairyDbContext)
        {
            this.schoolDairyDbContext = schoolDairyDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Student> students = this.schoolDairyDbContext
                 .Students
                 .ToList();

            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            this.schoolDairyDbContext.Students.Add(student);
            this.schoolDairyDbContext.SaveChanges();
            return this.RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int Id)
        {
            

            Student student = schoolDairyDbContext.Students
                .FirstOrDefault(p => p.Id == Id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}
