using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrgEstudiantes.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrgEstudiantes.Comunes.Datos.database;
using Microsoft.EntityFrameworkCore;
using OrgEstudiantes.Comunes.Datos;

namespace OrgEstudiantes.Server.Controllers
{
    //la palabra mvc me reeplaza a nombre del controlador q seria el corchete 
    [ApiController]
    [Route("Api/[controller]")]
    //a la clase studentcontroller le heredo la clase controllerbase q es la clase 
    //que tiene todas las funionalidades de u controller
    //la inteligencia de comunicar la web api via http con el front esta en controllerbase

    public class StudentController : ControllerBase
    {
        private readonly DbContext context;

        //digo que contex sea solo de lectura para mi

        public StudentController(DbContext context)//este es el constructor
        {
            this.context = context;
        }

        [HttpGet]
        //metodo que me muestra la lista
        public async Task<IEnumerable<Estudiantes>> GetAsync()
        {
           // return new List<Estudiantes>();
           //retorna la lista de la tabla de alumnos
            return await context.Alumno.ToListAsync();//me indica que el metodo se va ejecutar sincronicamente 

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Estudiantes>> Get(int id)
        {
            // await metodo a ejecutar asincronico
            var estudiantes = await context.Alumno.Where(x => x.Id == id).Include(x => x.Estudiantes).FirstOrDefaultAsync();
            if (estudiantes == null)
            {
                return NotFound("No existe el Estudiante con id igual a {id}.");
            }
            return estudiantes;
        }

        [HttpPost]


        //metodo que me agrega un elemento para q salga desp en la lista, es un metodo publico que me va 
        //devolver una action resultado osea <un nombre del estudiante> seria el parametro 
        public ActionResult<Estudiantes> Post(Estudiantes estudiantes)//se el nombre del estudiante pero 
                                                                      //no conozco el ID eso me lo da la base 
        {
            context.Alumnos.Add(estudiantes);//digo que agrego pero luego debo guardarlo
            context.SaveChanges();
            return estudiantes;
        }

    }
}
