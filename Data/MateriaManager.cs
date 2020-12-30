using MyStudents.DTOs;
using MyStudents.Helpers;
using MyStudents.Interfaces;
using MyStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Data
{
    public class MateriaManager 
    {
        private readonly SchoolContext _context;

        public MateriaManager(SchoolContext context)
        {
            _context = context;
        }

        public Materia Add(MateriaDto aMateria)
        {
            bool isExisting = _context.Materias.Any(m => m.Name.ToLower() == aMateria.Name.ToLower() && m.Room.ToLower() == aMateria.Room.ToLower());

            if (isExisting)
            {
                return null;
            }
            Materia myResponse = new Materia
            {
                Credits = aMateria.Credits,
                Name = aMateria.Name,
                Room = aMateria.Room
            };
            _context.Add(myResponse);
            _context.SaveChanges();
            return myResponse;
        }

        public Materia Get(int anId)
        {
            var myResponse = _context.Materias.FirstOrDefault(m => m.Id == anId);
            return myResponse;
        }

        public IEnumerable<Materia> Get()
        {
            var myResponse = _context.Materias.ToList();
            return myResponse;
        }

        public bool Delete(int id)
        {
            var myMateria = _context.Materias.FirstOrDefault(m => m.Id == id);
            if (myMateria != null)
            {
                _context.Remove(myMateria);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
