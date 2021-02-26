using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EpiserverLearningPlatform.Models;
using EpiserverLearningPlatform.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace EpiserverLearningPlatform
{
    [SiteContentType(GUID = "0877D78B-8673-4CF9-9F78-3E50C30C4479",
        GroupName = EpiserverLearningPlatform.Global.GroupNames.Specialized,
        DisplayName = "Find GDPR API Demo Page")]
    public class GDPRApiDemoPage : SitePageData, ISearchPage
    {
    }
}
