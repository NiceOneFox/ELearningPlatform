using System.Web.Mvc;
using EpiserverLearningPlatform.Models.Pages;
using EpiserverLearningPlatform.Models.ViewModels;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace EpiserverLearningPlatform.Controllers
{
    public class CoursePageController : PageControllerBase<CoursePage>
    {
        public ActionResult Index(CoursePage currentPage)
        {
            var model = PageViewModel.Create(currentPage);

            return View(model);
        }
    }
}
