using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using SitefinityWebApp.Mvc.Models;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "RecentVideos", Title = "Recent Videos", SectionName = "MvcWidgets")]
    public class VideoWidgetController : Controller
    {
      
        [Category("String Properties")]
        [DisplayName("First Video Link")]
        [Description("Enter the First Video Link")]
        public string FirstLink { get; set; }

        [Category("String Properties")]
        [DisplayName("Second Video Link")]
        [Description("Enter the First Video Link")]
        public string SecondLink { get; set; }

        [Category("String Properties")]
        [DisplayName("Third Video Link")]
        [Description("Enter the First Video Link")]
        public string ThirdLink { get; set; }
        // GET: VideoWidget
        public ActionResult Index()
        {
            var model = new VideoWidgetModel
            {
                FirstLink = this.FirstLink,
                SecondLink = this.SecondLink,
                ThirdLink = this.ThirdLink
            };

            return View("Default", model);
        }
    }
}