using Desafio2.Models;
using Microsoft.EntityFrameworkCore;


namespace Desafio2.Contexts;

public class CoderhouseDbContext : DbContext
{
   
    public DbSet<Producto> Producto { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<ProductosVendido> ProductosVendido { get; set; }
    public DbSet<Venta> Venta { get; set; }

    public CoderhouseDbContext()
      : base() { }
    public CoderhouseDbContext(DbContextOptions<CoderhouseDbContext> options)
        : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=PROGRAMACION10;Initial Catalog=Coderhouse;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
        );
    }

}
