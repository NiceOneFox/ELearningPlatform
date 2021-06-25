using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverLearningPlatform.Models.ViewModels
{
    public class CourseModel
    {
        public ContentReference Image { get; set; }

        public string CourseName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}