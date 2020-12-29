using Microsoft.AspNetCore.Mvc;
using MyStudents.DTOs;
using MyStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Interfaces
{
    public interface IStudent
    {
        IEnumerable<Student> Get();
        Student Get(int id);
        Student Add(Student aStudent);
        IEnumerable<Student> GetByStatus(bool v);
        Student Delete(int id);
    }
}
