using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Web.Helpers;
using System.Web.Mvc;
using Secondhand.BusinessLogic.Items;
using Secondhand.BusinessLogic.Users;
using Secondhand.Domain.Model;
using SecondhandTrade.Models;
using Microsoft.AspNet.Identity;
using Secondhand.Domain.Model;

namespace SecondhandTrade.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        //private readonly IUserService _userService;

        public ItemController(IItemService itemService, IUserService userService)
        {
            _itemService = itemService;
            //_userService = userService;
        }

        //INDEX
        [HttpGet]
        public ActionResult Index()
        {
            var items = _itemService.GetItems();
            foreach (Item item in items)
            {
                item.Image = resizeImage(item.Image);
            }
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
        public void Buy(Item item)
        {
            string buyerName = System.Web.HttpContext.Current.User.Identity.Name;
            int buyerId = User.Identity.GetUserId<int>();
        }
    }
}