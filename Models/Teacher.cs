using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Models
{
    public class Teacher : Person
    {
        public string Comments { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; } = true;

    }
}
