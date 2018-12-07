using System.Web.Mvc;
using Secondhand.BusinessLogic.Items;
using Secondhand.Domain.Model;
using SecondhandTrade.Models;

namespace SecondhandTrade.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        //INDEX
        [HttpGet]
        public ActionResult Index()
        {
            return View(_itemService.GetItems());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(AddItemVm item)
        {
            _itemService.AddItem(new Item
            {
                ItemName = item.ItemName,
                Description = item.Description,
                Image = item.Image,
                Year = item.Year,
                Price = item.Price,
                UserId = item.UserId
            },
            item.Id);
            return RedirectToAction("Index");
        }

        // DETAIL
        [HttpGet]
        public ActionResult Detail()
        {
            return View();
        }
    }
}