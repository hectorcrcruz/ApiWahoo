using Microsoft.EntityFrameworkCore;
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
            #region Registros creados por defecto en la base de datos
            List<Rol> RolInit = new List<Rol>();
            RolInit.Add(new Rol
            {
                Id = 1,
                DescripcionRol = "Administrador",
            });


            #endregion
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


    }
}
