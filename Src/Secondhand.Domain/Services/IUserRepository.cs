using System.Linq;
using Secondhand.Domain.Model;

namespace Secondhand.Domain.Services
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
        void UpdateUser(User user);
    }
}
