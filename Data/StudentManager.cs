using MyStudents.DTOs;
using MyStudents.Interfaces;
using MyStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Data
{
    public class StudentManager : IStudent
    {
        private readonly SchoolContext _context;

        public StudentManager(SchoolContext context)
        {
            _context = context;
        }

        public Student Add(StudentDto aStudent)
        {
            Student myStudent = new Student
            {
                BirthDate = aStudent.BirthDate,
                FatherName = aStudent.FatherName,
                MotherName = aStudent.MotherName,
                Name = aStudent.Name,
                StudentCode = aStudent.StudentCode
            };
            _context.Add(myStudent);
            _context.SaveChanges();

            return (myStudent);
        }

        Student IStudent.Get(int id)
        {
            var myResponse = _context.Students.FirstOrDefault(s => s.Id == id);
            return myResponse;
        }

        IEnumerable<Student> IStudent.Get()
        {
            var myResponse = _context.Students.ToList();
            return myResponse;
        }
    }
}
