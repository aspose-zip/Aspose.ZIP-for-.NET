using Aspose.ZIP.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;

namespace Aspose.ZIP.Live.Demos.UI.Config
{
    public class BaseMasterPage : MasterPage
    {
        private AsposeZIPContext _atContext;

        /// <summary>
        /// Main context object to access all the SybContent specific context info
        /// </summary>
        public AsposeZIPContext AsposeZIPContext
		{
            get
            {
                if (_atContext == null) _atContext = new AsposeZIPContext(HttpContext.Current);
                return _atContext;
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

		protected override void OnLoad(EventArgs e)
        {
			// Sync the central context store with the first loaded context for this page
			AsposeZIPContext.atcc = AsposeZIPContext;
            base.OnLoad(e);
        }
    }
}
