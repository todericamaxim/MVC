using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exemplu_MVC.Models;

namespace Exemplu_MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentData studentData;
        public StudentController()
        {
            this.studentData = new StudentData();
        }
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = this.studentData.GetStudents();
            return this.View(students);
        }
        public ActionResult ById(int id)
        {
            var u = this.studentData.GetStudent(id);
            return this.View(u);
        }
    }
}