using System.Collections.Generic;
using System.Linq;
using Secondhand.Domain.Model;
using Secondhand.Domain.Services;

namespace Secondhand.BusinessLogic.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetAll().OrderBy(user => user.UserName);
        }
    }
}
