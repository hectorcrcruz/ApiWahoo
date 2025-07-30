using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooDomain;
using WahooDomain.Common;

namespace WahooInfraestructure.Persistence
{
    public class WahooDbContext : DbContext
    {
        public WahooDbContext(DbContextOptions options) : base(options)
        {
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<Entity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.FechaAdd = DateTime.Now;
                        entry.Entity.UsuarioAdd = "Sistema";
                        break;
                    case EntityState.Modified:
                        entry.Entity.FechaUp = DateTime.Now;
                        entry.Entity.UsuarioUp = "Sistema";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pais>().HasData(
                new Pais { Id = 1, NombrePais = "Colombia", FechaAdd = DateTime.Now, UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Departamento>().HasData(
                new Departamento { Id = 1, NombreDepartamento = "San Andres Providencia y Santa Catalina", PaisId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Departamento { Id = 2, NombreDepartamento = "Cundinamarca", PaisId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Departamento { Id = 3, NombreDepartamento = "Boyaca", PaisId = 1, UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Ciudad>().HasData(
                new Ciudad { Id = 1, NombreCiudad = "San Andres", DepartamentoId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Ciudad { Id = 2, NombreCiudad = "Bogota", DepartamentoId = 2, UsuarioAdd = "Sistema", Estado = 2 },
                new Ciudad { Id = 3, NombreCiudad = "Tunja", DepartamentoId = 3, UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Dia>().HasData(
                new Dia { Id = 1, DescripcionDiaLaboral = "Lunes", UsuarioAdd = "Sistema", Estado = 2 },
                new Dia { Id = 2, DescripcionDiaLaboral = "Martes", UsuarioAdd = "Sistema", Estado = 2 },
                new Dia { Id = 3, DescripcionDiaLaboral = "Miercoles", UsuarioAdd = "Sistema", Estado = 2 },
                new Dia { Id = 4, DescripcionDiaLaboral = "Jueves", UsuarioAdd = "Sistema", Estado = 2 },
                new Dia { Id = 5, DescripcionDiaLaboral = "Viernes", UsuarioAdd = "Sistema", Estado = 2 },
                new Dia { Id = 6, DescripcionDiaLaboral = "Sabado", UsuarioAdd = "Sistema", Estado = 2 },
                new Dia { Id = 7, DescripcionDiaLaboral = "Domingo", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<TipoPromocion>().HasData(
                new TipoPromocion { Id = 1, DescripcionTipoPromocion = "Diaria", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoPromocion { Id = 2, DescripcionTipoPromocion = "Mensual", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoPromocion { Id = 3, DescripcionTipoPromocion = "Fecha Indefinida", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<TipoIdentificacion>().HasData(
                new TipoIdentificacion { Id = 1, DescripcionTipoIdentificacion = "Tarjeta de identidad", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoIdentificacion { Id = 2, DescripcionTipoIdentificacion = "Cedula de ciudadania", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoIdentificacion { Id = 3, DescripcionTipoIdentificacion = "Cedula extrajeria", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoIdentificacion { Id = 4, DescripcionTipoIdentificacion = "OCRRE Cedula Isleña", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoIdentificacion { Id = 5, DescripcionTipoIdentificacion = "Pasaporte", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<TipoPQRS>().HasData(
                new TipoPQRS { Id = 1, DescripcionTipoPQRS = "Queja", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoPQRS { Id = 2, DescripcionTipoPQRS = "Peticion o sugerencia", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoPQRS { Id = 3, DescripcionTipoPQRS = "Reclamo", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Rol>().HasData(
                new Rol { Id = 1, DescripcionRol = "Soporte", ModuloId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Rol { Id = 2, DescripcionRol = "Administrador", ModuloId = 2, UsuarioAdd = "Sistema", Estado = 2 },
                new Rol { Id = 3, DescripcionRol = "Comercio", ModuloId = 3, UsuarioAdd = "Sistema", Estado = 2 },
                new Rol { Id = 4, DescripcionRol = "Domiciliario Propio", ModuloId = 4, UsuarioAdd = "Sistema", Estado = 2 },
                new Rol { Id = 5, DescripcionRol = "Domiciliario Externo", ModuloId = 5, UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Estado>().HasData(
                new Estado { Id = 1, DescripcionEstado = "Activo", UsuarioAdd = "Sistema", Estado = 2 },
                new Estado { Id = 2, DescripcionEstado = "Inactivo", UsuarioAdd = "Sistema", Estado = 2 },
                new Estado { Id = 3, DescripcionEstado = "Pagado", UsuarioAdd = "Sistema", Estado = 2 },
                new Estado { Id = 4, DescripcionEstado = "Pendiente Pago", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<FaseDomicilio>().HasData(
                new FaseDomicilio { Id = 1, DescripcionFaseDomicilio = "Domicilio Creado", UsuarioAdd = "Sistema", Estado = 2 },
                new FaseDomicilio { Id = 2, DescripcionFaseDomicilio = "Domicilio en Proceso", UsuarioAdd = "Sistema", Estado = 2 },
                new FaseDomicilio { Id = 3, DescripcionFaseDomicilio = "Domicilio Cancelado", UsuarioAdd = "Sistema", Estado = 2 },
                new FaseDomicilio { Id = 4, DescripcionFaseDomicilio = "Domicilio en camino", UsuarioAdd = "Sistema", Estado = 2 },
                new FaseDomicilio { Id = 5, DescripcionFaseDomicilio = "Domicilio Pendiente", UsuarioAdd = "Sistema", Estado = 2 },
                new FaseDomicilio { Id = 6, DescripcionFaseDomicilio = "Domicilio Aceptado", UsuarioAdd = "Sistema", Estado = 2 },
                new FaseDomicilio { Id = 7, DescripcionFaseDomicilio = "Domicilio Recibido", UsuarioAdd = "Sistema", Estado = 2 }

            );

            modelBuilder.Entity<MedioPago>().HasData(
                new MedioPago { Id = 1, DescripcionMedioPago = "Efectivo", UsuarioAdd = "Sistema", Estado = 2 },
                new MedioPago { Id = 2, DescripcionMedioPago = "Tarjeta de credito", UsuarioAdd = "Sistema", Estado = 2 },
                new MedioPago { Id = 3, DescripcionMedioPago = "Tarjeta debito", UsuarioAdd = "Sistema", Estado = 2 },
                new MedioPago { Id = 4, DescripcionMedioPago = "PSE", UsuarioAdd = "Sistema", Estado = 2 },
                new MedioPago { Id = 5, DescripcionMedioPago = "Nequi", UsuarioAdd = "Sistema", Estado = 2 },
                new MedioPago { Id = 6, DescripcionMedioPago = "Daviplata", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<TipoEntidad>().HasData(
                new TipoEntidad { Id = 1, DescripcionTipoEntidad = "Banco", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoEntidad { Id = 2, DescripcionTipoEntidad = "Restaurante", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoEntidad { Id = 3, DescripcionTipoEntidad = "Comercio", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Entidad>().HasData(
                new Entidad { Id = 1, DescripcionEntidad = "Presto", TipoEntidadId = 1, MedioPagoId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Entidad { Id = 2, DescripcionEntidad = "Sandwich Cubano", TipoEntidadId = 2, MedioPagoId = 2, UsuarioAdd = "Sistema", Estado = 2 },
                new Entidad { Id = 3, DescripcionEntidad = "Juan Valdez", TipoEntidadId = 3, MedioPagoId = 3, UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<CategoriaLog>().HasData(
                new CategoriaLog { Id = 1, DescripcionCategoriaLog = "Error", UsuarioAdd = "Sistema", Estado = 2 },
                new CategoriaLog { Id = 2, DescripcionCategoriaLog = "Aviso", UsuarioAdd = "Sistema", Estado = 2 },
                new CategoriaLog { Id = 3, DescripcionCategoriaLog = "Alerta", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Log>().HasData(
                new Log { Id = 1, DescripcionLog = "Error al guardar la infromacion", CategoriaLogId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Log { Id = 2, DescripcionLog = "Error al asignar el domicilio", CategoriaLogId = 2, UsuarioAdd = "Sistema", Estado = 2 },
                new Log { Id = 3, DescripcionLog = "Se debe seleccionar un ingrediente para el pedido", CategoriaLogId = 3, UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<CategoriaProducto>().HasData(
                new CategoriaProducto { Id = 1, DescripcionCategoriaProducto = "Restaurante", UsuarioAdd = "Sistema", Estado = 2 },
                new CategoriaProducto { Id = 2, DescripcionCategoriaProducto = "Hogar", UsuarioAdd = "Sistema", Estado = 2 },
                new CategoriaProducto { Id = 3, DescripcionCategoriaProducto = "Deporte", UsuarioAdd = "Sistema", Estado = 2 },
                new CategoriaProducto { Id = 4, DescripcionCategoriaProducto = "Turismo", UsuarioAdd = "Sistema", Estado = 2 },
                new CategoriaProducto { Id = 5, DescripcionCategoriaProducto = "Construccion", UsuarioAdd = "Sistema", Estado = 2 },
                new CategoriaProducto { Id = 6, DescripcionCategoriaProducto = "Tecnologia", UsuarioAdd = "Sistema", Estado = 2 }

            );

            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, DescripcionItem = "Cebolla", CantidadItem = 500, UnidadMedidaItem = "Miligramos", UsuarioAdd = "Sistema", Estado = 2 },
                new Item { Id = 2, DescripcionItem = "Queso", CantidadItem = 2, UnidadMedidaItem = "Libras", UsuarioAdd = "Sistema", Estado = 2 },
                new Item { Id = 3, DescripcionItem = "Especies", CantidadItem = 50, UnidadMedidaItem = "Miligramos", UsuarioAdd = "Sistema", Estado = 2 },
                new Item { Id = 4, DescripcionItem = "Papas", CantidadItem = 1, UnidadMedidaItem = "Kilo", UsuarioAdd = "Sistema", Estado = 2 },
                new Item { Id = 5, DescripcionItem = "Pescado", CantidadItem = 100, UnidadMedidaItem = "Gramos", UsuarioAdd = "Sistema", Estado = 2 },
                new Item { Id = 6, DescripcionItem = "Salsa de tomate", CantidadItem = 50, UnidadMedidaItem = "Miligramos", UsuarioAdd = "Sistema", Estado = 2 }

            );

            modelBuilder.Entity<Catalogo>().HasData(
                new Catalogo { Id = 1, DescripcionCatalogo = "Hamburguesa", ItemId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Catalogo { Id = 2, DescripcionCatalogo = "Pescado a la marinera", ItemId = 5, UsuarioAdd = "Sistema", Estado = 2 },
                new Catalogo { Id = 3, DescripcionCatalogo = "Langosta", ItemId = 3, UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Modulo>().HasData(
                new Modulo { Id = 1, DescripcionModulo = "Calificaciones", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 2, DescripcionModulo = "Catalogo", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 3, DescripcionModulo = "Categoria Log", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 4, DescripcionModulo = "Categoria Producto", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 5, DescripcionModulo = "Chat", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 6, DescripcionModulo = "Ciudad", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 7, DescripcionModulo = "Criterio Evaluacion", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 8, DescripcionModulo = "Departamentos", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 9, DescripcionModulo = "Dias", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 10, DescripcionModulo = "Domicilio", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 11, DescripcionModulo = "Entidad", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 12, DescripcionModulo = "Estado", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 13, DescripcionModulo = "Fase Domicilio", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 14, DescripcionModulo = "Horarios", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 15, DescripcionModulo = "Item", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 16, DescripcionModulo = "Logs", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 17, DescripcionModulo = "Medios de Pago", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 18, DescripcionModulo = "Modulos", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 19, DescripcionModulo = "Notificaciones", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 20, DescripcionModulo = "Pais", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 21, DescripcionModulo = "Parametro Evaluacion", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 22, DescripcionModulo = "Permisos", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 23, DescripcionModulo = "PQRS", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 24, DescripcionModulo = "Productos", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 25, DescripcionModulo = "Promociones", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 26, DescripcionModulo = "Roles", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 27, DescripcionModulo = "Saldos", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 28, DescripcionModulo = "Tiempo Fase", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 29, DescripcionModulo = "Tipo Entidad", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 30, DescripcionModulo = "Tipo Identificacion", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 31, DescripcionModulo = "Tipo PQRS", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 32, DescripcionModulo = "Tipo Promocion", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 33, DescripcionModulo = "Tipo Transaccion", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 34, DescripcionModulo = "Transacciones", UsuarioAdd = "Sistema", Estado = 2 },
                new Modulo { Id = 35, DescripcionModulo = "Usuarios", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Permiso>().HasData(

            #region Calificaciones
                new Permiso { Id = 1, DescripcionPermiso = "Crear Calificacion", ModuloId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 2, DescripcionPermiso = "Actualizar Calificacion", ModuloId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 3, DescripcionPermiso = "Ver Calififaciones", ModuloId = 1, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Catalogos
                new Permiso { Id = 4, DescripcionPermiso = "Crear Catalogo", ModuloId = 2, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 5, DescripcionPermiso = "Actualizar Catalogos", ModuloId = 2, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 6, DescripcionPermiso = "Ver Calogos", ModuloId = 2, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region CategoriaLogs
                new Permiso { Id = 7, DescripcionPermiso = "Crear Categoria Logs", ModuloId = 3, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 8, DescripcionPermiso = "Actualizar Categoria Logs", ModuloId = 3, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 9, DescripcionPermiso = "Ver Calegorias Logs", ModuloId = 3, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region CategoriaProductos
                new Permiso { Id = 10, DescripcionPermiso = "Crear Categoria Productos", ModuloId = 4, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 11, DescripcionPermiso = "Actualizar Categoria Productos", ModuloId = 4, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 12, DescripcionPermiso = "Ver Calegorias Producto", ModuloId = 4, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Chats
                new Permiso { Id = 13, DescripcionPermiso = "Crear Chats", ModuloId = 5, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 14, DescripcionPermiso = "Actualizar Chats", ModuloId = 5, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 15, DescripcionPermiso = "Ver Chats", ModuloId = 5, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Ciudades
                new Permiso { Id = 16, DescripcionPermiso = "Crear Ciudades", ModuloId = 6, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 17, DescripcionPermiso = "Actualizar Ciudades", ModuloId = 6, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 18, DescripcionPermiso = "Ver Ciudades", ModuloId = 6, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region CriterioEvaluacion
                new Permiso { Id = 19, DescripcionPermiso = "Crear Criterio Evaluacion", ModuloId = 7, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 20, DescripcionPermiso = "Actualizar Criterio Evaluacion", ModuloId = 7, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 21, DescripcionPermiso = "Ver Criterios Evaluacion", ModuloId = 7, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Departamentos
                new Permiso { Id = 22, DescripcionPermiso = "Crear Departamentos", ModuloId = 8, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 23, DescripcionPermiso = "Actualizar Departamentos", ModuloId = 8, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 24, DescripcionPermiso = "Ver Departamentos", ModuloId = 8, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Dias
                new Permiso { Id = 25, DescripcionPermiso = "Crear Dias", ModuloId = 9, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 26, DescripcionPermiso = "Actualizar Dias", ModuloId = 9, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 27, DescripcionPermiso = "Ver Dias", ModuloId = 9, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Domicilios
                new Permiso { Id = 28, DescripcionPermiso = "Crear Domicilios", ModuloId = 10, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 29, DescripcionPermiso = "Actualizar Domicilios", ModuloId = 10, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 30, DescripcionPermiso = "Ver Domicilios", ModuloId = 10, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Entidades
                new Permiso { Id = 31, DescripcionPermiso = "Crear Entidades", ModuloId = 11, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 32, DescripcionPermiso = "Actualizar Entidades", ModuloId = 11, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 33, DescripcionPermiso = "Ver Entidades", ModuloId = 11, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Estados
                new Permiso { Id = 34, DescripcionPermiso = "Crear Estados", ModuloId = 12, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 35, DescripcionPermiso = "Actualizar Estados", ModuloId = 12, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 36, DescripcionPermiso = "Ver Estados", ModuloId = 12, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region FaseDomcilios
                new Permiso { Id = 37, DescripcionPermiso = "Crear Fase Domicilios", ModuloId = 13, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 38, DescripcionPermiso = "Actualizar Fase Domicilios", ModuloId = 13, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 39, DescripcionPermiso = "Ver Fases Domicilio", ModuloId = 13, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Horarios
                new Permiso { Id = 40, DescripcionPermiso = "Crear Horarios", ModuloId = 14, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 41, DescripcionPermiso = "Actualizar Horarios", ModuloId = 14, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 42, DescripcionPermiso = "Ver Horarios", ModuloId = 14, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Items
                new Permiso { Id = 43, DescripcionPermiso = "Crear Items", ModuloId = 15, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 44, DescripcionPermiso = "Actualizar Items", ModuloId = 15, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 45, DescripcionPermiso = "Ver Items", ModuloId = 15, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Logs
                new Permiso { Id = 46, DescripcionPermiso = "Ver Logs", ModuloId = 16, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region MedioPago
                new Permiso { Id = 47, DescripcionPermiso = "Crear Medio de Pago", ModuloId = 17, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 48, DescripcionPermiso = "Actualizar Medio Pago", ModuloId = 17, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 49, DescripcionPermiso = "Ver Medios de Pago", ModuloId = 17, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Modulos
                new Permiso { Id = 50, DescripcionPermiso = "Crear Modulos", ModuloId = 18, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 51, DescripcionPermiso = "Actualizar Modulos", ModuloId = 18, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 52, DescripcionPermiso = "Ver Modulos", ModuloId = 18, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Notificaciones
                new Permiso { Id = 53, DescripcionPermiso = "Crear Notificaciones", ModuloId = 19, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 54, DescripcionPermiso = "Actualizar Notificaciones", ModuloId = 19, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 55, DescripcionPermiso = "Ver Notificaciones", ModuloId = 19, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Paises
                new Permiso { Id = 56, DescripcionPermiso = "Ver Paises", ModuloId = 20, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region ParametroEvaluaciones
                new Permiso { Id = 57, DescripcionPermiso = "Crear Parametro Evluacion", ModuloId = 21, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 58, DescripcionPermiso = "Actualizar Parametro Evluacion", ModuloId = 21, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 59, DescripcionPermiso = "Ver Parametros Evluacion", ModuloId = 21, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Permisos
                new Permiso { Id = 60, DescripcionPermiso = "Crear Permisos", ModuloId = 22, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 61, DescripcionPermiso = "Actualizar Permisos", ModuloId = 22, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 62, DescripcionPermiso = "Ver Permisos", ModuloId = 22, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region PQRS
                new Permiso { Id = 63, DescripcionPermiso = "Crear PQRS", ModuloId = 23, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 64, DescripcionPermiso = "Actualizar PQRS", ModuloId = 23, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 65, DescripcionPermiso = "Ver PQRS", ModuloId = 23, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Productos
                new Permiso { Id = 66, DescripcionPermiso = "Crear Productos", ModuloId = 24, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 67, DescripcionPermiso = "Actualizar Productos", ModuloId = 24, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 68, DescripcionPermiso = "Ver Productos", ModuloId = 24, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Promociones
                new Permiso { Id = 69, DescripcionPermiso = "Crear Promociones", ModuloId = 25, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 70, DescripcionPermiso = "Actualizar Promociones", ModuloId = 25, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 71, DescripcionPermiso = "Ver Promociones", ModuloId = 25, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Roles
                new Permiso { Id = 72, DescripcionPermiso = "Crear Rol", ModuloId = 26, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 73, DescripcionPermiso = "Actualizar Rol", ModuloId = 26, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 74, DescripcionPermiso = "Ver Rol", ModuloId = 26, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Saldos
                new Permiso { Id = 75, DescripcionPermiso = "Crear Saldo", ModuloId = 27, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 76, DescripcionPermiso = "Actualizar Saldo", ModuloId = 27, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 78, DescripcionPermiso = "Ver Saldos", ModuloId = 27, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region TiempoFases
                new Permiso { Id = 79, DescripcionPermiso = "Crear Tiempo Fases", ModuloId = 28, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 80, DescripcionPermiso = "Actualizar Tiempo Fases", ModuloId = 28, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 81, DescripcionPermiso = "Ver Tiempo Fases", ModuloId = 28, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region TipoEntidades
                new Permiso { Id = 82, DescripcionPermiso = "Crear Tipo Entidad", ModuloId = 29, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 83, DescripcionPermiso = "Actualizar Tipo Entidad", ModuloId = 29, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 84, DescripcionPermiso = "Ver Tipo Entidad", ModuloId = 29, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region TipoIdentificaciones
                new Permiso { Id = 85, DescripcionPermiso = "Crear Tipo Identificaciones", ModuloId = 30, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 86, DescripcionPermiso = "Actualizar Tipo Identificaciones", ModuloId = 30, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 87, DescripcionPermiso = "Ver Tipo Identificaciones", ModuloId = 30, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region TipoPromociones
                new Permiso { Id = 88, DescripcionPermiso = "Crear Tipo Promociones", ModuloId = 31, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 89, DescripcionPermiso = "Actualizar Tipo Promociones", ModuloId = 31, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 90, DescripcionPermiso = "Ver Tipo Promociones", ModuloId = 31, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region TipoPQRS
                new Permiso { Id = 91, DescripcionPermiso = "Crear Tipo TipoPQRS", ModuloId = 32, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 92, DescripcionPermiso = "Actualizar Tipo TipoPQRS", ModuloId = 32, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 93, DescripcionPermiso = "Ver Tipo TipoPQRS", ModuloId = 32, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region TipoTransacciones
                new Permiso { Id = 94, DescripcionPermiso = "Crear Tipo Transacciones", ModuloId = 33, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 95, DescripcionPermiso = "Actualizar Tipo Transacciones", ModuloId = 33, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 96, DescripcionPermiso = "Ver Tipo Transacciones", ModuloId = 33, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Transacciones
                new Permiso { Id = 97, DescripcionPermiso = "Crear Transacciones", ModuloId = 34, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 98, DescripcionPermiso = "Actualizar Transacciones", ModuloId = 34, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 99, DescripcionPermiso = "Ver Transacciones", ModuloId = 34, UsuarioAdd = "Sistema", Estado = 2 },
            #endregion

            #region Usuarios
                new Permiso { Id = 100, DescripcionPermiso = "Crear Usuario", ModuloId = 35, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 101, DescripcionPermiso = "Actualizar Usuario", ModuloId = 35, UsuarioAdd = "Sistema", Estado = 2 },
                new Permiso { Id = 102, DescripcionPermiso = "Ver Usuarios", ModuloId = 35, UsuarioAdd = "Sistema", Estado = 2 }
                #endregion

            );

            modelBuilder.Entity<CriterioEvaluacion>().HasData(
                new CriterioEvaluacion { Id = 1, DescripcionCriterioEvaluacion = "Excelente", UsuarioAdd = "Sistema", Estado = 2 },
                new CriterioEvaluacion { Id = 2, DescripcionCriterioEvaluacion = "Bueno", UsuarioAdd = "Sistema", Estado = 2 },
                new CriterioEvaluacion { Id = 3, DescripcionCriterioEvaluacion = "Aceptable", UsuarioAdd = "Sistema", Estado = 2 },
                new CriterioEvaluacion { Id = 4, DescripcionCriterioEvaluacion = "Regular", UsuarioAdd = "Sistema", Estado = 2 },
                new CriterioEvaluacion { Id = 5, DescripcionCriterioEvaluacion = "Malo", UsuarioAdd = "Sistema", Estado = 2 },
                new CriterioEvaluacion { Id = 7, DescripcionCriterioEvaluacion = "Pesimo", UsuarioAdd = "Sistema", Estado = 2 }

            );

            modelBuilder.Entity<ParametroEvaluacion>().HasData(
                new ParametroEvaluacion { Id = 1, DescripcionParametro = "¿Que tan satisfecho estas con el servicio ofrecido?", UsuarioAdd = "Sistema", Estado = 2 },
                new ParametroEvaluacion { Id = 2, DescripcionParametro = "¿Recomendarias el servicio?", UsuarioAdd = "Sistema", Estado = 2 },
                new ParametroEvaluacion { Id = 3, DescripcionParametro = "¿Estas conforme con la calidad del pedido?", UsuarioAdd = "Sistema", Estado = 2 },
                new ParametroEvaluacion { Id = 4, DescripcionParametro = "¿Los tiempos de entrega son razonables?", UsuarioAdd = "Sistema", Estado = 2 },
                new ParametroEvaluacion { Id = 5, DescripcionParametro = "¿El servicios se entrega segun lo pedido?", UsuarioAdd = "Sistema", Estado = 2 },
                new ParametroEvaluacion { Id = 6, DescripcionParametro = "¿El domciliario ha sido gentil y respetuoso?", UsuarioAdd = "Sistema", Estado = 2 }

            );

            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1, DescripcionProducto = "Langosta a las finas hierbas", DetalleProducto = "Langosta de 600 gramos con salsas", CategoriaProductoId = 1, stock = 10, ValorProducto = 120000, ImagenProducto = "", UsuarioAdd = "Sistema", Estado = 2 },
                new Producto { Id = 2, DescripcionProducto = "Hamburgesa", DetalleProducto = "Hamburgesa doble carne, con huevo y salsa de la casa", CategoriaProductoId = 1, stock = 5, ValorProducto = 25000, ImagenProducto = "", UsuarioAdd = "Sistema", Estado = 2 },
                new Producto { Id = 3, DescripcionProducto = "Cerveza Modelo", DetalleProducto = "Caja de cervezas de 6 unidades", CategoriaProductoId = 1, stock = 12, ValorProducto = 90000, ImagenProducto = "", UsuarioAdd = "Sistema", Estado = 2 }
                );

            modelBuilder.Entity<Promocion>().HasData(
                new Promocion { Id = 1, DescripcionPromocion = "2x1", ProductoId = 1, TipoPromocionId = 1, FechaInicioPromocion = Convert.ToDateTime("2025-04-24"), FechaFinPromocion = Convert.ToDateTime("2025-04-27"), CodigoPromocional = "AAA123", ImagenPromocion = "", UsuarioAdd = "Sistema", Estado = 2 },
                new Promocion { Id = 2, DescripcionPromocion = "Por tiempo limitado", ProductoId = 2, TipoPromocionId = 2, FechaInicioPromocion = Convert.ToDateTime("2025-04-24"), FechaFinPromocion = Convert.ToDateTime("2025-04-27"), CodigoPromocional = "ABC123", ImagenPromocion = "", UsuarioAdd = "Sistema", Estado = 2 },
                new Promocion { Id = 3, DescripcionPromocion = "Descuento Especial", ProductoId = 3, TipoPromocionId = 3, FechaInicioPromocion = Convert.ToDateTime("2025-04-24"), FechaFinPromocion = Convert.ToDateTime("2025-04-27"), CodigoPromocional = "BCA123", ImagenPromocion = "", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, NombreUsuario = "Hector", ApellidoUsuario = "Cruz", TipoIdentificacionId = 2, TelefonoUsuario = "3219856584", ExpedicionCedula = Convert.ToDateTime("2016-11-18"), Login = "1049655475", LicenciaConduccion = "SDHSDF", Correo = "hcruz5785@gmail.com", DireccionUsuario = "KR 109 A # 151 - 09", FormaPago = 1, Password = "147258963***", PlacaMoto = "FUG321", RolId = 1, Documentos = "documento.jpg", HorarioUsuario = 1, CausacionPagos = "Diario", Circulacion = 1, ImagenUsuario = "", UsuarioAdd = "Sistema", Estado = 2 },
                new Usuario { Id = 2, NombreUsuario = "Cristian", ApellidoUsuario = "Vargas", TipoIdentificacionId = 2, TelefonoUsuario = "3123960059", ExpedicionCedula = Convert.ToDateTime("2013-11-20"), Login = "123456789", LicenciaConduccion = "WHDGS", Correo = "hcruz5785@gmail.com", DireccionUsuario = "KR 95 A # 92 - 64", FormaPago = 2, Password = "147258963*1*", PlacaMoto = "BGE587", RolId = 2, Documentos = "documento.png", HorarioUsuario = 1, CausacionPagos = "Mensual", Circulacion = 1, ImagenUsuario = "", UsuarioAdd = "Sistema", Estado = 2 },
                new Usuario { Id = 3, NombreUsuario = "Juan Pablo", ApellidoUsuario = "Ospina", TipoIdentificacionId = 2, TelefonoUsuario = "3103232316", ExpedicionCedula = Convert.ToDateTime("2010-11-22"), Login = "987654321", LicenciaConduccion = "GEGSWFFS", Correo = "hcruz5785@gmail.com", DireccionUsuario = "KR 97 A # 92 - 09", FormaPago = 3, Password = "147**2*", PlacaMoto = "TTE432", RolId = 3, Documentos = "documento.pdf", HorarioUsuario = 1, CausacionPagos = "Quincenal", Circulacion = 1, ImagenUsuario = "", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Domicilio>().HasData(
                new Domicilio { Id = 1, DescripcionDomicilio = "Domicilio - Hamburguesa", UsuarioId = 1, FaseDomicilioId = 1, FechaEntrega = Convert.ToDateTime("2024-04-24"), FechaAceptaEntidad = Convert.ToDateTime("2024-04-24"), FechaAceptaDomiciliario = Convert.ToDateTime("2024-04-24"), ProductoId = 1, AceptaDomiciliario = 1, AceptaEntidad = 1, DomicilioExitoso = true, UsuarioAdd = "Sistema", Estado = 2 },
                new Domicilio { Id = 2, DescripcionDomicilio = "Domicilio - Pescado a la marinera", UsuarioId = 2, FaseDomicilioId = 5, FechaEntrega = Convert.ToDateTime("2024-04-24"), FechaAceptaEntidad = Convert.ToDateTime("2024-04-24"), FechaAceptaDomiciliario = Convert.ToDateTime("2024-04-24"), ProductoId = 1, AceptaDomiciliario = 1, AceptaEntidad = 1, DomicilioExitoso = true, UsuarioAdd = "Sistema", Estado = 2 },
                new Domicilio { Id = 3, DescripcionDomicilio = "Domicilio - Langosta", UsuarioId = 3, FaseDomicilioId = 3, FechaEntrega = Convert.ToDateTime("2024-04-24"), FechaAceptaEntidad = Convert.ToDateTime("2024-04-24"), FechaAceptaDomiciliario = Convert.ToDateTime("2024-04-24"), ProductoId = 1, AceptaDomiciliario = 1, AceptaEntidad = 1, DomicilioExitoso = true, UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Horario>().HasData(
                new Horario { Id = 1, DescripcionHorario = "Horario Mañana", UsuarioId = 1, HoraInicio = "01:00", HoraFin = "12:00", DiaId = 1, FranjaHorario = "Mañana", DiasLaborales = "Lunes", UsuarioAdd = "Sistema", Estado = 2 },
                new Horario { Id = 2, DescripcionHorario = "Horario Tarde", UsuarioId = 2, HoraInicio = "12:00", HoraFin = "18:00", DiaId = 1, FranjaHorario = "Tarde", DiasLaborales = "Lunes", UsuarioAdd = "Sistema", Estado = 2 },
                new Horario { Id = 3, DescripcionHorario = "Horario Dia", UsuarioId = 2, HoraInicio = "07:00", HoraFin = "18:00", DiaId = 1, FranjaHorario = "Dia", DiasLaborales = "Lunes", UsuarioAdd = "Sistema", Estado = 2 },
                new Horario { Id = 4, DescripcionHorario = "Horario Nocturno", UsuarioId = 3, HoraInicio = "18:00", HoraFin = "06:00", DiaId = 1, FranjaHorario = "Noche", DiasLaborales = "Lunes", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<PQRS>().HasData(
                new PQRS { Id = 1, DescripcionPQRS = "Pedido retrasado segun estimacion de entrega", TipoPQRSId = 1, UsuarioId = 3, UsuarioAdd = "Sistema", Estado = 2 },
                new PQRS { Id = 2, DescripcionPQRS = "Pedido con mala calidad en el producto", TipoPQRSId = 2, UsuarioId = 3, UsuarioAdd = "Sistema", Estado = 2 },
                new PQRS { Id = 3, DescripcionPQRS = "Pedido con direccion errada", TipoPQRSId = 3, UsuarioId = 3, UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Chat>().HasData(
                new Chat { Id = 1, Emisor = 1, Receptor = 2, Mensaje = "Hola buen dia", Documento = "document.pdf", DocumentoSoporte = "document.pdf", UsuarioAdd = "Sistema", Estado = 2 },
                new Chat { Id = 2, Emisor = 2, Receptor = 1, Mensaje = "Hola buen dia", Documento = "document.jpg", DocumentoSoporte = "document.jpg", UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<Notificacion>().HasData(
                new Notificacion { Id = 1, DescripcionNotificacion = "Domicilio - Creacion de Pedido", Enviada = false, UsuarioId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Notificacion { Id = 2, DescripcionNotificacion = "Domicilio - Pedido va en camino", Enviada = true, UsuarioId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Notificacion { Id = 3, DescripcionNotificacion = "Domicilio - Pedido entregado", Enviada = false, UsuarioId = 1, UsuarioAdd = "Sistema", Estado = 2 }
            );

            modelBuilder.Entity<TipoTransaccion>().HasData(
                new TipoTransaccion { Id = 1, DecripcionTipoTransaccion = "Pago Domicilio", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoTransaccion { Id = 2, DecripcionTipoTransaccion = "Pago Domiciliario", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoTransaccion { Id = 3, DecripcionTipoTransaccion = "Pago Aliados", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoTransaccion { Id = 4, DecripcionTipoTransaccion = "Pago Susbcripcion", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoTransaccion { Id = 5, DecripcionTipoTransaccion = "Pago Domciliario", UsuarioAdd = "Sistema", Estado = 2 },
                new TipoTransaccion { Id = 6, DecripcionTipoTransaccion = "Pago Clientes", UsuarioAdd = "Sistema", Estado = 2 }

            );

            modelBuilder.Entity<Transaccion>().HasData(
                new Transaccion { Id = 1, DescripcionTransaccion = "Pago Hamburguesa", DescripcionAdicional = "Doble carne", DomicilioId = 1, EntidadId = 1, TipoTransaccionId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Transaccion { Id = 2, DescripcionTransaccion = "Pago Langosta", DescripcionAdicional = "Doble carne", DomicilioId = 2, EntidadId = 1, TipoTransaccionId = 1, UsuarioAdd = "Sistema", Estado = 2 },
                new Transaccion { Id = 3, DescripcionTransaccion = "Pago Cerveza Modelo", DescripcionAdicional = "Doble carne", DomicilioId = 3, EntidadId = 1, TipoTransaccionId = 1, UsuarioAdd = "Sistema", Estado = 2 }
            );


            modelBuilder.Entity<Calificacion>().HasData(
            new Calificacion { Id = 1, PuntajeCalificacion = 10, ParametroEvaluacionId = 1, CriterioEvaluacionId = 1, UsuarioId = 1, UsuarioAdd = "Sistema", Estado = 2 },
            new Calificacion { Id = 2, PuntajeCalificacion = 09, ParametroEvaluacionId = 2, CriterioEvaluacionId = 2, UsuarioId = 2, UsuarioAdd = "Sistema", Estado = 2 },
            new Calificacion { Id = 3, PuntajeCalificacion = 05, ParametroEvaluacionId = 3, CriterioEvaluacionId = 3, UsuarioId = 3, UsuarioAdd = "Sistema", Estado = 2 }
        );

            modelBuilder.Entity<Parametrizacion>().HasData(
                new Parametrizacion { Id = 1, NombreApp = "Wahoo", Logo = "", ColorTexto = "", ColorPrimario = "#733089", ColorSecundario = "#ebbaf7", ColorTerciario = "#f9e5ff", ColorBotonCrear = "#cb2c7f", ColorBotonActualizar = "#720094", ColorBotonEliminar = "#cc1329", TextoPrimario = "2025", TextoSecundario = "SofToolSolution", TextoTerciario = "Promociones y descuentos especiales", TextoCuaternario = "Publicidad", TipoLetra = "Agency FB", Footer = "Todos los derechos reservados", UsuarioAdd = "Sistema", Estado = 2 },
                new Parametrizacion { Id = 2, NombreApp = "Trueque", Logo = "", ColorTexto = "", ColorPrimario = "#733089", ColorSecundario = "#ebbaf7", ColorTerciario = "#f9e5ff", ColorBotonCrear = "#cb2c7f", ColorBotonActualizar = "#720094", ColorBotonEliminar = "#cc1329", TextoPrimario = "2025", TextoSecundario = "SofToolSolution", TextoTerciario = "Promociones y descuentos especiales", TextoCuaternario = "Publicidad", TipoLetra = "Agency FB", Footer = "Todos los derechos reservados", UsuarioAdd = "Sistema", Estado = 2 },
                new Parametrizacion { Id = 3, NombreApp = "DomiYa", Logo = "", ColorTexto = "", ColorPrimario = "#733089", ColorSecundario = "#ebbaf7", ColorTerciario = "#f9e5ff", ColorBotonCrear = "#cb2c7f", ColorBotonActualizar = "#720094", ColorBotonEliminar = "#cc1329", TextoPrimario = "2025", TextoSecundario = "SofToolSolution", TextoTerciario = "Promociones y descuentos especiales", TextoCuaternario = "Publicidad", TipoLetra = "Agency FB", Footer = "Todos los derechos reservados", UsuarioAdd = "Sistema", Estado = 2 }
            );

        }
        public DbSet<Calificacion> Calificaciones { get; set; }
        public DbSet<Catalogo> Catalogos { get; set; }
        public DbSet<CategoriaLog> CategoriaLogs { get; set; }
        public DbSet<CategoriaProducto> CategoriaProductos { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<CriterioEvaluacion> CriterioEvaluaciones { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Dia> Dias { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<Entidad> Entidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<FaseDomicilio> FaseDomicilios { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<MedioPago> MedioPagos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<ParametroEvaluacion> ParametroEvaluaciones { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<PQRS> PQRs { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Promocion> Promociones { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Saldo> Saldos { get; set; }
        public DbSet<TiempoFase> TiempoFases { get; set; }
        public DbSet<TipoEntidad> TipoEntidades { get; set; }
        public DbSet<TipoIdentificacion> TipoIdentificaciones { get; set; }
        public DbSet<TipoPromocion> TipoPromociones { get; set; }
        public DbSet<TipoPQRS> TipoPQRs { get; set; }
        public DbSet<TipoTransaccion> TipoTransacciones { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Parametrizacion> Parametrizaciones { get; set; }


    }
}
