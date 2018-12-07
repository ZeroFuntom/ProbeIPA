using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
    }
}
