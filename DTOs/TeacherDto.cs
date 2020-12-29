using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.DTOs
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
        public string Comments { get; set; }
    }
}
