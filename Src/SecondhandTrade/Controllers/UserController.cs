using System.Web.Mvc;
using Secondhand.BusinessLogic.Users;

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
    }
}