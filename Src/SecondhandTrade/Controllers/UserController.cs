using System.Web.Mvc;
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
            return View(new User());
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