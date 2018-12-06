using System.Web.Mvc;
using Secondhand.BusinessLogic.Items;

namespace SecondhandTrade.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_itemService.GetItems());
        }

        public ActionResult Detail()
        {
            return View();
        }
    }
}