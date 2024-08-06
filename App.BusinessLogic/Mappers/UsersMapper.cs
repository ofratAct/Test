using App.DataAccess.Entities;
using App.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BusinessLogic.Mappers
{
    internal static class UsersMapper
    {
        internal static User Map(UserDTO user)
        {
            return new User
            {
                UserId = user.UserId,
                Name = user.Name,
                LastName = user.LastName
            };
        }

        internal static UserDTO Map(User user)
        {
            return new UserDTO
            {
                UserId = user.UserId,
                Name = user.Name,
                LastName = user.LastName
            };
        }
    }
}
