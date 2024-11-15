using Microsoft.EntityFrameworkCore;
using Empresa.Proyecto.Core.Entities;


namespace Empresa.Proyecto.Infra.Data
{
    public class MyProjectContext : DbContext
    {
        /// <summary>
        /// Constructor para DI
        /// </summary>
        /// <param name="options"></param>
        public MyProjectContext(DbContextOptions<MyProjectContext> options) : base(options)
        {

        }

        public DbSet<SimpleEntity> SimpleEntity => Set<SimpleEntity>();
        public DbSet<ComplexEntity> ComplexEntity => Set<ComplexEntity>();
        public DbSet<EntityOption> EntityOption => Set<EntityOption>();
        protected override void OnModelCreating(ModelBuilder builder)
        {           
            builder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
            builder.Entity<SimpleEntity>().HasData
                (
                new SimpleEntity { Id = 1, Name = "Nuevo", Created = DateTime.Now, Modified = DateTime.Now },
                new SimpleEntity { Id = 2, Name = "Existente", Created = new DateTime(2024, 10, 10), Modified = new DateTime(2024, 10, 10) },
                new SimpleEntity { Id = 3, Name = "Reconstruido", Created = new DateTime(2024, 08, 09), Modified = new DateTime(2024, 08, 09) },

                new SimpleEntity { Id = 4, Name = "Activo", Created = new DateTime(2023, 05, 15), Modified = new DateTime(2023, 05, 15) },
                new SimpleEntity { Id = 5, Name = "Inactivo", Created = new DateTime(2023, 03, 12), Modified = new DateTime(2023, 03, 12) },
                new SimpleEntity { Id = 6, Name = "Pendiente", Created = new DateTime(2024, 01, 01), Modified = new DateTime(2024, 01, 01) },
                new SimpleEntity { Id = 7, Name = "Completado", Created = new DateTime(2024, 02, 20), Modified = new DateTime(2024, 02, 20) },
                new SimpleEntity { Id = 8, Name = "Cancelado", Created = new DateTime(2022, 11, 25), Modified = new DateTime(2022, 11, 25) },
                new SimpleEntity { Id = 9, Name = "En progreso", Created = new DateTime(2023, 07, 10), Modified = new DateTime(2023, 07, 10) },
                new SimpleEntity { Id = 10, Name = "Procesado", Created = new DateTime(2023, 09, 19), Modified = new DateTime(2023, 09, 19) },

                new SimpleEntity { Id = 11, Name = "Revisado", Created = new DateTime(2022, 06, 30), Modified = new DateTime(2022, 06, 30) },
                new SimpleEntity { Id = 12, Name = "Autorizado", Created = new DateTime(2024, 03, 15), Modified = new DateTime(2024, 03, 15) },
                new SimpleEntity { Id = 13, Name = "Denegado", Created = new DateTime(2023, 12, 05), Modified = new DateTime(2023, 12, 05) },
                new SimpleEntity { Id = 14, Name = "Suspendido", Created = new DateTime(2023, 04, 28), Modified = new DateTime(2023, 04, 28) },
                new SimpleEntity { Id = 15, Name = "Expirado", Created = new DateTime(2024, 07, 01), Modified = new DateTime(2024, 07, 01) },
                new SimpleEntity { Id = 16, Name = "Temporal", Created = new DateTime(2023, 02, 14), Modified = new DateTime(2023, 02, 14) },
                new SimpleEntity { Id = 17, Name = "Permanente", Created = new DateTime(2023, 10, 22), Modified = new DateTime(2023, 10, 22) },
                new SimpleEntity { Id = 18, Name = "Provisional", Created = new DateTime(2022, 08, 31), Modified = new DateTime(2022, 08, 31) },
                new SimpleEntity { Id = 19, Name = "Finalizado", Created = new DateTime(2024, 06, 07), Modified = new DateTime(2024, 06, 07) },
                new SimpleEntity { Id = 20, Name = "Reprogramado", Created = new DateTime(2023, 01, 20), Modified = new DateTime(2023, 01, 20) },

                new SimpleEntity { Id = 21, Name = "Duplicado", Created = new DateTime(2024, 09, 09), Modified = new DateTime(2024, 09, 09) },
                new SimpleEntity { Id = 22, Name = "Original", Created = new DateTime(2023, 11, 12), Modified = new DateTime(2023, 11, 12) },
                new SimpleEntity { Id = 23, Name = "Activo temporal", Created = new DateTime(2023, 05, 18), Modified = new DateTime(2023, 05, 18) },
                new SimpleEntity { Id = 24, Name = "Listo para envío", Created = new DateTime(2024, 04, 02), Modified = new DateTime(2024, 04, 02) },
                new SimpleEntity { Id = 25, Name = "En espera", Created = new DateTime(2022, 12, 30), Modified = new DateTime(2022, 12, 30) },
                new SimpleEntity { Id = 26, Name = "Nuevo cliente", Created = new DateTime(2023, 06, 10), Modified = new DateTime(2023, 06, 10) },
                new SimpleEntity { Id = 27, Name = "Cliente recurrente", Created = new DateTime(2023, 03, 25), Modified = new DateTime(2023, 03, 25) },
                new SimpleEntity { Id = 28, Name = "Producto especial", Created = new DateTime(2024, 02, 05), Modified = new DateTime(2024, 02, 05) },
                new SimpleEntity { Id = 29, Name = "Servicio personalizado", Created = new DateTime(2023, 08, 18), Modified = new DateTime(2023, 08, 18) },
                new SimpleEntity { Id = 30, Name = "En evaluación", Created = new DateTime(2024, 05, 14), Modified = new DateTime(2024, 05, 14) },
                new SimpleEntity { Id = 31, Name = "Aprobado", Created = new DateTime(2023, 09, 09), Modified = new DateTime(2023, 09, 09) },
                new SimpleEntity { Id = 32, Name = "En corrección", Created = new DateTime(2022, 10, 21), Modified = new DateTime(2022, 10, 21) },
                new SimpleEntity { Id = 33, Name = "Concluido", Created = new DateTime(2023, 11, 03), Modified = new DateTime(2023, 11, 03) }
                );
        }
    }
}
