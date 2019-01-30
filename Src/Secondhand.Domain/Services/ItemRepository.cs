using System.Linq;
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
    }
}
