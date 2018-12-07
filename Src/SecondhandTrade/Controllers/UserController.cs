using System.Data.Entity;
using System.Web.Mvc;
using Secondhand.BusinessLogic.Users;
using Secondhand.Domain.Model;
using Secondhand.Domain.Services;

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

        //[HttpPut]
        //Implement this

    }
}