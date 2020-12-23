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
        public StudentController(IStudent repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetStudents()
        {
            var myRespone = _repo.Get();
            return Ok(myRespone);
        }

        /// <summary>
        /// Get a student by a given Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var myResponse = _repo.Get(id);
            if (myResponse != null)
            {
                return Ok(myResponse);
            }
            return NotFound(id);            
        }


        [HttpPost]
        public IActionResult AddStudent(StudentDto aStudent)
        {
            Console.WriteLine(aStudent.Name);
            var myResponse =_repo.Add(aStudent);
            return Ok(myResponse);
        }




    }
}
