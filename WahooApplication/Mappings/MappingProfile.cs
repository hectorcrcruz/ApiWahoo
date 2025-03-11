using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Features.Calificacion.Commands.CreateCalificacion;
using WahooApplication.Features.Calificacion.Commands.UpCalificacion;
using WahooApplication.Features.Catalogo.Commands.AddCatalogo;
using WahooApplication.Features.Catalogo.Commands.UpCatalogo;
using WahooApplication.Features.CategoriaLog.Commands.AddCategoriaLogs;
using WahooApplication.Features.CategoriaLog.Commands.UpCategoriaLog;
using WahooApplication.Features.CategoriaProducto.Commands.AddCategoriaProducto;
using WahooApplication.Features.CategoriaProducto.Commands.UpCategoriaProducto;
using WahooApplication.Features.Chat.Commands.AddChat;
using WahooApplication.Features.Chat.Commands.UpChat;
using WahooApplication.Features.Ciudad.Commands.AddCiudad;
using WahooApplication.Features.Ciudad.Commands.UpCiudad;
using WahooApplication.Features.CriterioEvaluacion.Commands.AddCriterioEvaluacion;
using WahooApplication.Features.CriterioEvaluacion.Commands.UpCriterioEvaluacion;
using WahooApplication.Features.Departamento.Commands.AddDepartamento;
using WahooApplication.Features.Departamento.Commands.UpDepartamento;
using WahooApplication.Features.Dia.Commands.AddDia;
using WahooApplication.Features.Dia.Commands.UpDia;
using WahooApplication.Features.Domicilio.Commands.AddDomicilio;
using WahooApplication.Features.Domicilio.Commands.UpDomicilio;
using WahooApplication.Features.Entidad.Commands.AddEntidad;
using WahooApplication.Features.Entidad.Commands.UpEntidad;
using WahooApplication.Features.Estado.Commands.AddEstado;
using WahooApplication.Features.Estado.Commands.UpEstado;
using WahooApplication.Features.FaseDomicilio.Commands.AddFaseDomicilio;
using WahooApplication.Features.FaseDomicilio.Commands.UpFaseDomicilio;
using WahooApplication.Features.Horario.Commands.AddHorario;
using WahooApplication.Features.Horario.Commands.UpHorario;
using WahooApplication.Features.Item.Commands.AddItem;
using WahooApplication.Features.Item.Commands.UpItem;
using WahooApplication.Features.Log.Commands.AddLog;
using WahooApplication.Features.Log.Commands.UpLog;
using WahooApplication.Features.MedioPago.Commands.AddMedioPago;
using WahooApplication.Features.MedioPago.Commands.UpMedioPago;
using WahooApplication.Features.Modulo.Commands.AddMdulo;
using WahooApplication.Features.Modulo.Commands.UpModulo;
using WahooApplication.Features.Notificacion.Commands.AddNotificacion;
using WahooApplication.Features.Notificacion.Commands.UpNotificacion;
using WahooApplication.Features.Pais.Commands.AddPais;
using WahooApplication.Features.Pais.Commands.UpPais;
using WahooApplication.Features.ParametroEvaluacion.Commands.AddParametroEvaluacion;
using WahooApplication.Features.ParametroEvaluacion.Commands.UpParametroEvaluacion;
using WahooApplication.Features.Permiso.Commands.AddPermiso;
using WahooApplication.Features.Permiso.Commands.UpPermiso;
using WahooApplication.Features.PQRS.Commands.AddPQRS;
using WahooApplication.Features.PQRS.Commands.UpPQRS;
using WahooApplication.Features.Producto.Commands.AddProducto;
using WahooApplication.Features.Producto.Commands.UpProducto;
using WahooApplication.Features.Promocion.Commands.AddPromocion;
using WahooApplication.Features.Promocion.Commands.UpPromocion;
using WahooApplication.Features.Rol.Commands.AddRol;
using WahooApplication.Features.Rol.Commands.UpRol;
using WahooApplication.Features.Saldo.Commands.AddSaldo;
using WahooApplication.Features.Saldo.Commands.UpSaldo;
using WahooApplication.Features.TiempoFase.Commands.AddTiempoFase;
using WahooApplication.Features.TiempoFase.Commands.UpTiempoFase;
using WahooApplication.Features.TipoEntidad.Commands.AddTipoEntidad;
using WahooApplication.Features.TipoEntidad.Commands.UpTipoEntidad;
using WahooApplication.Features.TipoIdentificacion.Commands.AddTipoIdentificacion;
using WahooApplication.Features.TipoIdentificacion.Commands.UpTipoIdentificacion;
using WahooApplication.Features.TipoPQRS.Commands.AddTipoPQRS;
using WahooApplication.Features.TipoPQRS.Commands.UpTipoPQRS;
using WahooApplication.Features.TipoPromocion.Commands.AddTipoPromocion;
using WahooApplication.Features.TipoPromocion.Commands.UpTipoPromocion;
using WahooApplication.Features.TipoTransacion.Commands.AddTipoTransaccion;
using WahooApplication.Features.TipoTransacion.Commands.UpTipoTransaccion;
using WahooApplication.Features.Transaccion.Commands.AddTransaccion;
using WahooApplication.Features.Transaccion.Commands.UpTransaccion;
using WahooApplication.Features.Usuario.Commands.AddUsuario;
using WahooApplication.Features.Usuario.Commands.UpUsuario;
using WahooApplication.Models;
using WahooDomain;

namespace WahooApplication.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCalificacionCommand, Calificacion>();
            CreateMap<UpdateCalificacionCommand, Calificacion>();
            CreateMap<Calificacion, CalificacionModel>();

            CreateMap<CreateCatalogoCommand, Catalogo>();
            CreateMap<UpdateCatalogoCommand, Catalogo>();
            CreateMap<Catalogo, CatalogoModel>();

            CreateMap<CreateCategoriaLogCommand, CategoriaLog>();
            CreateMap<UpdateCategoriaLogCommand, CategoriaLog>();
            CreateMap<CategoriaLog, CategoriaLogModel>();

            CreateMap<CreateCategoriaProductoCommand, CategoriaProducto>();
            CreateMap<UpdateCategoriaProductoCommand, CategoriaProducto>();
            CreateMap<CategoriaProducto, CategoriaProductoModel>();

            CreateMap<CreateChatCommand, Chat>();
            CreateMap<UpdateChatCommand, Chat>();
            CreateMap<Chat, ChatModel>();

            CreateMap<CreateCiudadCommand, Ciudad>();
            CreateMap<UpdateCiudadCommand, Ciudad>();
            CreateMap<Ciudad, CiudadModel>();

            CreateMap<CreateCriterioEvaluacionCommand, CriterioEvaluacion>();
            CreateMap<UpdateCriterioEvaluacionCommand, CriterioEvaluacion>();
            CreateMap<CriterioEvaluacion, CriterioEvaluacionModel>();

            CreateMap<CreateDepartamentoCommand, Departamento>();
            CreateMap<UpdateDepartamentoCommand, Departamento>();
            CreateMap<Departamento, DepartamentoModel>();

            CreateMap<CreateDiaCommand, Dia>();
            CreateMap<UpdateDiaCommand, Dia>();
            CreateMap<Dia, DiaModel>();

            CreateMap<CreateDomicilioCommand, Domicilio>();
            CreateMap<UpdateDomicilioCommand, Domicilio>();
            CreateMap<Domicilio, DomicilioModel>();

            CreateMap<CreateEntidadCommand, Entidad>();
            CreateMap<UpdateEntidadCommand, Entidad>();
            CreateMap<Entidad, EntidadModel>();

            CreateMap<CreateEstadoCommand, Estado>();
            CreateMap<UpdateEstadoCommand, Estado>();
            CreateMap<Estado, EstadoModel>();

            CreateMap<CreateFaseDomicilioCommand, FaseDomicilio>();
            CreateMap<UpdateFaseDomicilioCommand, FaseDomicilio>();
            CreateMap<FaseDomicilio, FaseDomicilioModel>();

            CreateMap<CreateHorarioCommand, Horario>();
            CreateMap<UpdateHorarioCommand, Horario>();
            CreateMap<Horario, HorarioModel>();

            CreateMap<CreateItemCommand, Item>();
            CreateMap<UpdateItemCommand, Item>();
            CreateMap<Item, ItemModel>();

            CreateMap<CreateLogCommand, Log>();
            CreateMap<UpdateLogCommand, Log>();
            CreateMap<Log, LogModel>();

            CreateMap<CreateMedioPagoCommand, MedioPago>();
            CreateMap<UpdateMedioPagoCommand, MedioPago>();
            CreateMap<MedioPago, MedioPagoModel>();

            CreateMap<CreateModuloCommand, Modulo>();
            CreateMap<UpdateModuloCommand, Modulo>();
            CreateMap<Modulo, ModuloModel>();

            CreateMap<CreateNotificacionCommand, Notificacion>();
            CreateMap<UpdateNotificacionCommand, Notificacion>();
            CreateMap<Notificacion, NotificacionModel>();

            CreateMap<CreatePaisCommand, Pais>();
            CreateMap<UpdatePaisCommand, Pais>();
            CreateMap<Pais, PaisModel>();

            CreateMap<CreateParametroEvaluacionCommand, ParametroEvaluacion>();
            CreateMap<UpdateParametroEvaluacionCommand, ParametroEvaluacion>();
            CreateMap<ParametroEvaluacion, ParametroEvaluacionModel>();

            CreateMap<CreateParametroEvaluacionCommand, ParametroEvaluacion>();
            CreateMap<UpdateParametroEvaluacionCommand, ParametroEvaluacion>();
            CreateMap<ParametroEvaluacion, ParametroEvaluacionModel>();

            CreateMap<CreatePermisoCommand, Permiso>();
            CreateMap<UpdatePermisoCommand, Permiso>();
            CreateMap<Permiso, PermisoModel>();

            CreateMap<CreatePQRSCommand, PQRS>();
            CreateMap<UpdatePQRSCommand, PQRS>();
            CreateMap<PQRS, PQRSModel>();

            CreateMap<CreateProductoCommand, Producto>();
            CreateMap<UpdateProductoCommand, Producto>();
            CreateMap<Producto, ProductoModel>();

            CreateMap<CreatePromocionCommand, Promocion>();
            CreateMap<UpdatePromocionCommand, Promocion>();
            CreateMap<Promocion, PromocionModel>();

            CreateMap<CreateRolCommand, Rol>();
            CreateMap<UpdateRolCommand, Rol>();
            CreateMap<Rol, RolModel>();

            CreateMap<CreateSaldoCommand, Saldo>();
            CreateMap<UpdateSaldoCommand, Saldo>();
            CreateMap<Saldo, SaldoModel>();

            CreateMap<CreateTiempoFaseCommand, TiempoFase>();
            CreateMap<UpdateTiempoFaseCommand, TiempoFase>();
            CreateMap<TiempoFase, TiempoFaseModel>();

            CreateMap<CreateTipoEntidadCommand, TipoEntidad>();
            CreateMap<UpdateTipoEntidadCommand, TipoEntidad>();
            CreateMap<TipoEntidad, TipoEntidadModel>();

            CreateMap<CreateTipoIdentificacionCommand, TipoIdentificacion>();
            CreateMap<UpdateTipoIdentificacionCommand, TipoIdentificacion>();
            CreateMap<TipoIdentificacion, TipoIdentificacionModel>();

            CreateMap<CreateTipoPQRSCommand, TipoPQRS>();
            CreateMap<UpdateTipoPQRSCommand, TipoPQRS>();
            CreateMap<TipoPQRS, TipoPQRSModel>();

            CreateMap<CreateTipoPromocionCommand, TipoPromocion>();
            CreateMap<UpdateTipoPromocionCommand, TipoPromocion>();
            CreateMap<TipoPromocion, TipoPromocionModel>();

            CreateMap<CreateTipoTransaccionCommand, TipoTransaccion>();
            CreateMap<UpdateTipoTransaccionCommand, TipoTransaccion>();
            CreateMap<TipoTransaccion, TipoTransaccionModel>();

            CreateMap<CreateTransaccionCommand, Transaccion>();
            CreateMap<UpdateTransaccionCommand, Transaccion>();
            CreateMap<Transaccion, TransaccionModel>();

            CreateMap<CreateUsuarioCommand, Usuario>();
            CreateMap<UpdateUsuarioCommand, Usuario>();
            CreateMap<Usuario, UsuarioModel>();
        }
    }
}
