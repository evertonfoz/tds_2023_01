using AutoMapper;
using TDS_CA_MS.Application.DTOs;
using TDS_CA_MS.Application.Products.Commands;

namespace TDS_CA_MS.Application.Mappings
{
    public  class DTOToCommandMapingProfile : Profile
    {
        public DTOToCommandMapingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>();
            CreateMap<ProductDTO, ProductUpdateCommand>();
        }
    }
}
