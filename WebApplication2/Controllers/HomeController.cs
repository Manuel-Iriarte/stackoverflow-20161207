using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Call()
        {
            return PartialView("_PartialFooter");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Call(CallMe callMe)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                callMe.CallMeMessage = callMe.CallMeMessage + " i was on the server";
            }
            return PartialView("_PartialFooter", callMe);
        }
    }
}