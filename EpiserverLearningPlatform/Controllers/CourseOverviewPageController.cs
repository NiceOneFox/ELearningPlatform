using System.Linq;
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
            var actualModel = new CourseOverviewModel(currentPage)
            {
                Layout = model.Layout,
                Section = model.Section              
            };
            var courses = _contentLoader
                .GetChildren<CoursePage>(currentPage.ContentLink)
                .Select(course => new CourseModel()
                {
                    CourseName = course.CourseName,
                    EndDate = course.EndDate,
                    StartDate = course.StartDate,
                    CourseImage = course.BannerImage,
                });

            actualModel.Courses = courses;
            return View(actualModel);
        }
    }
}