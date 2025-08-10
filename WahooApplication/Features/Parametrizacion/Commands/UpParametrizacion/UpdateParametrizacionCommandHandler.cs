using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Pais.Commands.UpPais;

namespace WahooApplication.Features.Parametrizacion.Commands.UpParametrizacion
{
    public class UpdateParametrizacionCommandHandler : IRequestHandler<UpdateParametrizacionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateParametrizacionCommandHandler> _logger;
        public UpdateParametrizacionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateParametrizacionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<bool> Handle(UpdateParametrizacionCommand request, CancellationToken cancellationToken)
        {
            var VerifiData = await _unitOfWork.Repository<WahooDomain.Parametrizacion>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            bool resp = false;
            if (VerifiData != null)
            {
                VerifiData.NombreApp = request.NombreApp;
                VerifiData.Estado = request.Estado;
                VerifiData.Footer = request.Footer;
                VerifiData.TipoLetra = request.TipoLetra;
                VerifiData.Logo = request.Logo;
                VerifiData.BackgroundImagen = request.BackgroundImagen;
                VerifiData.ColorPrimario = request.ColorPrimario;
                VerifiData.ColorSecundario = request.ColorSecundario;
                VerifiData.ColorTerciario = request.ColorTerciario;
                VerifiData.ColorBotonCrear = request.ColorBotonCrear;
                VerifiData.ColorBotonActualizar = request.ColorBotonActualizar;
                VerifiData.ColorBotonEliminar = request.ColorBotonEliminar;
                VerifiData.ColorTexto = request.ColorTexto;
                VerifiData.TipoLetra = request.TipoLetra;
                VerifiData.TextoPrimario = request.TextoPrimario;
                VerifiData.TextoSecundario = request.TextoSecundario;
                VerifiData.TextoTerciario = request.TextoTerciario;
                VerifiData.TextoCuaternario = request.TextoTerciario;
                VerifiData.Estado = request.Estado;
                VerifiData.FechaUp = VerifiData.FechaUp;
                VerifiData.UsuarioUp = request.UsuarioUp;
                VerifiData.FechaUp = request.FechaUp;

                var EntityGetResponse = await _unitOfWork.Repository<WahooDomain.Parametrizacion>().UpdateAsync(VerifiData);

                _logger.LogInformation($"La parametrizacion fue actualizada");


                return resp = true;

            }
            else
            {
                _logger.LogInformation($"La parametrizacion no fue actualizada");

                return resp = false;
            }
        }
    }
}
