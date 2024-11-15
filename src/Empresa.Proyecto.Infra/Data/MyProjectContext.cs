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
                new SimpleEntity { Id = 3, Name = "Reconstruido", Created = new DateTime(2024, 08, 09), Modified = new DateTime(2024, 08, 09) }
                );
        }
    }
}
