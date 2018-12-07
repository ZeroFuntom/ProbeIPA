using System.Collections.Generic;
using System.Linq;
using Secondhand.Domain.Model;
using Secondhand.Domain.Services;

namespace Secondhand.BusinessLogic.Items
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public IEnumerable<Item> GetItems()
        {
            return _itemRepository.GetAll().OrderBy(item => item.ItemName);
        }

        public void AddItem(Item item, ICollection<int> ItemId)
        {
            throw new System.NotImplementedException();
        }
    }
}
