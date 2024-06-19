using ApiUsuarioCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiUsuarioCurso.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
