using System.Web.Mvc;
using EpiserverLearningPlatform.Models.Pages;
using EpiserverLearningPlatform.Models.ViewModels;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace EpiserverLearningPlatform.Controllers
{
    public class AuthorizationController : PageController<AuthorizationPage>
    {
        public ActionResult Index(AuthorizationPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            var model = PageViewModel.Create(currentPage);

            return View(currentPage);
        }
    }
}