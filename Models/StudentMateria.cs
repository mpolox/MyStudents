using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Models
{
    public class StudentMateria
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int MateriaId { get; set; }

        public Materia Materia { get; set; }

    }
}
