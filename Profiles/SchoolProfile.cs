using AutoMapper;
using MyStudents.DTOs;
using MyStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Profiles
{
    public class SchoolProfile : Profile
    {

        public SchoolProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();

            CreateMap<Teacher, TeacherDto>();
            CreateMap<TeacherDto, Teacher>();
        }
    }
}
