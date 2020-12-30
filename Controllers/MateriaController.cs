using Microsoft.AspNetCore.Mvc;
using MyStudents.Data;
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
        private readonly MateriaManager _repo;
        public MateriaController(MateriaManager repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            var myRespone = _repo.Get();
            return Ok(myRespone);
        }

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
            if (myResponse != null)
            {
                return Ok(myResponse);
            }
            return BadRequest("Already Exists");
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
