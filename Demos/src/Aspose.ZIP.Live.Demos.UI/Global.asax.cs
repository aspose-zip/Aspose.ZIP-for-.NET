using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Aspose.ZIP.Live.Demos.UI.Config;


namespace Aspose.ZIP.Live.Demos.UI
{
	public class Global : HttpApplication
	{
		
		protected void Application_Error(object sender, EventArgs e)
		{			
			
		}

		void Application_Start(object sender, EventArgs e)
		{

			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);			
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			RegisterCustomRoutes(RouteTable.Routes);

		}
		void Session_Start(object sender, EventArgs e)
		{
			//Check URL to set language resource file
			string _language = "EN";
			
			SetResourceFile(_language);
		}

		private void SetResourceFile(string strLanguage)
		{
			if (Session["AsposeZIPResources"] == null)
				Session["AsposeZIPResources"] = new GlobalAppHelper(HttpContext.Current, Application, Configuration.ResourceFileSessionName, strLanguage);
		}

		void RegisterCustomRoutes(RouteCollection routes)
		{
			routes.RouteExistingFiles = true;
			routes.Ignore("{resource}.axd/{*pathInfo}");
					

			routes.MapRoute(
				name: "Default",
				url: "Default",
				defaults: new { controller = "Home", action = "Default" }
			);
			
			routes.MapRoute(
				"AsposeZipFileRoute",
				"{product}/zip-file",
				 new { controller = "ZIPFile", action = "ZIPFile" }
			);
			routes.MapRoute(
				"AsposeUnZipFileRoute",
				"{product}/unzip-file",
				 new { controller = "UnzipFile", action = "UnzipFile" }
			);
			routes.MapRoute(
				"DownloadFileRoute",
				"common/download",
				new { controller = "Common", action = "DownloadFile" }
				
				
			);
			routes.MapRoute(
				"ZipDownloadFileRoute",
				"common/downloadzip",
				new { controller = "Common", action = "DownloadZIPFile" }


			);


		}

		
	}
}
