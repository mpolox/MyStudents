using MyStudents.Interfaces;
using MyStudents.Models;
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

        public Teacher Add(Teacher anInput)
        {
            anInput.IsActive = true;
            _context.Add(anInput);
            _context.SaveChanges();
            return (anInput);
        }

        public Teacher Delete(int id)
        {
            Teacher item = _context.Teachers.FirstOrDefault(s => s.Id == id);
            item.IsActive = false;
            _context.Update(item);
            _context.SaveChanges();
            return item;
        }

        public IEnumerable<Teacher> Get()
        {
            var myResponse = _context.Teachers.ToList();
            return myResponse;
        }

        public Teacher Get(int id)
        {
            var res = _context.Teachers.FirstOrDefault(n => n.Id == id);
            return res;
        }

        public IEnumerable<Teacher> GetByStatus(bool v)
        {
            var res = _context.Teachers.Where(n => n.IsActive == v).ToList();
            return res;
        }

    }
}
