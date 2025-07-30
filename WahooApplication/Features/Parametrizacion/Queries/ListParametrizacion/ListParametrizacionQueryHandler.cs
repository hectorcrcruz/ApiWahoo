using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WahooApplication.Contracts.Persistence;
using WahooApplication.Features.Pais.Queries.ListPais;
using WahooApplication.Models;

namespace WahooApplication.Features.Parametrizacion.Queries.ListParametrizacion
{
    public class ListParametrizacionQueryHandler : IRequestHandler<ListParametrizacionQuery, List<ParametrizacionModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListParametrizacionQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListParametrizacionQueryHandler(IUnitOfWork unitOfWork, ILogger<ListParametrizacionQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<List<ParametrizacionModel>> Handle(ListParametrizacionQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Parametrizacion>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<ParametrizacionModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Parametrizacion>().GetAllAsync();
                var entityVm = _mapper.Map<List<ParametrizacionModel>>(entity);

                return entityVm;

            }
        }
    }
}
