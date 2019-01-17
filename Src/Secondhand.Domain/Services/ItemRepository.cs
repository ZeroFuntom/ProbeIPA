using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secondhand.Domain.Model;

namespace Secondhand.Domain.Services
{
    public class ItemRepository : IItemRepository
    {
        private readonly ISecondhandContext _secondhandContext;

        public ItemRepository(ISecondhandContext secondhandContext)
        {
            _secondhandContext = secondhandContext;
        }

        public IQueryable<Item> GetAll()
        {
            return _secondhandContext.Items;
        }

        //public void BuyItem(Item item)
        //{
        //    Item buy = _secondhandContext.Items.FirstOrDefault(b => b.BuyerUserId == item.BuyerUserId);
        //    if (buy == null)
        //    {
        //        buy = new Item
        //        {
        //            BuyerUserId = item.BuyerUserId
        //        };
        //        _secondhandContext.Items.Add(buy);
        //    }
        //    buy.BuyerUserId = item.BuyerUserId;
        //    _secondhandContext.SaveChanges();
        //}
    }
}
