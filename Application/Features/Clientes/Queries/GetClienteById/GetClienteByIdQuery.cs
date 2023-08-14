using Application.Dtos;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Clientes.Queries.GetClienteById
{
    public class GetClienteByIdQuery : IRequest<Response<ClienteDto>>
    {
        public int Id { get; set; }
        public class GetClienteByIdQueryHandler : IRequestHandler<GetClienteByIdQuery, Response<ClienteDto>>
        {
            private readonly IRepositoryAsync<Cliente> _respositoryAsync;
            private readonly IMapper _mapper;

            public GetClienteByIdQueryHandler(IRepositoryAsync<Cliente> respositoryAsync, IMapper mapper)
            {
                _respositoryAsync = respositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<ClienteDto>> Handle(GetClienteByIdQuery request, CancellationToken cancellationToken)
            {
                var cliente = await _respositoryAsync.GetByIdAsync(request.Id);
                if (cliente == null)
                {
                    throw new KeyNotFoundException($"Cliente No encontrado con Id {request.Id}");
                }
                var dto = _mapper.Map<ClienteDto>(cliente);
                return new Response<ClienteDto>(dto);
            }
        }
    }
}
