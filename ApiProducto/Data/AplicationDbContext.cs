using ApiProducto.Models.Administracion;
using ApiProducto.Models.Ventas;
using BanckPruebaAngular.Models.Ventas;
using Microsoft.EntityFrameworkCore;

namespace ApiProducto.Data
{
  public class AplicationDbContext : DbContext
  {
    public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Producto> Producto { get; set; } 
    public DbSet<Proveedor> Proveedor { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
  }
}
