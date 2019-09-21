using System.Linq;
using AutoMapper;
using Hawk.API.Dtos;
using Hawk.Domain;
using Hawk.Domain.Entities;

namespace Hawk.API.Helpers
{
    public class AutoMapperProfile : Profile 
    {
        public AutoMapperProfile()
        {
            CreateMap<Usuario, UserDto>().ReverseMap();
            CreateMap<Usuario, UserLoginDto>().ReverseMap();
        }
      
    }
}