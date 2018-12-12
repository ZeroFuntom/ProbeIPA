﻿using System.Collections.Generic;
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

        public User GetUserByUserName(string userName)
        {
            return _userRepository.GetAll().FirstOrDefault(user => user.UserName == userName) ?? new User()
            {
                UserName = userName
            };
        }

        public void SaveUser(User user)
        {
            _userRepository.SaveUser(user);
        }
    }
}
