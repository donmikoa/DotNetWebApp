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
    public class VideoWidgetController : Controller
    {
        [Category("String Properties")]
        [DisplayName("First Name")]
        [Description("Enter the First Name")]
        public string Message { get; set; }
        // GET: VideoWidget
        public ActionResult Index()
        {
            var model = new VideoWidgetModel();

            if (string.IsNullOrEmpty(this.Message))
            { model.Message = "Hello World"; }
            else { model.Message = this.Message; }
            return View("Default", model);
        }
    }
}