using Microsoft.AspNetCore.Mvc;
using MyStudents.Interfaces;
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
        private readonly ITeacher _teacherRepo;

        public TeacherController(ITeacher teacherRepo)
        {
            _teacherRepo = teacherRepo;
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult Index()
        {
            var myResponse = _teacherRepo.GetId();
            return Ok(myResponse);
        }
    }
}
