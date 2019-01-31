using System.Collections.Generic;
using System.Linq;
using Secondhand.Domain.Model;
using Secondhand.Domain.Services;

namespace Secondhand.BusinessLogic.Items
{
    public class ItemService : IItemService
    {
        private readonly ISecondhandContext _secondhandContext;
        private readonly IItemRepository _itemRepository;
        private readonly IUserRepository _userRepository;

        public ItemService(
            ISecondhandContext secondhandContext,
            IItemRepository itemRepository,
            IUserRepository userRepository)
        {
            _secondhandContext = secondhandContext;
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
            throw new System.NotImplementedException();
        }

        public IEnumerable<Item> GetItems(int buyerId)
        {
            return GetItems().Where(i => i.BuyerUserId == null);
        }

        public IEnumerable<Item> GetPurchasedItems(int buyerId)
        {
            return GetItems().Where(i => i.BuyerUserId == buyerId);
        }

        public void BuyItem(int id, int buyerId)
        {
            Item item = _itemRepository.GetAll().FirstOrDefault(i => i.Id == id);
            item.BuyerUserId = buyerId;
            _secondhandContext.SaveChanges();
        }
    }
}
