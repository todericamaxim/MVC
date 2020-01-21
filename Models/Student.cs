using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exemplu_MVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    public class StudentData
    {
        private static readonly List<Student> students = new List<Student>();

        static StudentData()
        {
            students.Add(new Student { Id = 1, Name = "Ion",Age=12 });
            students.Add(new Student { Id = 2, Name = "Valeriu",Age=20 });
            students.Add(new Student { Id = 3, Name = "Mihai", Age=21 });
            students.Add(new Student { Id = 3, Name = "Andrei", Age=25 });
            students.Add(new Student { Id = 3, Name = "Maria", Age=27 });
        }
        public StudentData()
        { }
        public List<Student> GetStudents()
        { return students; }

        public Student GetStudent(int Id)
        {
            return students.Find(x => x.Id == Id);
        }
    }
}