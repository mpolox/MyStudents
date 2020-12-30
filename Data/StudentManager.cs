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

        public Student Add(Student aStudent)
        {
            _context.Add(aStudent);
            _context.SaveChanges();
            return (aStudent);
        }

        public Student Delete(int id)
        {
            Student myStudent = _context.Students.FirstOrDefault(s => s.Id == id);
            myStudent.IsActive = false;
            _context.Update(myStudent);
            _context.SaveChanges();
            return myStudent;
        }

        public IEnumerable<Student> GetByStatus(bool myStatus)
        {
            var myResponse = _context.Students.Where(s => s.IsActive == myStatus).ToList();
            return myResponse;
        }

        Student IStudent.Get(int id)
        {
            Student myStudent = _context.Students.FirstOrDefault(s => s.Id == id);
            return myStudent;
        }

        IEnumerable<Student> IStudent.Get()
        {
            var myResponse = _context.Students.ToList();
            return myResponse;
        }

        public Student FindByCode(Student aStudent)
        {
            var response = _context.Students.FirstOrDefault(s => 
            s.StudentCode.ToLower() == aStudent.StudentCode.ToLower());
            return response;
        }

    }
}
