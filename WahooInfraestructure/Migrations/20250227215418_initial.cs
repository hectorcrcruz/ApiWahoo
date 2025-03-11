using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WahooInfraestructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionCategoriaLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionCategoriaProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaProductos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mensaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentoSoporte = table.Column<byte>(type: "tinyint", nullable: false),
                    Emisor = table.Column<int>(type: "int", nullable: false),
                    Receptor = table.Column<int>(type: "int", nullable: false),
                    Documento = table.Column<byte>(type: "tinyint", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CriterioEvaluaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionCriterioEvaluacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterioEvaluaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionDiaLaboral = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaseDomicilios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionFaseDomicilio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaseDomicilios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadItem = table.Column<int>(type: "int", nullable: false),
                    UnidadMedidaItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedioPagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionMedioPago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedioPagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParametroEvaluaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionParametro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametroEvaluaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionPermiso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoEntidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionTipoEntidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEntidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoIdentificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionTipoIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoIdentificaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPQRs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionTipoPQRS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPQRs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPromociones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionTipoPromocion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPromociones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoTransacciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DecripcionTipoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTransacciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionLog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaLogId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_CategoriaLogs_CategoriaLogId",
                        column: x => x.CategoriaLogId,
                        principalTable: "CategoriaLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    ValorProducto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImagenProducto = table.Column<byte>(type: "tinyint", nullable: false),
                    CategoriaProductoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_CategoriaProductos_CategoriaProductoId",
                        column: x => x.CategoriaProductoId,
                        principalTable: "CategoriaProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Catalogos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionCatalogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    EntidadId = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Catalogos_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDepartamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departamentos_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionModulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermisoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modulos_Permisos_PermisoId",
                        column: x => x.PermisoId,
                        principalTable: "Permisos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionEntidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoEntidadId = table.Column<int>(type: "int", nullable: false),
                    MedioPagoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entidades_MedioPagos_MedioPagoId",
                        column: x => x.MedioPagoId,
                        principalTable: "MedioPagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entidades_TipoEntidades_TipoEntidadId",
                        column: x => x.TipoEntidadId,
                        principalTable: "TipoEntidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promociones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionPromocion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    FechaInicioPromocion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinPromocion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImagenPromocion = table.Column<byte>(type: "tinyint", nullable: false),
                    CodigoPromocional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoPromocionId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promociones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promociones_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Promociones_TipoPromociones_TipoPromocionId",
                        column: x => x.TipoPromocionId,
                        principalTable: "TipoPromociones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCiudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciudades_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionRol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuloId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Modulos_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Modulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoUsuario = table.Column<int>(type: "int", nullable: false),
                    ExpedicionCedula = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DireccionUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlacaMoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenciaConduccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorarioUsuario = table.Column<int>(type: "int", nullable: false),
                    FormaPago = table.Column<int>(type: "int", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documentos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Circulacion = table.Column<int>(type: "int", nullable: false),
                    CausacionPagos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    TipoIdentificacionId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_TipoIdentificaciones_TipoIdentificacionId",
                        column: x => x.TipoIdentificacionId,
                        principalTable: "TipoIdentificaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PuntajeCalificacion = table.Column<int>(type: "int", nullable: false),
                    ParametroEvaluacionId = table.Column<int>(type: "int", nullable: false),
                    CriterioEvaluacionId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calificaciones_CriterioEvaluaciones_CriterioEvaluacionId",
                        column: x => x.CriterioEvaluacionId,
                        principalTable: "CriterioEvaluaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calificaciones_ParametroEvaluaciones_ParametroEvaluacionId",
                        column: x => x.ParametroEvaluacionId,
                        principalTable: "ParametroEvaluaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calificaciones_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Domicilios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionDomicilio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    FaseDomicilioId = table.Column<int>(type: "int", nullable: false),
                    FechaAceptaDomiciliario = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaAceptaEntidad = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AceptaEntidad = table.Column<int>(type: "int", nullable: true),
                    AceptaDomiciliario = table.Column<int>(type: "int", nullable: true),
                    DomicilioExitoso = table.Column<bool>(type: "bit", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Domicilios_FaseDomicilios_FaseDomicilioId",
                        column: x => x.FaseDomicilioId,
                        principalTable: "FaseDomicilios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Domicilios_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Domicilios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionHorario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FranjaHorario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraInicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraFin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiasLaborales = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    DiaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horarios_Dias_DiaId",
                        column: x => x.DiaId,
                        principalTable: "Dias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Horarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionNotificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enviada = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notificaciones_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PQRs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionPQRS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    TipoPQRSId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PQRs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PQRs_TipoPQRs_TipoPQRSId",
                        column: x => x.TipoPQRSId,
                        principalTable: "TipoPQRs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PQRs_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saldos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaldoInicial = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaldoFinal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaldoActual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saldos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Saldos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiempoFases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraCambioFase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DomicilioId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiempoFases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TiempoFases_Domicilios_DomicilioId",
                        column: x => x.DomicilioId,
                        principalTable: "Domicilios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transacciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoTransaccionId = table.Column<int>(type: "int", nullable: false),
                    EntidadId = table.Column<int>(type: "int", nullable: false),
                    DomicilioId = table.Column<int>(type: "int", nullable: false),
                    DescripcionAdicional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transacciones_Domicilios_DomicilioId",
                        column: x => x.DomicilioId,
                        principalTable: "Domicilios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transacciones_Entidades_EntidadId",
                        column: x => x.EntidadId,
                        principalTable: "Entidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transacciones_TipoTransacciones_TipoTransaccionId",
                        column: x => x.TipoTransaccionId,
                        principalTable: "TipoTransacciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_CriterioEvaluacionId",
                table: "Calificaciones",
                column: "CriterioEvaluacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_ParametroEvaluacionId",
                table: "Calificaciones",
                column: "ParametroEvaluacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_UsuarioId",
                table: "Calificaciones",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalogos_ItemId",
                table: "Catalogos",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_DepartamentoId",
                table: "Ciudades",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_PaisId",
                table: "Departamentos",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilios_FaseDomicilioId",
                table: "Domicilios",
                column: "FaseDomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilios_ProductoId",
                table: "Domicilios",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilios_UsuarioId",
                table: "Domicilios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Entidades_MedioPagoId",
                table: "Entidades",
                column: "MedioPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Entidades_TipoEntidadId",
                table: "Entidades",
                column: "TipoEntidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_DiaId",
                table: "Horarios",
                column: "DiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_UsuarioId",
                table: "Horarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_CategoriaLogId",
                table: "Logs",
                column: "CategoriaLogId");

            migrationBuilder.CreateIndex(
                name: "IX_Modulos_PermisoId",
                table: "Modulos",
                column: "PermisoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notificaciones_UsuarioId",
                table: "Notificaciones",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PQRs_TipoPQRSId",
                table: "PQRs",
                column: "TipoPQRSId");

            migrationBuilder.CreateIndex(
                name: "IX_PQRs_UsuarioId",
                table: "PQRs",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaProductoId",
                table: "Productos",
                column: "CategoriaProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Promociones_ProductoId",
                table: "Promociones",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Promociones_TipoPromocionId",
                table: "Promociones",
                column: "TipoPromocionId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_ModuloId",
                table: "Roles",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IX_Saldos_UsuarioId",
                table: "Saldos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TiempoFases_DomicilioId",
                table: "TiempoFases",
                column: "DomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_DomicilioId",
                table: "Transacciones",
                column: "DomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_EntidadId",
                table: "Transacciones",
                column: "EntidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_TipoTransaccionId",
                table: "Transacciones",
                column: "TipoTransaccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoIdentificacionId",
                table: "Usuarios",
                column: "TipoIdentificacionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificaciones");

            migrationBuilder.DropTable(
                name: "Catalogos");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropTable(
                name: "PQRs");

            migrationBuilder.DropTable(
                name: "Promociones");

            migrationBuilder.DropTable(
                name: "Saldos");

            migrationBuilder.DropTable(
                name: "TiempoFases");

            migrationBuilder.DropTable(
                name: "Transacciones");

            migrationBuilder.DropTable(
                name: "CriterioEvaluaciones");

            migrationBuilder.DropTable(
                name: "ParametroEvaluaciones");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Dias");

            migrationBuilder.DropTable(
                name: "CategoriaLogs");

            migrationBuilder.DropTable(
                name: "TipoPQRs");

            migrationBuilder.DropTable(
                name: "TipoPromociones");

            migrationBuilder.DropTable(
                name: "Domicilios");

            migrationBuilder.DropTable(
                name: "Entidades");

            migrationBuilder.DropTable(
                name: "TipoTransacciones");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "FaseDomicilios");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "MedioPagos");

            migrationBuilder.DropTable(
                name: "TipoEntidades");

            migrationBuilder.DropTable(
                name: "CategoriaProductos");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TipoIdentificaciones");

            migrationBuilder.DropTable(
                name: "Modulos");

            migrationBuilder.DropTable(
                name: "Permisos");
        }
    }
}
