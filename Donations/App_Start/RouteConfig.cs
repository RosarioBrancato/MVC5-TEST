using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Donations {
    public class RouteConfig {
		public static void RegisterRoutes(RouteCollection routes) {
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapMvcAttributeRoutes();

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}"
			);

			routes.MapRoute(
				name: "Donation_Index_Id",
				url: "{controller}/{action}/{id}"
				//defaults: new { controller = "Movies", action = "Detail", id = UrlParameter.Optional }
			);

			//routes.MapRoute(
			//	name: "SingleName",
			//	url: "{controller}/{action}/{name}",
			//	defaults: new { controller = "Donation", action = "Welcome" }
			//);

			//routes.MapRoute(
			//	name: "Welcomeeee",
			//	url: "{controller}/{action}/{name}/{numTimes}",
			//	defaults: new { controller = "Donation", action = "Welcome" }
			//);
		}
    }
}
