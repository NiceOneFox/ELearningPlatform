using EPiServer.Core;
using EpiserverLearningPlatform.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverLearningPlatform.Models.ViewModels
{
    public class CourseModel : PageViewModel<SitePageData>
    {
        public CourseModel(SitePageData currentPage, IContent previewContent)
        : base(currentPage)
        {
            Section = previewContent;
            courseAreas = new List<CourseArea>();
        }

        public List<CourseArea> courseAreas;

        public IContent Section { get; set; }

        public class CourseArea
        {
            public ContentReference Image { get; set; }

            public string CourseName { get; set; }

            public DateTime StartDate { get; set; }

            public DateTime EndDate { get; set; }
        }
     
    }
}