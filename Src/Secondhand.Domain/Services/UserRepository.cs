using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secondhand.Domain.Model;

namespace Secondhand.Domain.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly ISecondhandContext _secondhandContext;

        public UserRepository(ISecondhandContext secondhandContext)
        {
            _secondhandContext = secondhandContext;
        }
        public IQueryable<User> GetAll()
        {
            return _secondhandContext.Users;
        }

        public void SaveUser(User user)
        {
            User save = _secondhandContext.Users.FirstOrDefault(u => u.UserName == user.UserName);
            if (save == null)
            {
                save = new User
                {
                    UserName = user.UserName
                };
                _secondhandContext.Users.Add(save);
            }
            save.UserName = user.UserName;
            save.FirstName = user.FirstName;
            save.LastName = user.LastName;
            save.Street = user.Street;
            save.City = user.City;
            save.Zip = user.Zip;
            save.Country = user.Country;
            save.Password = user.Password;

            _secondhandContext.SaveChanges();
        }
    }
}
