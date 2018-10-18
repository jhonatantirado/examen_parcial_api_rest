using AutoMapper;
using EnterprisePatterns.Api.Customers.Application.Dto;

namespace EnterprisePatterns.Api.Customers.Application.Assembler
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(
                    dest => dest.OrganizationName,
                    x => x.MapFrom(src => src.OrganizationName)
                );
            CreateMap<SignUpDto, Customer>()
                .ForMember(
                    dest => dest.OrganizationName,
                    x => x.MapFrom(src => src.OrganizationName)
                );
        }
    }
}
