using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyStudents.DTOs;
using MyStudents.Interfaces;
using MyStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Controllers
{
    [ApiController]
    [Route("Teacher")]
    public class TeacherController : Controller
    {
        private readonly ITeacher _repo;
        private readonly IMapper _mapper;

        public TeacherController(ITeacher teacherRepo, IMapper mapper)
        {
            _repo = teacherRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            IEnumerable<Teacher> myTeachers = _repo.Get();
            var myResponse = _mapper.Map<IEnumerable<TeacherDto>>(myTeachers);
            return Ok(myResponse);
        }

        [HttpGet]
        [Route("GetActive")]
        public IActionResult GetActive()
        {
            IEnumerable<Teacher> myTeachers = _repo.GetByStatus(true);
            var myResponse = _mapper.Map<IEnumerable<TeacherDto>>(myTeachers);
            return Ok(myResponse);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Teacher myTeacher = _repo.Get(id);
            if (myTeacher != null)
            {
                var myResponse = _mapper.Map<TeacherDto>(myTeacher);
                return Ok(myResponse);
            }
            return NotFound(id);
        }

        [HttpPost]
        public IActionResult Add(TeacherDto aTeacher)
        {
            Teacher myTeacher = _mapper.Map<Teacher>(aTeacher);
            myTeacher = _repo.Add(myTeacher);
            var myResponse = _mapper.Map<TeacherDto>(myTeacher);
            return Ok(myResponse);
        }

        [HttpDelete]
        public IActionResult Delete(int anId)
        {
            Teacher myItem = _repo.Delete(anId);
            if (myItem != null)
            {
                var myResponse = _mapper.Map<TeacherDto>(myItem);
                return Ok(myResponse);
            }
            return NotFound();
        }
    }

}
