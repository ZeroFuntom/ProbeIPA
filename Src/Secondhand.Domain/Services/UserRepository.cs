using System.Linq;
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

        public void UpdateUser(User user)
        {
            User update = _secondhandContext.Users.FirstOrDefault(u => u.UserName == user.UserName);
            if (update == null)
            {
                update = new User
                {
                    UserName = user.UserName
                };
                _secondhandContext.Users.Add(update);
            }
            update.FirstName = user.FirstName;
            update.LastName = user.LastName;
            update.Street = user.Street;
            update.City = user.City;
            update.Zip = user.Zip;
            update.Country = user.Country;
            update.Password = user.Password;

            _secondhandContext.SaveChanges();
        }
    }
}
