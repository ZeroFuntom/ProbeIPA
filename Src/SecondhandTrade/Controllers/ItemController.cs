using System.Web.Helpers;
using System.Web.Mvc;
using Secondhand.BusinessLogic.Items;
using Secondhand.BusinessLogic.Users;
using Secondhand.Domain.Model;
using SecondhandTrade.Models;

namespace SecondhandTrade.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        private readonly IUserService _userService;

        public ItemController(IItemService itemService, IUserService userService)
        {
            _itemService = itemService;
            _userService = userService;
        }

        //INDEX
        [HttpGet]
        public ActionResult Index()
        {
            string buyerName = System.Web.HttpContext.Current.User.Identity.Name;
            int buyerId = _userService.GetUserByUserName(buyerName).Id;
            var items = _itemService.GetItems(buyerId);
            return View(items);
        }

        private byte[] resizeImage(byte[] image)
        {
            var webImage = new WebImage(image);
            return webImage.Resize(100, 100, true).GetBytes();
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
                    SellerUserId = item.SellerUserId,
                    BuyerUserId = item.BuyerUserId
                },
                item.Id);
            return RedirectToAction("Index");
        }

        // DETAIL
        [HttpGet]
        public ActionResult Detail(int id)
        {
            return View(_itemService.GetItem(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Buy(int id)
        {
            // Get UserName
            string buyerName = System.Web.HttpContext.Current.User.Identity.Name;
            // Get ID from UserName
            int buyerId = _userService.GetUserByUserName(buyerName).Id;
            // Save ID in Database
            _itemService.BuyItem(id, buyerId);
            // Go Back to product list
            return RedirectToAction("Index");
        }
    }
}