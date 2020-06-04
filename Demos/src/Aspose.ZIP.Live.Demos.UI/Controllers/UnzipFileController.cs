using Aspose.ZIP.Live.Demos.UI.Models.Common;
using Aspose.ZIP.Live.Demos.UI.Models;
using Aspose.ZIP.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;

namespace Aspose.ZIP.Live.Demos.UI.Controllers
{
	public class UnzipFileController : BaseController
	{
		public override string Product => (string)RouteData.Values["product"];
		
		[HttpPost]
		public Response UnzipFile(string encryptType, string setPass, string pass)
		{
			encryptType = encryptType.Trim();			
			Response response = null;
			var files = Request.Files;			
			foreach (string fileName in Request.Files)
			{
				HttpPostedFileBase postedFile = Request.Files[fileName];

				if (postedFile != null)
				{
					var isFileUploaded = FileManager.UploadFile(postedFile);

					if ((isFileUploaded != null) && (isFileUploaded.FileName.Trim() != ""))
					{
						AsposeZipCompress asposeZipCompress = new AsposeZipCompress();
							 response = asposeZipCompress.DecompressFile(isFileUploaded.FileName, isFileUploaded.FolderId,  setPass, pass, encryptType);

						if (response == null)
						{
							throw new Exception(Resources["ResponseTime"]);
						}
						

					}
				}

			}

			return response;			
				
		}

		

		public ActionResult UnzipFile()
		{
			var model = new ViewModel(this, "UnzipFile")
			{
				SaveAsComponent = true,
				SaveAsOriginal = false,
				MaximumUploadFiles = 1,
				ControlsView = "ZIPFileControls"

				
			};

			return View(model);
		}
		

	}
}
