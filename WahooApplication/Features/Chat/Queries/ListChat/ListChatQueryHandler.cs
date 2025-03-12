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

namespace WahooApplication.Features.Chat.Queries.ListChat
{
    public class ListChatQueryHandler : IRequestHandler<ListChatQuery,List<ChatModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListChatQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListChatQueryHandler(IUnitOfWork unitOfWork, ILogger<ListChatQueryHandler> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<List<ChatModel>> Handle(ListChatQuery request, CancellationToken cancellationToken)
        {
            if (request.Id != null)
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Chat>().GetAsync(x => x.Id == request.Id);
                var entityVm = _mapper.Map<List<ChatModel>>(entity);

                return entityVm;

            }
            else
            {
                var entity = await _unitOfWork.Repository<WahooDomain.Chat>().GetAllAsync();
                var entityVm = _mapper.Map<List<ChatModel>>(entity);

                return entityVm;

            }
        }
    }
}
