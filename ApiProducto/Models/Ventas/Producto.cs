using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanckPruebaAngular.Models.Ventas
{
  public class Producto
  {
    [Key]
    public int ID_Producto { get; set; }

    [Column (TypeName = "varchar(100)")]
    public string CodigoProducto   { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Categoria { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Lote { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Codigo { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string NombreProducto { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string Estado { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Precio_sin_iva { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Precio_con_iva { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Graba_iva { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Cantidad_iva { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Precio_PVP { get; set; }


  }
}
