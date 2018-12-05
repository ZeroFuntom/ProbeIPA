using System.Web.Mvc;
using SecondhandTrade.Models;

namespace SecondhandTrade.Controllers
{
    public class ItemController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Add(AddItemVm item)
        //{
        //    // Implementieren
        //}
    }
}