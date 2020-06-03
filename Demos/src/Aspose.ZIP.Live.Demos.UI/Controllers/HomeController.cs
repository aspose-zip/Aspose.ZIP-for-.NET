using Aspose.ZIP.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.ZIP.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "Compress several files to create single archive or uncompress archives";
			ViewBag.MetaDescription = "On premise APIs or Free Apps to compose archive, add entries or delete entries from existing archives. Encrypt using ZipCrypto or AES128, 192 and AES256.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
