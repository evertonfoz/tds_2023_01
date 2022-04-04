using AutoMapper;
using TDS_CA_MS.Application.DTOs;
using TDS_CA_MS.Domain.Entities;

namespace TDS_CA_MS.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
