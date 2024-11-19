using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolDairy.Data.Models;
using SchoolDairy.Data;



namespace SchoolDairy.Web.Controllers

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
        public IActionResult Details(int Id)
        {
            bool IsIdValid = true;

            if (!IsIdValid)
            {
                return RedirectToAction(nameof(Index));
            }

            Parent parents = schoolDairyDbContext.Parents
                .FirstOrDefault(p => p.Id == Id);
            if (parents == null)
            {
                return NotFound();
            }
            return View(parents);
        }
    }
}
