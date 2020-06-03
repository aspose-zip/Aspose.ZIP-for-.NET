using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aspose.Zip;

namespace Aspose.ZIP.Live.Demos.UI.Models
{
	///<Summary>
	/// License class to set apose products license
	///</Summary>
	public static class License
	{
		private static string _licenseFileName = "Aspose.Total.lic";

		///<Summary>
		/// SetAsposeZIPLicense method to Aspose.ThreeD License
		///</Summary>
		public static void SetAsposeZIPLicense()
		{
			try
			{

				Aspose.Zip.License lic = new Aspose.Zip.License();
				lic.SetLicense(_licenseFileName);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}	
		
	}
}
