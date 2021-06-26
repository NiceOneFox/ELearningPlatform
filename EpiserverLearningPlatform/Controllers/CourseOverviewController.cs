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
            var model = CreateModel(currentPage);
            return View(model);
        }

        private static IPageViewModel<SitePageData> CreateModel(SitePageData page)
        {
            var type = typeof(PageViewModel<>).MakeGenericType(page.GetOriginalType());
            return Activator.CreateInstance(type, page) as IPageViewModel<SitePageData>;
        }
    }
}