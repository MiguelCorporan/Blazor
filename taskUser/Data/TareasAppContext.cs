
using Microsoft.EntityFrameworkCore;
using taskUser.Models;

namespace taskUser.Data
{
    public class TareasAppContext : DbContext
    {
        public TareasAppContext(DbContextOptions<TareasAppContext> options)
            : base(options)
        {
        }

        public DbSet<AdminInfo> AdminInfos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración opcional, puedes dejar que EF lo haga automáticamente
            modelBuilder.Entity<AdminInfo>()
                .HasMany(a => a.Tareas)
                .WithOne(t => t.AdminInfo)
                .HasForeignKey(t => t.AdminInfoId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
