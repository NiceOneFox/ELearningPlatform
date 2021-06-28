using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;
using EpiserverLearningPlatform.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EpiserverLearningPlatform.Models.Pages
{
    [ContentType(DisplayName = "CourseOverviewPage",
        GUID = "f13603ae-a7ec-4ac2-bd7d-1ae64a613553",
        Description = "",
        GroupName = "CoursePage")]
    public class CourseOverviewPage : SitePageData
    {
        [Display(
            GroupName = Global.GroupNames.Specialized,
            Order = 10),]
        [EditorDescriptor(EditorDescriptorType = typeof(CollectionEditorDescriptor<CourseModel>))]
        public virtual IList<CourseModel> Courses { get; set; }
    }
}