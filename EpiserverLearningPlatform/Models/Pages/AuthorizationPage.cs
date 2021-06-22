using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiserverLearningPlatform.Models.Pages
{
    [ContentType(DisplayName = "AuthorizationPage", GUID = "836e8f70-a8b1-4d68-86de-e7254345e29a", Description = "")]
    public class AuthorizationPage : SitePageData
    {
        
      [CultureSpecific]
      [Display( Name = "Main body",                
       Order = 10,
       GroupName = Global.GroupNames.Contact)]
        public virtual string Login { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body",
     Order = 20,
     GroupName = Global.GroupNames.Contact)]
        public virtual string Password { get; set; }




    }
}