using Microsoft.AspNetCore.Mvc;
using MyStudents.DTOs;
using MyStudents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Controllers
{
    [ApiController]
    [Route("Materia")]
    public class MateriaController : Controller
    {
        private readonly IMateria _repo;
        public MateriaController(IMateria repo)
        {
            _repo = repo;
        }


        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
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
        public IActionResult Get(int id)
        {
            var myResponse = _repo.Get(id);
            if (myResponse != null)
            {
                return Ok(myResponse);
            }
            return NotFound(id);
        }


        [HttpPost]
        public IActionResult Add(MateriaDto m)
        {
            var myResponse = _repo.Add(m);
            return Ok(myResponse);
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_repo.Delete(id))
            {
                return Ok("Deleted: " + id);
            }
            return NotFound();
        }

    }
}
