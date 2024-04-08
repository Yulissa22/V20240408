using Microsoft.EntityFrameworkCore;
using V20240408.EntidadesDeNegocio;

namespace V20240408.AccesoADatos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) { }
        public DbSet<PersonaV> PersonaV { get; set; }
        
    }
}
