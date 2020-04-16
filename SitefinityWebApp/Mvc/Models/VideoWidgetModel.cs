using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using SitefinityWebApp.Mvc.Models;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Models
{
    public class VideoWidgetModel
    {
        public string FirstLink { get; set; }
        public string SecondLink { get; set; }
        public string ThirdLink { get; set; }

        public string PlayList { get; set; }
    }
}