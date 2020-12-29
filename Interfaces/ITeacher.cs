using MyStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Interfaces
{
    public interface ITeacher
    {
        IEnumerable<Teacher> Get();
        Teacher Get(int id);
        Teacher Add(Teacher aStudent);
        IEnumerable<Teacher> GetByStatus(bool v);
        Teacher Delete(int id);
    }
}
