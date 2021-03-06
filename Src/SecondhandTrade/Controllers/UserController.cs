﻿using System.Web.Mvc;
using Secondhand.BusinessLogic.Users;
using Secondhand.Domain.Model;

namespace SecondhandTrade.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var userName = HttpContext.User.Identity.Name;
            return View(_userService.GetUserByUserName(userName));
        }

        [HttpGet]
        public ActionResult Welcome()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(User user)
        {
            user.UserName = HttpContext.User.Identity.Name;
            _userService.UpdateUser(user);
            return RedirectToAction("Index");
        }
    }
}