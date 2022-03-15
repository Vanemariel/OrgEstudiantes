using Microsoft.EntityFrameworkCore;
using OrgEstudiantes.Comunes.Datos.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgEstudiantes.Comunes.Datos
{
    public class dbContex: DbContext

    {
        public DbSet<Estudiantes> Alumno { get; set; }
        public dbContex(DbContextOptions<dbContex> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model
                .GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
