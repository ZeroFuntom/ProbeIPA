using Secondhand.Domain.Model;
using System.Collections.Generic;

namespace Secondhand.BusinessLogic.Items
{
    public interface IItemService
    {
        IEnumerable<Item> GetItems();
        void AddItem(Item item, ICollection<int> ItemId);
        Item GetItem(int id);
        void BuyItem(int id, int buyerId);
    }
}
