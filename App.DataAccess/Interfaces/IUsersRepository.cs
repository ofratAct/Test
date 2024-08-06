using App.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Interfaces
{
    public interface IUsersRepository
    {
        public List<User> GetUsers();
        public Guid CreateUser(User user);
    }
}
