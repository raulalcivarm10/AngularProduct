using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProducto.Models.Administracion
{
  public class Usuario
  {
    [Key]
    public int ID_Usuario { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string Cedula { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string Nombre_Usuario { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string Apellidos_Usuario { get; set; }

    [Column(TypeName = "varchar(30)")]
    public string Correo_Usuario { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string Telefono_Celular { get; set; }
  }
}
