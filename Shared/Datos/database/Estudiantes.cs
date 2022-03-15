using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgEstudiantes.Comunes.Datos.database
{
    [Index(nameof(CodEstudiante), Name = "Uq_Estudiantes_CodEstudiantes", IsUnique = true)]
    [Index(nameof(CodMateria ), Name = "Uq_Estudiantes_CodMateria", IsUnique = true)]
    public class Estudiantes
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El código del estudiante es obligatorio.")]
        [MaxLength(2, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string CodMateria { get; set; }

        [Required(ErrorMessage = "El código de la materia es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]

        public string NombreMateria { get; set; }

        public string CodEstudiante { get; set; }

        [Required(ErrorMessage = "El código del estudiante es obligatorio.")]
        [MaxLength(120, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]


        public string NombreEstudiante { get; set; }

        public List<Estudiantes> estudiante { get; set; }

    }
}
