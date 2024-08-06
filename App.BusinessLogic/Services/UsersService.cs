using App.BusinessLogic.Interfaces;
using App.BusinessLogic.Mappers;
using App.DataAccess.Entities;
using App.DataAccess.Interfaces;
using App.DTO.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BusinessLogic.Services
{
    public class UsersService : IUsersService
    {
        private IUsersRepository _usersRepository;
        private IMapper _mapper;

        public UsersService(IUsersRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }

        public List<UserDTO> GetUsers() 
        { 
           List<User> result = _usersRepository.GetUsers();
            List<UserDTO> users =  result.Select(u => UsersMapper.Map(u)).ToList();
            // return _mapper.Map<List<UserDTO>>(result);
        }

        public Guid CreateUser(UserDTO user)
        {
            user.UserId = Guid.NewGuid();  
            return _usersRepository.CreateUser(UsersMapper.Map(user));
            //  return _usersRepository.CreateUser(_mapper.Map<User>(user));
        }
    }
}
