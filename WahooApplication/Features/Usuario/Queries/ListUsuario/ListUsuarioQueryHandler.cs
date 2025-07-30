using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Log.Queries.ListLog;
using WahooApplication.Models;

namespace WahooApplication.Features.Usuario.Queries.ListUsuario
{
    public class ListUsuarioQueryHandler : IRequestHandler<ListUsuarioQuery, List<UsuarioModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListUsuarioQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListUsuarioQueryHandler(IUnitOfWork unitOfWork, ILogger<ListUsuarioQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<UsuarioModel>> Handle(ListUsuarioQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Usuario>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<UsuarioModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Usuario>().GetAllAsync();
                var entityVm = _mapper.Map<List<UsuarioModel>>(entity);

                return entityVm;

            }
        }
    }
}
