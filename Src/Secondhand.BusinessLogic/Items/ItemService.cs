using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using Secondhand.Domain.Model;
using Secondhand.Domain.Services;

namespace Secondhand.BusinessLogic.Items
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IUserRepository _userRepository;

        public ItemService(IItemRepository itemRepository, IUserRepository userRepository)
        {
            _itemRepository = itemRepository;
            _userRepository = userRepository;
        }

        public IEnumerable<Item> GetItems()
        {
            return _itemRepository.GetAll().OrderBy(item => item.ItemName);
        }

        public void AddItem(Item item, ICollection<int> ItemId)
        {
            throw new System.NotImplementedException();
        }

        public Item GetItem(int id)
        {
            return
            _itemRepository.GetAll().FirstOrDefault(item => item.Id == id);
        }

        public void BuyItem(Item item)
        {
            _itemRepository.BuyItem(item);
        }
    }
}
