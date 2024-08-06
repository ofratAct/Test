using App.API.Mappers;
using App.API.Models;
using App.BusinessLogic.Interfaces;
using App.DataAccess.Entities;
using App.DTO.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUsersService _usersService;
        private IMapper _mapper;
        public UsersController(IUsersService usersService, IMapper mapper)
        {
            _usersService  = usersService;
            _mapper = mapper;
        }


        [HttpGet]
        public List<UserDTO> GetUsers()
        {
           return  _usersService.GetUsers();
        }

        [HttpPost]
        public Guid CreateUser([FromBody] UserRequest user)
        {
            //return _usersService.CreateUser(UsersMappers.Map(user));
            return _usersService.CreateUser(_mapper.Map<UserDTO>(user));
        }
    }
}
