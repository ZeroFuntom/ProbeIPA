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
            return View(_userService.GetUsers());
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Save(User user)
        //{
        //    user.UserName = HttpContext.User.Identity.Name;
        //    user.UserName(user);
        //    return RedirectToAction("Index");
        //}
    }
}