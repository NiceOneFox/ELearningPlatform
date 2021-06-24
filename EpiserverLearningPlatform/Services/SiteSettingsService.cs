using System.Linq;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EpiserverLearningPlatform.Models.Pages;

namespace EpiserverLearningPlatform.Services
{
    [ServiceConfiguration(typeof(ISiteSettingsService), Lifecycle = ServiceInstanceScope.Singleton)]
    public class SiteSettingsService : ISiteSettingsService
    {
       private readonly IContentLoader _contentLoader;

       public SiteSettingsService(IContentLoader contentLoader)
       {
           _contentLoader = contentLoader;
       }

       public SiteSettingsPage GetSiteSettingsPage()
       {
           var settingsPage = _contentLoader.GetChildren<SiteSettingsPage>(ContentReference.StartPage);
           return settingsPage.FirstOrDefault();
       }
    }
}