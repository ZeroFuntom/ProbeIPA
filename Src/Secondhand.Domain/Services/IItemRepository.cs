using System.Collections.Generic;
using System.Linq;
using Secondhand.Domain.Model;

namespace Secondhand.Domain.Services
{
    public interface IItemRepository
    {
        IQueryable<Item> GetAll();
    }
}
