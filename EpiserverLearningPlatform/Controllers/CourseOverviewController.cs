using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Web.Mvc;
using EpiserverLearningPlatform.Business;
using EpiserverLearningPlatform.Models.Pages;
using EpiserverLearningPlatform.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EpiserverLearningPlatform.Controllers
{
    public class CourseOverviewController : PageControllerBase<CourseOverviewPage>
    {
        public ActionResult Index(SitePageData currentPage)
        {
            
            return View(currentPage);
        }
    }
}