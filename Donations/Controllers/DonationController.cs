using System.Web.Mvc;

namespace Donations.Controllers {

	[RoutePrefix("Donation")]
	public class DonationController : Controller {

        [Route("Index")]
        public ActionResult Index() {
            return View();
        }

		[Route("Welcome/{name?}/{numTimes?}")]
		public ActionResult Welcome(string name = "Guest", int? numTimes = 1) {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
            //return HttpUtility.HtmlEncode("Welcome to the donation center, " + name + "! ID: " + ID);
        }
    }
}