using AngularWpiCore.Model;
using AngularWpiCore.ModelDTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWpiCore.Halper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<User, UserDto>();

            CreateMap<UserDto, User>();
        }
    }
}
