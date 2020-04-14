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
    [ControllerToolboxItem(Name = "VideoWidget", Title = "Video Widget", SectionName = "MvcWidgets")]
    public class VideoWidgetController : Controller
    {
        [Category("String Properties")]
        [DisplayName("First Message")]
        [Description("Enter the First Message")]
        public string Message { get; set; }

        [Category("String Properties")]
        [DisplayName("First Video Link")]
        public string FirstLink { get; set; }

        [Category("String Properties")]
        [DisplayName("Second Video Link")]
        public string SecondLink { get; set; }

        [Category("String Properties")]
        [DisplayName("Third Video Link")]
        public string ThirdLink { get; set; }
        // GET: VideoWidget
        public ActionResult Index()
        {
            var model = new VideoWidgetModel();

            if (string.IsNullOrEmpty(this.Message))
            { model.Message = "Hello World"; }
            else
            {
                model.Message = this.Message;
                model.FirstLink = this.FirstLink;
                model.SecondLink = this.SecondLink;
                model.ThirdLink = this.ThirdLink;
            }
            return View("Default", model);
        }
    }
}