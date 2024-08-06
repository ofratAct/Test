using App.DataAccess.Entities;
using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BusinessLogic.Interfaces
{
    public interface IUsersService
    {
        public List<UserDTO> GetUsers();
        public Guid CreateUser(UserDTO user);
    }
}
