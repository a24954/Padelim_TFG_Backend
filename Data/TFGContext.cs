using Microsoft.EntityFrameworkCore;
using TFGBackend.Models;
using System.Collections.Generic;

namespace TFGBackend.Data
{
    public class TFGContext : DbContext
    {
        public TFGContext(DbContextOptions<TFGContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { IdUser = 1, UserName = "cosmar", Password = "123", Email = "hola1@gmail.com", Rol = Usuario.UserRole.Admin },
                new Usuario { IdUser = 2, UserName = "cosmari", Password = "123", Email = "hola2@gmail.com", Rol = Usuario.UserRole.StandardUser },
                new Usuario { IdUser = 3, UserName = "cosmaro", Password = "123", Email = "hola3@gmail.com", Rol = Usuario.UserRole.StandardUser }
            );
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
