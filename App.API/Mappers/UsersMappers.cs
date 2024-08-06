using App.API.Models;
using App.DataAccess.Entities;
using App.DTO.Models;

namespace App.API.Mappers
{
    internal static class UsersMappers
    {
        //internal static User Map(UserRequest userRequest)
        //{
        //    return new User()
        //    {
        //        UserId =Guid.NewGuid(),
        //        Name = userRequest.Name,
        //        LastName = userRequest.LastName
        //    };
        //}

        internal static UserDTO Map(UserRequest userRequest)
        {
            return new UserDTO()
            {
                UserId = Guid.NewGuid(),
                Name = userRequest.Name,
                LastName = userRequest.LastName
            };
        }
    }
}
