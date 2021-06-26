using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EpiserverLearningPlatform.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EpiserverLearningPlatform.Models.Pages
{
    [ContentType(DisplayName = "CourseOverviewPage", GUID = "f13603ae-a7ec-4ac2-bd7d-1ae64a613553", Description = "")]
    public class CourseOverviewPage : SitePageData
    {

        [Display(
        GroupName = SystemTabNames.Content,
        Order = 10)]
        public virtual List<CourseModel> Courses { get; set; }

    }
}