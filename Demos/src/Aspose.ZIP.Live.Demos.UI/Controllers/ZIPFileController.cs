using Aspose.ZIP.Live.Demos.UI.Models.Common;
using Aspose.ZIP.Live.Demos.UI.Models;
using Aspose.ZIP.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;

namespace Aspose.ZIP.Live.Demos.UI.Controllers
{
	public class ZIPFileController : BaseController
	{
		public override string Product => (string)RouteData.Values["product"];
		
		[HttpPost]
		public Response ZIPFile(string encryptType, string setPass, string pass)
		{
			encryptType = encryptType.Trim();			
			Response response = null;
			var files = Request.Files;
			string zipFileName = "";
			foreach (string fileName in Request.Files)
			{
				HttpPostedFileBase postedFile = Request.Files[fileName];

				if (postedFile != null)
				{
					var isFileUploaded = FileManager.UploadFile(postedFile);

					if ((isFileUploaded != null) && (isFileUploaded.FileName.Trim() != ""))
					{
						AsposeZipCompress asposeZipCompress = new AsposeZipCompress();
							 response = asposeZipCompress.CompressFile(isFileUploaded.FileName, isFileUploaded.FolderId, zipFileName, setPass, pass, encryptType);

						if (response == null)
						{
							throw new Exception(Resources["ResponseTime"]);
						}
						else
						{
							zipFileName = response.Text;
						}

					}
				}

			}

			return response;			
				
		}

		

		public ActionResult ZIPFile()
		{
			var model = new ViewModel(this, "ZIPFile")
			{
				SaveAsComponent = true,
				SaveAsOriginal = false,
				MaximumUploadFiles = 10,
				ControlsView = "ZIPFileControls"

				
			};

			return View(model);
		}
		

	}
}
