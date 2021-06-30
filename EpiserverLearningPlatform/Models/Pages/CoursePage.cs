using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Web;
using EPiServer.Core;
using EPiServer;

namespace EpiserverLearningPlatform.Models.Pages
{
    [SiteContentType(
        GUID = "4754534B-09F6-4302-B326-DF64E17E5E36",
        GroupName = Global.GroupNames.Specialized)]
    public class CoursePage: SitePageData
    {
        [Display(GroupName = Global.GroupNames.Contact, Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BannerImage { get; set; }

        [Display(GroupName = Global.GroupNames.Contact, Order = 20)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BackgroundImage { get; set; }

        [Display(GroupName = Global.GroupNames.Contact, Order = 30)]
        public virtual string CourseName { get; set; }

        [Display(GroupName = Global.GroupNames.Contact, Order = 40)]
        public virtual DateTime StartDate { get; set; }
        
        [Display(GroupName = Global.GroupNames.Contact, Order = 50)]
        public virtual DateTime EndDate { get; set; }

        [Display(GroupName = Global.GroupNames.Contact, Order = 60)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference CalendarImage { get; set; }


        
        [Display(Order = 1, GroupName = Global.GroupNames.Contact)]
        [Required]
        public virtual string ButtonText { get; set; }

        [Display(Order = 2, GroupName = Global.GroupNames.Contact)]
        [Required]
        public virtual Url ButtonLink { get; set; }
    }
}
