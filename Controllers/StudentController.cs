using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyStudents.Data;
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
    [Route("Student")]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _repo;
        private readonly IMapper _mapper;

        public StudentController(IStudent repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetStudents()
        {
            IEnumerable<Student> myStudents = _repo.Get();
            var myResponse = _mapper.Map<IEnumerable<StudentDto>>(myStudents);
            return Ok(myResponse);
        }

        [HttpGet]
        [Route("GetActive")]
        public IActionResult GetActiveStudents()
        {
            IEnumerable<Student> myStudents = _repo.GetByStatus(true);
            var myResponse = _mapper.Map<IEnumerable<StudentDto>>(myStudents);
            return Ok(myResponse);
        }

        /// <summary>
        /// Get a student by a given Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            Student myStudent = _repo.Get(id);
            if (myStudent != null)
            {
                var myResponse = _mapper.Map<StudentDto>(myStudent);
                return Ok(myResponse);
            }
            return NotFound(id);            
        }

        [HttpPost]
        public IActionResult AddStudent(StudentDto aStudent)
        {
            Student myStudent = _mapper.Map<Student>(aStudent);
            myStudent = _repo.Add(myStudent);
            var myResponse = _mapper.Map<StudentDto>(myStudent);
            return Ok(myResponse);
        }

        [HttpDelete]
        public IActionResult Delete(int aStudentId)
        {
            Student myStudent = _repo.Delete(aStudentId);
            if (myStudent != null)
            {
                var myResponse = _mapper.Map<StudentDto>(myStudent);
                return Ok(myResponse);
            }
            return NotFound();
        }
    }
}
