using System.Linq;
using AutoMapper;
using Hawk.API.Dtos;
using Hawk.Domain;
using Hawk.Domain.Identity;

namespace Hawk.API.Helpers
{
    public class AutoMapperProfile : Profile 
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
        }
      
    }
}