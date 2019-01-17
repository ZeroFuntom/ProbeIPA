using Secondhand.Domain.Model;
using System.Collections.Generic;

namespace Secondhand.BusinessLogic.Items
{
    interface IItemService
    {
        IEnumerable<Item> GetItems();
    }
}
