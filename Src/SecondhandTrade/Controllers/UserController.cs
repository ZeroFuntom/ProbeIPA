using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
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
        public ActionResult Index(int id)
        {
            var userName = HttpContext.User.Identity.Name;
            return View(_userService.GetUserByUserName(userName));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(User user)
        {
            user.UserName = HttpContext.User.Identity.Name;
            _userService.SaveUser(user);
            return RedirectToAction("Index");
        }
    }
}