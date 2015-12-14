using AutoMapper;
using MVC5Bootstrap.Domain;
using MVC5Bootstrap.Web.Models;

namespace MVC5Bootstrap.Web
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<CustomerViewModel, Customer>()
                .ForMember(dest => dest.Surname,
                           opts => opts.MapFrom(src => src.LastName))
                .ForMember(dest => dest.EmailAddress,
                           opts => opts.MapFrom(src => src.Email));            
        }
    }
}