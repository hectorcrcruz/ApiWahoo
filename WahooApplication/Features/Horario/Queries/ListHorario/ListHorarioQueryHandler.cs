using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.CategoriaProducto.Queries.ListCategoria;
using WahooApplication.Models;

namespace WahooApplication.Features.Horario.Queries.ListHorario
{
    public class ListHorarioQueryHandler : IRequestHandler<ListHorarioQuery, List<HorarioModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListHorarioQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListHorarioQueryHandler(IUnitOfWork unitOfWork, ILogger<ListHorarioQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<HorarioModel>> Handle(ListHorarioQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Horario>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<HorarioModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Horario>().GetAllAsync();
                var entityVm = _mapper.Map<List<HorarioModel>>(entity);

                return entityVm;

            }
        }
    }
}
