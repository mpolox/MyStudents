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
            //Student
            CreateMap<Student, StudentDtoRead>();
            CreateMap<StudentDtoRead, Student>();
            CreateMap<Student, StudentDtoWrite>();
            CreateMap<StudentDtoWrite, Student>();

            //Teacher
            CreateMap<Teacher, TeacherDto>();
            CreateMap<TeacherDto, Teacher>();
        }
    }
}
