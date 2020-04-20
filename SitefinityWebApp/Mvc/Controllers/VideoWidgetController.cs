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
    [ControllerToolboxItem(Name = "RecentVideos", Title = "Recent Video", SectionName = "MvcWidgets")]
    public class VideoWidgetController : Controller
    {
      
        [Category("String Properties")]
        [DisplayName("First Video Link")]
        [Description("Enter the First Video Link")]
        public string FirstLink { get; set; }

        [Category("String Properties")]
        [DisplayName("Second Video Link")]
        [Description("Enter the Second Video Link")]
        public string SecondLink { get; set; }

        [Category("String Properties")]
        [DisplayName("Third Video Link")]
        [Description("Enter the Third Video Link")]
        public string ThirdLink { get; set; }

        [Category("String Properties")]
        [DisplayName("Set a Playlist (Enter Playlist Link)")]
        [Description("Enter the Playlist Link")]
        public string PlayList { get; set; }
        // GET: VideoWidget
        public ActionResult Index()
        {
            var model = new VideoWidgetModel();

            model.FirstLink = this.FirstLink;
            model.SecondLink = this.SecondLink;
            model.ThirdLink = this.ThirdLink;
            model.PlayList = this.PlayList;

            return View("Default", model);
        }
    }
}