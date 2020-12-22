using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string FatherName { get; set; }

        [MaxLength(100)]
        public string MotherName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
    }
}
