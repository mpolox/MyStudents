using MyStudents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Data
{
    public class TeacherManager : ITeacher
    {
        private readonly SchoolContext _context;

        public TeacherManager(SchoolContext context)
        {
            _context = context;
        }
        public int GetId()
        {
            return _context.Students.FirstOrDefault(s => s.Id == 1).Id;
        }
    }
}
