using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.MedioPago.Commands.UpMedioPago;

namespace WahooApplication.Features.Usuario.Commands.UpUsuario
{
    public class UpdateUsuarioCommandHandler : IRequestHandler<UpdateUsuarioCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateUsuarioCommandHandler> _logger;
        public UpdateUsuarioCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateUsuarioCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateUsuarioCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Usuario>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.NombreUsuario = request.NombreUsuario;
                VerifiData.ApellidoUsuario = request.ApellidoUsuario;
                VerifiData.TelefonoUsuario = request.TelefonoUsuario;
                VerifiData.ExpedicionCedula = request.ExpedicionCedula;
                VerifiData.DireccionUsuario = request.DireccionUsuario;
                VerifiData.PlacaMoto = request.PlacaMoto;
                VerifiData.LicenciaConduccion = request.LicenciaConduccion;
                VerifiData.HorarioUsuario = request.HorarioUsuario;
                VerifiData.FormaPago = request.FormaPago;
                VerifiData.Login = request.Login;
                VerifiData.Password = request.Password;
                VerifiData.Correo = request.Correo;
                VerifiData.Circulacion = request.Circulacion;
                VerifiData.CausacionPagos = request.CausacionPagos;
                VerifiData.RolId = request.RolId;
                VerifiData.TipoIdentificacionId = request.TipoIdentificacionId;
                VerifiData.Estado = request.Estado;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Usuario>().UpdateAsync(VerifiData);

                _logger.LogInformation($"El usuario fue actualizado");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"El usuario no fue actualizado");

                return resp = false;
            }
        }
    }
}
