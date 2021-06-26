using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiserverLearningPlatform.Models.Blocks
{
    [ContentType(DisplayName = "CourseBlock", GUID = "fd622dca-ae47-4aad-960e-0e89dc11c061", Description = "",
         GroupName = SystemTabNames.Content)]
    [SiteImageUrl]
    public class CourseBlock : BlockData
    {
        [Display(Name = "Course Name",
     GroupName = SystemTabNames.Content)]
        public virtual DateTime CourseName { get; set; }

        [Display(Name = "Course start Date",
         GroupName = SystemTabNames.Content)]
       public virtual DateTime StartDate { get; set; }

        [Display(Name = "Course end Date",
       GroupName = SystemTabNames.Content)]
        public virtual DateTime EndDate { get; set; }

    }
}