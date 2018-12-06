using Secondhand.Domain.Model;
using System.Collections.Generic;

namespace Secondhand.BusinessLogic.Items
{
    class IItemService
    {
        IEnumerable<Item> GetItems();
    }
}
