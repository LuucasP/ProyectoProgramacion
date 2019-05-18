using Microsoft.EntityFrameworkCore;

namespace Base_de_Datos.Models
{
    public class ProyectoContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        

        public ProyectoContext(DbContextOptions<ProyectoContext> options) : base(options) { }

    }
}