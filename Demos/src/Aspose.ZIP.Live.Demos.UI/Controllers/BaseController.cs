using Aspose.ZIP.Live.Demos.UI.Config;
using Aspose.ZIP.Live.Demos.UI.Models;
using Aspose.ZIP.Live.Demos.UI.Services;
using Aspose.ZIP.Live.Demos.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace Aspose.ZIP.Live.Demos.UI.Controllers
{
	public abstract class BaseController : Controller
	{

		/// <summary>
		/// Response when uploaded files exceed the limits
		/// </summary>
		protected Response BadDocumentResponse = new Response()
		{
			Status = "Some of your documents are corrupted",
			StatusCode = 500
		};


		public abstract string Product { get; }

		protected override void OnActionExecuted(ActionExecutedContext ctx)
		{
			base.OnActionExecuted(ctx);
			ViewBag.Title = ViewBag.Title ?? Resources["ApplicationTitle"];
			ViewBag.MetaDescription = ViewBag.MetaDescription ?? "Save time and software maintenance costs by running single instance of software, but serving multiple tenants/websites. Customization available for Joomla, Wordpress, Discourse, Confluence and other popular applications.";
		}

		private AsposeZIPContext _atcContext;


		/// <summary>
		/// Main context object to access all the dcContent specific context info
		/// </summary>
		public AsposeZIPContext AsposeZIPContext
		{
			get
			{
				if (_atcContext == null) _atcContext = new AsposeZIPContext(HttpContext.ApplicationInstance.Context);
				return _atcContext;
			}
		}

		private Dictionary<string, string> _resources;

		/// <summary>
		/// key/value pair containing all the error messages defined in resources.xml file
		/// </summary>
		public Dictionary<string, string> Resources
		{
			get
			{
				if (_resources == null) _resources = AsposeZIPContext.Resources;
				return _resources;
			}
		}




	}
}
