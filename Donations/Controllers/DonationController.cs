using System.Web.Mvc;

namespace Donations.Controllers {
	public class DonationController : Controller {

        // GET: Donation
        public ActionResult Index() {
            return View();
        }

        public ActionResult Welcome(string name = "Guest", int numTimes = 1) {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
            //return HttpUtility.HtmlEncode("Welcome to the donation center, " + name + "! ID: " + ID);
        }
    }
}