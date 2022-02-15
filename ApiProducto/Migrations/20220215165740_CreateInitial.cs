using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiProducto.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ID_Producto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoProducto = table.Column<string>(type: "varchar(100)", nullable: false),
                    Categoria = table.Column<string>(type: "varchar(100)", nullable: false),
                    Lote = table.Column<string>(type: "varchar(100)", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(100)", nullable: false),
                    NombreProducto = table.Column<string>(type: "varchar(100)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(10)", nullable: false),
                    Precio_sin_iva = table.Column<string>(type: "varchar(100)", nullable: false),
                    Precio_con_iva = table.Column<string>(type: "varchar(100)", nullable: false),
                    Graba_iva = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cantidad_iva = table.Column<string>(type: "varchar(100)", nullable: false),
                    Precio_PVP = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ID_Producto);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    ID_Proveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Proveedor = table.Column<string>(type: "varchar(100)", nullable: false),
                    Mercaderia_Producto = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.ID_Proveedor);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(type: "varchar(10)", nullable: false),
                    Nombre_Usuario = table.Column<string>(type: "varchar(50)", nullable: false),
                    Apellidos_Usuario = table.Column<string>(type: "varchar(50)", nullable: false),
                    Correo_Usuario = table.Column<string>(type: "varchar(30)", nullable: false),
                    Telefono_Celular = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID_Usuario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
