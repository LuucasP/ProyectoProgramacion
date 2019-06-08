using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProyProg.Models
{
    public class ProyectoContext : IdentityDbContext
    {
        public DbSet<Cliente> Cliente{get;set;}

        public DbSet<Destinos> Destinos{get;set;}
        public ProyectoContext(DbContextOptions<ProyectoContext> options) : base(options) { }

    }
}