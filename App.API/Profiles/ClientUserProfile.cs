using App.API.Models;
using App.DTO.Models;
using AutoMapper;

namespace App.API.Profiles
{
    public class ClientUserProfile : Profile
    {
        public ClientUserProfile()
        {
            CreateMap<UserRequest, UserDTO>();
        }
    }
}
