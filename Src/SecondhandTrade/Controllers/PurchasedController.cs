using System.Linq;
using System.Web.Mvc;
using Secondhand.BusinessLogic.Items;
using Secondhand.BusinessLogic.Users;
using Secondhand.Domain.Model;
using SecondhandTrade.Models;

namespace SecondhandTrade.Controllers
{
    public class PurchasedController : Controller
    {
        private readonly IItemService _itemService;
        private readonly IUserService _userService;

        public PurchasedController(IItemService itemService, IUserService userService)
        {
            _itemService = itemService;
            _userService = userService;
        }

        public ActionResult Index()
        {
            string buyerName = System.Web.HttpContext.Current.User.Identity.Name;
            int buyerId = _userService.GetUserByUserName(buyerName).Id;
            var items = _itemService.GetPurchasedItems(buyerId);
            return View(items);
        }
    }
}