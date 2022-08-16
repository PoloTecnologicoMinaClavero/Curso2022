using EF_CodeFirst.Modelo;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Context
{
    public class CodeFirstDbContext : DbContext
    {
        //Acá acoplamos el modelo de clases al DbContext de EF
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Deposito> Depositos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Conectamos con nuestra base SQL Server usando un string de conexión
            optionsBuilder.UseSqlServer("Server=EZE-INCLUIT\\SQLEXPRESS2012;Initial Catalog=EFCodeFirst;Integrated Security=true;");
            
            base.OnConfiguring(optionsBuilder);
        }

        //Ver FluentAPI para configurar como se mapea el modelo de clases y sus propiedades
    }
}
