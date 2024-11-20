using Microsoft.AspNetCore.Mvc;
using SchoolDairy.Data.Models;
using SchoolDairy.Data;
using SchoolDairy.Views.Parent;
using System.Runtime.InteropServices;



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
        public IActionResult Create(AddParentValidation parent)
        {
            if (!this.ModelState.IsValid)
            {
             return this.View(parent);
            }
            Parent parents = new Parent
            {
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                PhoneNumber = parent.PhoneNumber,
                EmailAddres = parent.EmailAddres,
                UserNameParent = parent.UserNameParent, 
            };


            this.schoolDairyDbContext.Parents.Add(parents);
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

            Parent? parents = schoolDairyDbContext
                .Parents
                .FirstOrDefault(p => p.Id == Id);
            if (parents == null)
            {
                return NotFound();
            }
            return View(parents);
        }
    }
}
