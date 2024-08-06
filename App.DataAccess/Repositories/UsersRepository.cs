using App.DataAccess.DataContext;
using App.DataAccess.Entities;
using App.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private ShopDbContext db;

        public UsersRepository(ShopDbContext dbContext)
        {
            db = dbContext;
        }

        public List<User> GetUsers()
        {
           return  db.Users.ToList();
        }

        public Guid CreateUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user.UserId;
        }
    }
}
