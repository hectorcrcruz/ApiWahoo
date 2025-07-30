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

namespace WahooApplication.Features.Item.Queries.ListItem
{
    public class ListItemQueryHandler : IRequestHandler<ListItemQuery, List<ItemModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListItemQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListItemQueryHandler(IUnitOfWork unitOfWork, ILogger<ListItemQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<ItemModel>> Handle(ListItemQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Item>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<ItemModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Item>().GetAllAsync();
                var entityVm = _mapper.Map<List<ItemModel>>(entity);

                return entityVm;

            }
        }
    }
}
