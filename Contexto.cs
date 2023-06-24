using Microsoft.EntityFrameworkCore;
using Storage_Project.Entidades;

namespace Storage_Project
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Usuarios> USUARIOS { get; set; }
    }
}
