using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolDairy.Data;
using SchoolDairy.Data.Models;
using SchoolDairy.Models.Student;



namespace SchoolDairy.Controllers
{
    public class StudentController : Controller
    {

        private readonly SchoolDairyDbContext context;

        public StudentController(SchoolDairyDbContext context)
        {
           this. context = context;
        }


        public IActionResult Index()
        {
            var students = context.Students
                .Include(s => s.StudentSpeciality)
                .Include(s => s.Parent)
                .Include(s => s.Teacher)
                .ToList(); 

            return View(students); 
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            var viewModel = new AddStudentViewModel
            {
                Specialties = context.StudentSpecialities.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                }),
                Parents = context.Parents.Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.FirstName
                }),
                Teachers = context.Teachers.Select(t => new SelectListItem
                {
                    Value = t.Id.ToString(),
                    Text = t.FirstName
                })
            };

            return View(viewModel);
        }


        [HttpPost]
        public IActionResult AddStudent(AddStudentViewModel model)
        {
            if (!ModelState.IsValid)
            {

                model.Specialties = context.StudentSpecialities.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                });
                model.Parents = context.Parents.Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.FirstName,

                });
                model.Teachers = context.Teachers.Select(t => new SelectListItem
                {
                    Value = t.Id.ToString(),
                    Text = t.FirstName,
                });

                return View(model);
            }

            var student = new Student
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Classroom = model.Classroom,
                Number = model.Number,
                FormOfTraining = model.FormOfTraining,
                StudentSpeciality = context.StudentSpecialities.Find(model.SpecialtyId),
                ParentId = model.ParentId,
                TeacherId = model.TeacherId
            };

            context.Students.Add(student);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
          
            var student = context.Students
                .Include(s => s.StudentSpeciality)
                .Include(s => s.Parent)
                .Include(s => s.Teacher)
                .FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound(); 
            }

           
            var viewModel = new EditStudentViewModel
            {
                Id = student.Id,
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                Classroom = student.Classroom,
                Number = student.Number,
                FormOfTraining = student.FormOfTraining,
                SpecialtyId = student.StudentSpeciality?.Id,
                ParentId = student.ParentId,
                TeacherId = student.TeacherId,
                Specialties = context.StudentSpecialities.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                }).ToList(),
                Parents = context.Parents.Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.FirstName
                }).ToList(),
                Teachers = context.Teachers.Select(t => new SelectListItem
                {
                    Value = t.Id.ToString(),
                    Text = t.FirstName
                }).ToList()
            };

            return View(viewModel); 
        }
        [HttpPost]
        public IActionResult EditStudent(EditStudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
               
                model.Specialties = context.StudentSpecialities.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                }).ToList();
                model.Parents = context.Parents.Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.FirstName
                }).ToList();
                model.Teachers = context.Teachers.Select(t => new SelectListItem
                {
                    Value = t.Id.ToString(),
                    Text = t.FirstName
                }).ToList();

                return View(model); 
            }

           
            var student = context.Students.FirstOrDefault(s => s.Id == model.Id);
            if (student == null)
            {
                return NotFound(); 
            }

            
            student.FirstName = model.FirstName;
            student.MiddleName = model.MiddleName;
            student.LastName = model.LastName;
            student.Classroom = model.Classroom;
            student.Number = model.Number;
            student.FormOfTraining = model.FormOfTraining;
            student.StudentSpeciality = context.StudentSpecialities.Find(model.SpecialtyId); 
            student.ParentId = (int)model.ParentId; 
            student.TeacherId = (int) model.TeacherId;

            
            context.SaveChanges();

           
            return RedirectToAction("Index");
        }
       

    }

}

        

 

