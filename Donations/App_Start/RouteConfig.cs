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

			//routes.MapMvcAttributeRoutes();

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}",
				defaults: new { controller = "Donation", action = "Index" }
			);

			routes.MapRoute(
				name: "Donnation_Welcome_Name_NumTimes",
				url: "{controller}/{action}/{name}/{numTimes}",
				defaults: new { action = "Welcome", name = UrlParameter.Optional, numTimes = UrlParameter.Optional },
				constraints: new { controller = "Donation" }
			);

			routes.MapRoute(
				name: "Movies_Action_Id",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Movies", action = "Detail", id = UrlParameter.Optional }
			);

			routes.MapRoute(
				name: "Last_Chance",
				url: "{controller}/{action}",
				defaults: new { },
				constraints: new { controller = "Donation", action = "Index" }
			);
		}
    }
}
