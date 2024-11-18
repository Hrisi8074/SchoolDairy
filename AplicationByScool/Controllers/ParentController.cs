using Microsoft.AspNetCore.Mvc;
using SchoolDairy.Data;
using SchoolDairy.Data.Models;

namespace SchoolDairy.Controllers
{
    public class ParentController : Controller
    {
        private readonly SchoolDairyDbContext schoolDairyDbContext;

        public ParentController(SchoolDairyDbContext schoolDairyDbContext)
        {
            this.schoolDairyDbContext = schoolDairyDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Parent> parents = this.schoolDairyDbContext
                 .Parents
                 .ToList();

            return View(parents);
        }
        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(Parent parent)
        {
            this.schoolDairyDbContext.Parents.Add(parent);
            this.schoolDairyDbContext.SaveChanges();
            return this.RedirectToAction(nameof(Index));
        }
       
    }
}
