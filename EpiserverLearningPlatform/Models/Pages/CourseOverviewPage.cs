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
    public class CourseOverviewPage : IPageViewModel<SitePageData>
    {
        [Display(
        GroupName = SystemTabNames.Content,
        Order = 10)]
        public virtual List<CourseModel> Courses { get; set; }

        public SitePageData CurrentPage => throw new NotImplementedException();

        public LayoutModel Layout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IContent Section { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}