using System.Web.Mvc;
using EpiserverLearningPlatform.Models.Pages;
using EpiserverLearningPlatform.Models.ViewModels;

namespace EpiserverLearningPlatform.Controllers
{
    public class SiteSettingsPageController : PageControllerBase<SiteSettingsPage>
    {
        public ActionResult Index(SiteSettingsPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);
            return View(model);
        }
    }
}