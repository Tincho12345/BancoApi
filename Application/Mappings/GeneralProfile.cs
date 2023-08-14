using Application.Dtos;
using Application.Features.Clientes.Commands.CreateClienteCommand;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region Dtos
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            #endregion
            #region Commands
            CreateMap<CreateClienteCommand, Cliente>().ReverseMap();
            #endregion
        }
    }
}
