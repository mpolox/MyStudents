using Microsoft.EntityFrameworkCore;
using MyStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Data
{
    public class SchoolContext: DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> opt) : base(opt)
        {

        }

        //To update DB use:
        // dotnet ef migrations add AddTeacher
        // dotnet ef database update
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Materia> Materias { get; set; }

    }
}
