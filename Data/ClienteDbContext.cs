using Microsoft.EntityFrameworkCore;
using ProyectoProgra1.Models;

namespace ProyectoProgra1.Data{

    public class ClienteDbContext: DbContext{

        public DbSet<Cliente> Cliente{get; set;}
        public DbSet<LoginCliente> LoginCliente {get; set;}

        public ClienteDbContext(DbContextOptions<ClienteDbContext> o) : base(o){
            
        }
    }
}