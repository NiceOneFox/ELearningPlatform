using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Web;
using StructureMap;

namespace EpiserverLearningPlatform.Models.Pages
{
    [SiteContentType(
        DisplayName = "SiteSettings",
        GUID = "F808522C-0AF9-4815-B532-DAD16DE0235B",
        GroupName = Global.GroupNames.SiteSettings)]
    public class SiteSettingsPage : SitePageData
    {
        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 10)]
        public virtual bool SomeFeatureEnabled { get; set; }
        
        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 20)]
        [UIHint(UIHint.Image)]
        public virtual Url HeaderLogo { get; set; }
        
        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 30)]
        public virtual string BrandText { get; set; }
    }
}