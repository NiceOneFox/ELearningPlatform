using EPiServer.Core;
using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Web;


namespace EpiserverLearningPlatform.Models.ViewModels
{
    public class CourseModel
    {
           [UIHint(UIHint.Image)]
           public  virtual ContentReference CourseImage { get; set; }

           public virtual string CourseName { get; set; }

            public virtual DateTime StartDate { get; set; }

            public virtual DateTime EndDate { get; set; }
    }
}