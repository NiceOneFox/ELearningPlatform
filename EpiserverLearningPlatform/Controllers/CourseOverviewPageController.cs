using EPiServer.Web.Mvc;
using EpiserverLearningPlatform.Models.Pages;
using EpiserverLearningPlatform.Models.ViewModels;
using System.Web.Mvc;
using EPiServer;

namespace EpiserverLearningPlatform.Controllers
{
    public class CourseOverviewPageController : PageController<CourseOverviewPage>
    {
        private readonly IContentLoader _contentLoader;

        public CourseOverviewPageController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public ActionResult Index(CourseOverviewPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);
            var courses = _contentLoader.GetChildren<CoursePage>(currentPage.ContentLink);

            return View(model);
        }
    }
}