using EPiServer.Core;
using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Web;
using System.Web;

namespace EpiserverLearningPlatform.Models.ViewModels
{
    public class CourseModel
    {
        public virtual IHtmlString CourseLinkUrl { get; set; }
        public virtual ContentReference CourseImage { get; set; }

        public virtual string CourseName { get; set; }

        public virtual DateTime StartDate { get; set; }

        public virtual DateTime EndDate { get; set; }
    }
}