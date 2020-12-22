using MyStudents.DTOs;
using MyStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudents.Interfaces
{
    public interface IMateria
    {
        IEnumerable<Materia> Get();

        Materia Get(int id);

        Materia Add (MateriaDto m);
        bool Delete(int id);
    }
}
