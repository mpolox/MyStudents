using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Models
{
    public class Student : Person
    {
        [Required]
        public string StudentCode { get; set; }

        public ICollection<Materia> Materias { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; } = true;
    }
}
