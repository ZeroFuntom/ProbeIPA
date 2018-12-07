using System.Collections.Generic;
using Secondhand.Domain.Model;

namespace Secondhand.BusinessLogic.Users
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        void SaveUser(User user);
    }
}
