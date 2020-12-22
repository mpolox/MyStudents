using MyStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// THIS IS A MOCK CLASS USED BEFORE DB
namespace MyStudents.Data
{
    public class MockStudentRepo // : ISchool
    {
        IEnumerable<Student> myStudents = new List<Student>()
        {
            new Student{
            Id = 1,
            Name = "Marcopolo",
            FatherName = "Ramos",
            MotherName = "Peña",
            StudentCode = "987654",
            BirthDate = new DateTime()
            },
            new Student{
            Id = 2,
            Name = "Juan",
            FatherName = "Perez",
            MotherName = "Lopez",
            StudentCode = "123123",
            BirthDate = new DateTime()
            }
        };

        public Student GetStudent(int id)
        {
            var myStudent = myStudents.Where(n => n.Id == id).FirstOrDefault();            
            return myStudent;
        }

        public IEnumerable<Student> GetStudents()
        {
            return myStudents;
        }
    }
}
