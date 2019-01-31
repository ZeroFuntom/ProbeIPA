using Secondhand.Domain.Model;
using System.Collections.Generic;

namespace Secondhand.BusinessLogic.Items
{
    public interface IItemService
    {
        IEnumerable<Item> GetItems(int buyerId);
        IEnumerable<Item> GetPurchasedItems(int buyerId);
        Item GetItem(int id);
        void BuyItem(int id, int buyerId);
    }
}
