using EPiServer.Core;
using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Web;
using System.Web;
using EPiServer;

namespace EpiserverLearningPlatform.Models.ViewModels
{
    public class CourseModel
    {
        public virtual ContentReference CourseImage { get; set; }

        public virtual string CourseName { get; set; }

        public virtual DateTime StartDate { get; set; }

        public virtual DateTime EndDate { get; set; }

        public virtual Url CourseLink { get; set; }
    }
}