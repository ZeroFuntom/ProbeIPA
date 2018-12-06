using Secondhand.Domain.Model;
using System.Collections.Generic;

namespace Secondhand.BusinessLogic.Items
{
    public interface IItemService
    {
        IEnumerable<Item> GetItems();
    }
}
