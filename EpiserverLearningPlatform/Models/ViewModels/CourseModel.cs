using EPiServer.Core;
using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Web;


namespace EpiserverLearningPlatform.Models.ViewModels
{
    public class CourseModel
    {
           [UIHint(UIHint.Image)]
           public ContentReference Image { get; set; }

            public string CourseName { get; set; }

            public DateTime StartDate { get; set; }

            public DateTime EndDate { get; set; }
    }
}