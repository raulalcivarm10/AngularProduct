using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProducto.Models.Ventas
{
  public class Proveedor
  {
    [Key]
    public int ID_Proveedor { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Nombre_Proveedor { get; set; }
    [Column(TypeName = "varchar(100)")]
    public string Mercaderia_Producto { get; set; }
  
  }
}
