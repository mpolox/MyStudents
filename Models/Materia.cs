using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyStudents.Models
{
    public class Materia
    {
        public int Id { get; set; }
        
        [MaxLength(150)]
        public string Name { get; set; }

        public int Credits { get; set; }

        [MaxLength(100)]
        public string Room { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}
