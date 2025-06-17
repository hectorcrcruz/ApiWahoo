using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WahooInfraestructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    DocumentoSoporte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emisor = table.Column<int>(type: "int", nullable: false),
                    Receptor = table.Column<int>(type: "int", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedioPagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionModulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parametrizaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreApp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Footer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorPrimario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorSecundario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorTerciario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorBotonCrear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorBotonActualizar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorBotonEliminar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorTexto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoLetra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextoPrimario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextoSecundario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextoTerciario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextoCuaternario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametrizaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParametroEvaluaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionParametro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametroEvaluaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoEntidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionTipoEntidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    ImagenProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaProductoId = table.Column<int>(type: "int", nullable: false),
                    DetalleProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "Permisos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionPermiso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuloId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaUp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permisos_Modulos_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Modulos",
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDepartamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "Entidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionEntidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoEntidadId = table.Column<int>(type: "int", nullable: false),
                    MedioPagoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    ImagenPromocion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoPromocional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoPromocionId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ImagenUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoIdentificacionId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCiudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UsuarioAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioUp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
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

            migrationBuilder.InsertData(
                table: "CategoriaLogs",
                columns: new[] { "Id", "DescripcionCategoriaLog", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Error", 2, null, null, "Sistema", null },
                    { 2, "Aviso", 2, null, null, "Sistema", null },
                    { 3, "Alerta", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "CategoriaProductos",
                columns: new[] { "Id", "DescripcionCategoriaProducto", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Restaurante", 2, null, null, "Sistema", null },
                    { 2, "Hogar", 2, null, null, "Sistema", null },
                    { 3, "Deporte", 2, null, null, "Sistema", null },
                    { 4, "Turismo", 2, null, null, "Sistema", null },
                    { 5, "Construccion", 2, null, null, "Sistema", null },
                    { 6, "Tecnologia", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Documento", "DocumentoSoporte", "Emisor", "Estado", "FechaAdd", "FechaUp", "Mensaje", "Receptor", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "document.pdf", "document.pdf", 1, 2, null, null, "Hola buen dia", 2, "Sistema", null },
                    { 2, "document.jpg", "document.jpg", 2, 2, null, null, "Hola buen dia", 1, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "CriterioEvaluaciones",
                columns: new[] { "Id", "DescripcionCriterioEvaluacion", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Excelente", 2, null, null, "Sistema", null },
                    { 2, "Bueno", 2, null, null, "Sistema", null },
                    { 3, "Aceptable", 2, null, null, "Sistema", null },
                    { 4, "Regular", 2, null, null, "Sistema", null },
                    { 5, "Malo", 2, null, null, "Sistema", null },
                    { 7, "Pesimo", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "DescripcionDiaLaboral", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Lunes", 2, null, null, "Sistema", null },
                    { 2, "Martes", 2, null, null, "Sistema", null },
                    { 3, "Miercoles", 2, null, null, "Sistema", null },
                    { 4, "Jueves", 2, null, null, "Sistema", null },
                    { 5, "Viernes", 2, null, null, "Sistema", null },
                    { 6, "Sabado", 2, null, null, "Sistema", null },
                    { 7, "Domingo", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "DescripcionEstado", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Activo", 2, null, null, "Sistema", null },
                    { 2, "Inactivo", 2, null, null, "Sistema", null },
                    { 3, "Pagado", 2, null, null, "Sistema", null },
                    { 4, "Pendiente Pago", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "FaseDomicilios",
                columns: new[] { "Id", "DescripcionFaseDomicilio", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Domicilio Creado", 2, null, null, "Sistema", null },
                    { 2, "Domicilio en Proceso", 2, null, null, "Sistema", null },
                    { 3, "Domicilio Cancelado", 2, null, null, "Sistema", null },
                    { 4, "Domicilio en camino", 2, null, null, "Sistema", null },
                    { 5, "Domicilio Pendiente", 2, null, null, "Sistema", null },
                    { 6, "Domicilio Aceptado", 2, null, null, "Sistema", null },
                    { 7, "Domicilio Recibido", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CantidadItem", "DescripcionItem", "Estado", "FechaAdd", "FechaUp", "UnidadMedidaItem", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, 500, "Cebolla", 2, null, null, "Miligramos", "Sistema", null },
                    { 2, 2, "Queso", 2, null, null, "Libras", "Sistema", null },
                    { 3, 50, "Especies", 2, null, null, "Miligramos", "Sistema", null },
                    { 4, 1, "Papas", 2, null, null, "Kilo", "Sistema", null },
                    { 5, 100, "Pescado", 2, null, null, "Gramos", "Sistema", null },
                    { 6, 50, "Salsa de tomate", 2, null, null, "Miligramos", "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "MedioPagos",
                columns: new[] { "Id", "DescripcionMedioPago", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Efectivo", 2, null, null, "Sistema", null },
                    { 2, "Tarjeta de credito", 2, null, null, "Sistema", null },
                    { 3, "Tarjeta debito", 2, null, null, "Sistema", null },
                    { 4, "PSE", 2, null, null, "Sistema", null },
                    { 5, "Nequi", 2, null, null, "Sistema", null },
                    { 6, "Daviplata", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Modulos",
                columns: new[] { "Id", "DescripcionModulo", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Calificaciones", 2, null, null, "Sistema", null },
                    { 2, "Catalogo", 2, null, null, "Sistema", null },
                    { 3, "Categoria Log", 2, null, null, "Sistema", null },
                    { 4, "Categoria Producto", 2, null, null, "Sistema", null },
                    { 5, "Chat", 2, null, null, "Sistema", null },
                    { 6, "Ciudad", 2, null, null, "Sistema", null },
                    { 7, "Criterio Evaluacion", 2, null, null, "Sistema", null },
                    { 8, "Departamentos", 2, null, null, "Sistema", null },
                    { 9, "Dias", 2, null, null, "Sistema", null },
                    { 10, "Domicilio", 2, null, null, "Sistema", null },
                    { 11, "Entidad", 2, null, null, "Sistema", null },
                    { 12, "Estado", 2, null, null, "Sistema", null },
                    { 13, "Fase Domicilio", 2, null, null, "Sistema", null },
                    { 14, "Horarios", 2, null, null, "Sistema", null },
                    { 15, "Item", 2, null, null, "Sistema", null },
                    { 16, "Logs", 2, null, null, "Sistema", null },
                    { 17, "Medios de Pago", 2, null, null, "Sistema", null },
                    { 18, "Modulos", 2, null, null, "Sistema", null },
                    { 19, "Notificaciones", 2, null, null, "Sistema", null },
                    { 20, "Pais", 2, null, null, "Sistema", null },
                    { 21, "Parametro Evaluacion", 2, null, null, "Sistema", null },
                    { 22, "Permisos", 2, null, null, "Sistema", null },
                    { 23, "PQRS", 2, null, null, "Sistema", null },
                    { 24, "Productos", 2, null, null, "Sistema", null },
                    { 25, "Promociones", 2, null, null, "Sistema", null },
                    { 26, "Roles", 2, null, null, "Sistema", null },
                    { 27, "Saldos", 2, null, null, "Sistema", null },
                    { 28, "Tiempo Fase", 2, null, null, "Sistema", null },
                    { 29, "Tipo Entidad", 2, null, null, "Sistema", null },
                    { 30, "Tipo Identificacion", 2, null, null, "Sistema", null },
                    { 31, "Tipo PQRS", 2, null, null, "Sistema", null },
                    { 32, "Tipo Promocion", 2, null, null, "Sistema", null },
                    { 33, "Tipo Transaccion", 2, null, null, "Sistema", null },
                    { 34, "Transacciones", 2, null, null, "Sistema", null },
                    { 35, "Usuarios", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Estado", "FechaAdd", "FechaUp", "NombrePais", "UsuarioAdd", "UsuarioUp" },
                values: new object[] { 1, 2, new DateTime(2025, 6, 17, 17, 41, 50, 504, DateTimeKind.Local).AddTicks(4670), null, "Colombia", "Sistema", null });

            migrationBuilder.InsertData(
                table: "Parametrizaciones",
                columns: new[] { "Id", "ColorBotonActualizar", "ColorBotonCrear", "ColorBotonEliminar", "ColorPrimario", "ColorSecundario", "ColorTerciario", "ColorTexto", "Estado", "FechaAdd", "FechaUp", "Footer", "Logo", "NombreApp", "TextoCuaternario", "TextoPrimario", "TextoSecundario", "TextoTerciario", "TipoLetra", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "#720094", "#cb2c7f", "#cc1329", "#733089", "#ebbaf7", "#f9e5ff", "", 2, null, null, "Todos los derechos reservados", "", "Wahoo", "Publicidad", "2025", "SofToolSolution", "Promociones y descuentos especiales", "Agency FB", "Sistema", null },
                    { 2, "#720094", "#cb2c7f", "#cc1329", "#733089", "#ebbaf7", "#f9e5ff", "", 2, null, null, "Todos los derechos reservados", "", "Trueque", "Publicidad", "2025", "SofToolSolution", "Promociones y descuentos especiales", "Agency FB", "Sistema", null },
                    { 3, "#720094", "#cb2c7f", "#cc1329", "#733089", "#ebbaf7", "#f9e5ff", "", 2, null, null, "Todos los derechos reservados", "", "DomiYa", "Publicidad", "2025", "SofToolSolution", "Promociones y descuentos especiales", "Agency FB", "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "ParametroEvaluaciones",
                columns: new[] { "Id", "DescripcionParametro", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "¿Que tan satisfecho estas con el servicio ofrecido?", 2, null, null, "Sistema", null },
                    { 2, "¿Recomendarias el servicio?", 2, null, null, "Sistema", null },
                    { 3, "¿Estas conforme con la calidad del pedido?", 2, null, null, "Sistema", null },
                    { 4, "¿Los tiempos de entrega son razonables?", 2, null, null, "Sistema", null },
                    { 5, "¿El servicios se entrega segun lo pedido?", 2, null, null, "Sistema", null },
                    { 6, "¿El domciliario ha sido gentil y respetuoso?", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "TipoEntidades",
                columns: new[] { "Id", "DescripcionTipoEntidad", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Banco", 2, null, null, "Sistema", null },
                    { 2, "Restaurante", 2, null, null, "Sistema", null },
                    { 3, "Comercio", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "TipoIdentificaciones",
                columns: new[] { "Id", "DescripcionTipoIdentificacion", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Tarjeta de identidad", 2, null, null, "Sistema", null },
                    { 2, "Cedula de ciudadania", 2, null, null, "Sistema", null },
                    { 3, "Cedula extrajeria", 2, null, null, "Sistema", null },
                    { 4, "OCRRE Cedula Isleña", 2, null, null, "Sistema", null },
                    { 5, "Pasaporte", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "TipoPQRs",
                columns: new[] { "Id", "DescripcionTipoPQRS", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Queja", 2, null, null, "Sistema", null },
                    { 2, "Peticion o sugerencia", 2, null, null, "Sistema", null },
                    { 3, "Reclamo", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "TipoPromociones",
                columns: new[] { "Id", "DescripcionTipoPromocion", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Diaria", 2, null, null, "Sistema", null },
                    { 2, "Mensual", 2, null, null, "Sistema", null },
                    { 3, "Fecha Indefinida", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "TipoTransacciones",
                columns: new[] { "Id", "DecripcionTipoTransaccion", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Pago Domicilio", 2, null, null, "Sistema", null },
                    { 2, "Pago Domiciliario", 2, null, null, "Sistema", null },
                    { 3, "Pago Aliados", 2, null, null, "Sistema", null },
                    { 4, "Pago Susbcripcion", 2, null, null, "Sistema", null },
                    { 5, "Pago Domciliario", 2, null, null, "Sistema", null },
                    { 6, "Pago Clientes", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Catalogos",
                columns: new[] { "Id", "DescripcionCatalogo", "EntidadId", "Estado", "FechaAdd", "FechaUp", "ItemId", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Hamburguesa", null, 2, null, null, 1, "Sistema", null },
                    { 2, "Pescado a la marinera", null, 2, null, null, 5, "Sistema", null },
                    { 3, "Langosta", null, 2, null, null, 3, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Estado", "FechaAdd", "FechaUp", "NombreDepartamento", "PaisId", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, 2, null, null, "San Andres Providencia y Santa Catalina", 1, "Sistema", null },
                    { 2, 2, null, null, "Cundinamarca", 1, "Sistema", null },
                    { 3, 2, null, null, "Boyaca", 1, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Entidades",
                columns: new[] { "Id", "DescripcionEntidad", "Estado", "FechaAdd", "FechaUp", "MedioPagoId", "TipoEntidadId", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Presto", 2, null, null, 1, 1, "Sistema", null },
                    { 2, "Sandwich Cubano", 2, null, null, 2, 2, "Sistema", null },
                    { 3, "Juan Valdez", 2, null, null, 3, 3, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "Id", "CategoriaLogId", "DescripcionLog", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, 1, "Error al guardar la infromacion", 2, null, null, "Sistema", null },
                    { 2, 1, "Error al asignar el domicilio", 2, null, null, "Sistema", null },
                    { 3, 2, "Se debe seleccionar un ingrediente para el pedido", 2, null, null, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "Id", "DescripcionPermiso", "Estado", "FechaAdd", "FechaUp", "ModuloId", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Crear Calificacion", 2, null, null, 1, "Sistema", null },
                    { 2, "Actualizar Calificacion", 2, null, null, 1, "Sistema", null },
                    { 3, "Ver Calififaciones", 2, null, null, 1, "Sistema", null },
                    { 4, "Crear Catalogo", 2, null, null, 2, "Sistema", null },
                    { 5, "Actualizar Catalogos", 2, null, null, 2, "Sistema", null },
                    { 6, "Ver Calogos", 2, null, null, 2, "Sistema", null },
                    { 7, "Crear Categoria Logs", 2, null, null, 3, "Sistema", null },
                    { 8, "Actualizar Categoria Logs", 2, null, null, 3, "Sistema", null },
                    { 9, "Ver Calegorias Logs", 2, null, null, 3, "Sistema", null },
                    { 10, "Crear Categoria Productos", 2, null, null, 4, "Sistema", null },
                    { 11, "Actualizar Categoria Productos", 2, null, null, 4, "Sistema", null },
                    { 12, "Ver Calegorias Producto", 2, null, null, 4, "Sistema", null },
                    { 13, "Crear Chats", 2, null, null, 5, "Sistema", null },
                    { 14, "Actualizar Chats", 2, null, null, 5, "Sistema", null },
                    { 15, "Ver Chats", 2, null, null, 5, "Sistema", null },
                    { 16, "Crear Ciudades", 2, null, null, 6, "Sistema", null },
                    { 17, "Actualizar Ciudades", 2, null, null, 6, "Sistema", null },
                    { 18, "Ver Ciudades", 2, null, null, 6, "Sistema", null },
                    { 19, "Crear Criterio Evaluacion", 2, null, null, 7, "Sistema", null },
                    { 20, "Actualizar Criterio Evaluacion", 2, null, null, 7, "Sistema", null },
                    { 21, "Ver Criterios Evaluacion", 2, null, null, 7, "Sistema", null },
                    { 22, "Crear Departamentos", 2, null, null, 8, "Sistema", null },
                    { 23, "Actualizar Departamentos", 2, null, null, 8, "Sistema", null },
                    { 24, "Ver Departamentos", 2, null, null, 8, "Sistema", null },
                    { 25, "Crear Dias", 2, null, null, 9, "Sistema", null },
                    { 26, "Actualizar Dias", 2, null, null, 9, "Sistema", null },
                    { 27, "Ver Dias", 2, null, null, 9, "Sistema", null },
                    { 28, "Crear Domicilios", 2, null, null, 10, "Sistema", null },
                    { 29, "Actualizar Domicilios", 2, null, null, 10, "Sistema", null },
                    { 30, "Ver Domicilios", 2, null, null, 10, "Sistema", null },
                    { 31, "Crear Entidades", 2, null, null, 11, "Sistema", null },
                    { 32, "Actualizar Entidades", 2, null, null, 11, "Sistema", null },
                    { 33, "Ver Entidades", 2, null, null, 11, "Sistema", null },
                    { 34, "Crear Estados", 2, null, null, 12, "Sistema", null },
                    { 35, "Actualizar Estados", 2, null, null, 12, "Sistema", null },
                    { 36, "Ver Estados", 2, null, null, 12, "Sistema", null },
                    { 37, "Crear Fase Domicilios", 2, null, null, 13, "Sistema", null },
                    { 38, "Actualizar Fase Domicilios", 2, null, null, 13, "Sistema", null },
                    { 39, "Ver Fases Domicilio", 2, null, null, 13, "Sistema", null },
                    { 40, "Crear Horarios", 2, null, null, 14, "Sistema", null },
                    { 41, "Actualizar Horarios", 2, null, null, 14, "Sistema", null },
                    { 42, "Ver Horarios", 2, null, null, 14, "Sistema", null },
                    { 43, "Crear Items", 2, null, null, 15, "Sistema", null },
                    { 44, "Actualizar Items", 2, null, null, 15, "Sistema", null },
                    { 45, "Ver Items", 2, null, null, 15, "Sistema", null },
                    { 46, "Ver Logs", 2, null, null, 16, "Sistema", null },
                    { 47, "Crear Medio de Pago", 2, null, null, 17, "Sistema", null },
                    { 48, "Actualizar Medio Pago", 2, null, null, 17, "Sistema", null },
                    { 49, "Ver Medios de Pago", 2, null, null, 17, "Sistema", null },
                    { 50, "Crear Modulos", 2, null, null, 18, "Sistema", null },
                    { 51, "Actualizar Modulos", 2, null, null, 18, "Sistema", null },
                    { 52, "Ver Modulos", 2, null, null, 18, "Sistema", null },
                    { 53, "Crear Notificaciones", 2, null, null, 19, "Sistema", null },
                    { 54, "Actualizar Notificaciones", 2, null, null, 19, "Sistema", null },
                    { 55, "Ver Notificaciones", 2, null, null, 19, "Sistema", null },
                    { 56, "Ver Paises", 2, null, null, 20, "Sistema", null },
                    { 57, "Crear Parametro Evluacion", 2, null, null, 21, "Sistema", null },
                    { 58, "Actualizar Parametro Evluacion", 2, null, null, 21, "Sistema", null },
                    { 59, "Ver Parametros Evluacion", 2, null, null, 21, "Sistema", null },
                    { 60, "Crear Permisos", 2, null, null, 22, "Sistema", null },
                    { 61, "Actualizar Permisos", 2, null, null, 22, "Sistema", null },
                    { 62, "Ver Permisos", 2, null, null, 22, "Sistema", null },
                    { 63, "Crear PQRS", 2, null, null, 23, "Sistema", null },
                    { 64, "Actualizar PQRS", 2, null, null, 23, "Sistema", null },
                    { 65, "Ver PQRS", 2, null, null, 23, "Sistema", null },
                    { 66, "Crear Productos", 2, null, null, 24, "Sistema", null },
                    { 67, "Actualizar Productos", 2, null, null, 24, "Sistema", null },
                    { 68, "Ver Productos", 2, null, null, 24, "Sistema", null },
                    { 69, "Crear Promociones", 2, null, null, 25, "Sistema", null },
                    { 70, "Actualizar Promociones", 2, null, null, 25, "Sistema", null },
                    { 71, "Ver Promociones", 2, null, null, 25, "Sistema", null },
                    { 72, "Crear Rol", 2, null, null, 26, "Sistema", null },
                    { 73, "Actualizar Rol", 2, null, null, 26, "Sistema", null },
                    { 74, "Ver Rol", 2, null, null, 26, "Sistema", null },
                    { 75, "Crear Saldo", 2, null, null, 27, "Sistema", null },
                    { 76, "Actualizar Saldo", 2, null, null, 27, "Sistema", null },
                    { 78, "Ver Saldos", 2, null, null, 27, "Sistema", null },
                    { 79, "Crear Tiempo Fases", 2, null, null, 28, "Sistema", null },
                    { 80, "Actualizar Tiempo Fases", 2, null, null, 28, "Sistema", null },
                    { 81, "Ver Tiempo Fases", 2, null, null, 28, "Sistema", null },
                    { 82, "Crear Tipo Entidad", 2, null, null, 29, "Sistema", null },
                    { 83, "Actualizar Tipo Entidad", 2, null, null, 29, "Sistema", null },
                    { 84, "Ver Tipo Entidad", 2, null, null, 29, "Sistema", null },
                    { 85, "Crear Tipo Identificaciones", 2, null, null, 30, "Sistema", null },
                    { 86, "Actualizar Tipo Identificaciones", 2, null, null, 30, "Sistema", null },
                    { 87, "Ver Tipo Identificaciones", 2, null, null, 30, "Sistema", null },
                    { 88, "Crear Tipo Promociones", 2, null, null, 31, "Sistema", null },
                    { 89, "Actualizar Tipo Promociones", 2, null, null, 31, "Sistema", null },
                    { 90, "Ver Tipo Promociones", 2, null, null, 31, "Sistema", null },
                    { 91, "Crear Tipo TipoPQRS", 2, null, null, 32, "Sistema", null },
                    { 92, "Actualizar Tipo TipoPQRS", 2, null, null, 32, "Sistema", null },
                    { 93, "Ver Tipo TipoPQRS", 2, null, null, 32, "Sistema", null },
                    { 94, "Crear Tipo Transacciones", 2, null, null, 33, "Sistema", null },
                    { 95, "Actualizar Tipo Transacciones", 2, null, null, 33, "Sistema", null },
                    { 96, "Ver Tipo Transacciones", 2, null, null, 33, "Sistema", null },
                    { 97, "Crear Transacciones", 2, null, null, 34, "Sistema", null },
                    { 98, "Actualizar Transacciones", 2, null, null, 34, "Sistema", null },
                    { 99, "Ver Transacciones", 2, null, null, 34, "Sistema", null },
                    { 100, "Crear Usuario", 2, null, null, 35, "Sistema", null },
                    { 101, "Actualizar Usuario", 2, null, null, 35, "Sistema", null },
                    { 102, "Ver Usuarios", 2, null, null, 35, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "CategoriaProductoId", "DescripcionProducto", "DetalleProducto", "Estado", "FechaAdd", "FechaUp", "ImagenProducto", "UsuarioAdd", "UsuarioUp", "ValorProducto", "stock" },
                values: new object[,]
                {
                    { 1, 1, "Langosta a las finas hierbas", "Langosta de 600 gramos con salsas", 2, null, null, "", "Sistema", null, 120000m, 10 },
                    { 2, 1, "Hamburgesa", "Hamburgesa doble carne, con huevo y salsa de la casa", 2, null, null, "", "Sistema", null, 25000m, 5 },
                    { 3, 1, "Cerveza Modelo", "Caja de cervezas de 6 unidades", 2, null, null, "", "Sistema", null, 90000m, 12 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "DescripcionRol", "Estado", "FechaAdd", "FechaUp", "ModuloId", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Soporte", 2, null, null, 1, "Sistema", null },
                    { 2, "Administrador", 2, null, null, 2, "Sistema", null },
                    { 3, "Comercio", 2, null, null, 3, "Sistema", null },
                    { 4, "Domiciliario Propio", 2, null, null, 4, "Sistema", null },
                    { 5, "Domiciliario Externo", 2, null, null, 5, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "Id", "DepartamentoId", "Estado", "FechaAdd", "FechaUp", "NombreCiudad", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, 1, 2, null, null, "San Andres", "Sistema", null },
                    { 2, 2, 2, null, null, "Bogota", "Sistema", null },
                    { 3, 3, 2, null, null, "Tunja", "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Promociones",
                columns: new[] { "Id", "CodigoPromocional", "DescripcionPromocion", "Estado", "FechaAdd", "FechaFinPromocion", "FechaInicioPromocion", "FechaUp", "ImagenPromocion", "ProductoId", "TipoPromocionId", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "AAA123", "2x1", 2, null, new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 1, 1, "Sistema", null },
                    { 2, "ABC123", "Por tiempo limitado", 2, null, new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 2, 2, "Sistema", null },
                    { 3, "BCA123", "Descuento Especial", 2, null, new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 3, 3, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "ApellidoUsuario", "CausacionPagos", "Circulacion", "Correo", "DireccionUsuario", "Documentos", "Estado", "ExpedicionCedula", "FechaAdd", "FechaUp", "FormaPago", "HorarioUsuario", "ImagenUsuario", "LicenciaConduccion", "Login", "NombreUsuario", "Password", "PlacaMoto", "RolId", "TelefonoUsuario", "TipoIdentificacionId", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Cruz", "Diario", 1, "hcruz5785@gmail.com", "KR 109 A # 151 - 09", "documento.jpg", 2, new DateTime(2016, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 1, "", "SDHSDF", "1049655475", "Hector", "147258963***", "FUG321", 1, "3219856584", 2, "Sistema", null },
                    { 2, "Vargas", "Mensual", 1, "hcruz5785@gmail.com", "KR 95 A # 92 - 64", "documento.png", 2, new DateTime(2013, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2, 1, "", "WHDGS", "123456789", "Cristian", "147258963*1*", "BGE587", 2, "3123960059", 2, "Sistema", null },
                    { 3, "Ospina", "Quincenal", 1, "hcruz5785@gmail.com", "KR 97 A # 92 - 09", "documento.pdf", 2, new DateTime(2010, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 3, 1, "", "GEGSWFFS", "987654321", "Juan Pablo", "147**2*", "TTE432", 3, "3103232316", 2, "Sistema", null }
                });

            migrationBuilder.InsertData(
                table: "Domicilios",
                columns: new[] { "Id", "AceptaDomiciliario", "AceptaEntidad", "DescripcionDomicilio", "DomicilioExitoso", "Estado", "FaseDomicilioId", "FechaAceptaDomiciliario", "FechaAceptaEntidad", "FechaAdd", "FechaEntrega", "FechaUp", "ProductoId", "UsuarioAdd", "UsuarioId", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, 1, 1, "Domicilio - Hamburguesa", true, 2, 1, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Sistema", 1, null },
                    { 2, 1, 1, "Domicilio - Pescado a la marinera", true, 2, 5, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Sistema", 2, null },
                    { 3, 1, 1, "Domicilio - Langosta", true, 2, 3, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Sistema", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "Id", "DescripcionHorario", "DiaId", "DiasLaborales", "Estado", "FechaAdd", "FechaUp", "FranjaHorario", "HoraFin", "HoraInicio", "UsuarioAdd", "UsuarioId", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Horario Mañana", 1, "Lunes", 2, null, null, "Mañana", "12:00", "01:00", "Sistema", 1, null },
                    { 2, "Horario Tarde", 1, "Lunes", 2, null, null, "Tarde", "18:00", "12:00", "Sistema", 2, null },
                    { 3, "Horario Dia", 1, "Lunes", 2, null, null, "Dia", "18:00", "07:00", "Sistema", 2, null },
                    { 4, "Horario Nocturno", 1, "Lunes", 2, null, null, "Noche", "06:00", "18:00", "Sistema", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Notificaciones",
                columns: new[] { "Id", "DescripcionNotificacion", "Enviada", "Estado", "FechaAdd", "FechaUp", "UsuarioAdd", "UsuarioId", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Domicilio - Creacion de Pedido", false, 2, null, null, "Sistema", 1, null },
                    { 2, "Domicilio - Pedido va en camino", true, 2, null, null, "Sistema", 1, null },
                    { 3, "Domicilio - Pedido entregado", false, 2, null, null, "Sistema", 1, null }
                });

            migrationBuilder.InsertData(
                table: "PQRs",
                columns: new[] { "Id", "DescripcionPQRS", "Estado", "FechaAdd", "FechaUp", "TipoPQRSId", "UsuarioAdd", "UsuarioId", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Pedido retrasado segun estimacion de entrega", 2, null, null, 1, "Sistema", 3, null },
                    { 2, "Pedido con mala calidad en el producto", 2, null, null, 2, "Sistema", 3, null },
                    { 3, "Pedido con direccion errada", 2, null, null, 3, "Sistema", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Transacciones",
                columns: new[] { "Id", "DescripcionAdicional", "DescripcionTransaccion", "DomicilioId", "EntidadId", "Estado", "FechaAdd", "FechaUp", "TipoTransaccionId", "UsuarioAdd", "UsuarioUp" },
                values: new object[,]
                {
                    { 1, "Doble carne", "Pago Hamburguesa", 1, 1, 2, null, null, 1, "Sistema", null },
                    { 2, "Doble carne", "Pago Langosta", 2, 1, 2, null, null, 1, "Sistema", null },
                    { 3, "Doble carne", "Pago Cerveza Modelo", 3, 1, 2, null, null, 1, "Sistema", null }
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
                name: "IX_Notificaciones_UsuarioId",
                table: "Notificaciones",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_ModuloId",
                table: "Permisos",
                column: "ModuloId");

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
                name: "Parametrizaciones");

            migrationBuilder.DropTable(
                name: "Permisos");

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
        }
    }
}
