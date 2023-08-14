using Application.Dtos;
using Application.Interfaces;
using Application.Specifications;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Clientes.Queries.GetAllClientes
{
    public class GetAllClientesQuery : IRequest<PagedResponse<List<ClienteDto>>>
    {
        public int PageNumber{ get; set; }
        public int PageSize { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public class GetAllClientesQueryHandler : IRequestHandler<GetAllClientesQuery, PagedResponse<List<ClienteDto>>>
        {
            private readonly IRepositoryAsync<Cliente> _respositoryAsync;
            private readonly IMapper _mapper;
            public GetAllClientesQueryHandler(IRepositoryAsync<Cliente> respositoryAsync, IMapper mapper)
            {
                _respositoryAsync = respositoryAsync;
                _mapper = mapper;
            }

            public async Task<PagedResponse<List<ClienteDto>>> Handle(GetAllClientesQuery request, CancellationToken cancellationToken)
            {
                var clientes = await _respositoryAsync.ListAsync(new PagedClienstesSpecification(request.PageSize, request.PageNumber, request.Nombre, request.Apellido));
                var clientesDto = _mapper.Map<List<ClienteDto>>(clientes);
                return new PagedResponse<List<ClienteDto>>(clientesDto, request.PageNumber, request.PageSize);
            }
        }
    }
}
