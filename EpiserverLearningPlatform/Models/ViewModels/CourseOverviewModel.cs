using System.Collections.Generic;
using EpiserverLearningPlatform.Models.Pages;

namespace EpiserverLearningPlatform.Models.ViewModels
{
    public class CourseOverviewModel: PageViewModel<CourseOverviewPage>
    {
        public IEnumerable<CourseModel> Courses { get; set; }

        public CourseOverviewModel(CourseOverviewPage currentPage) : base(currentPage)
        {
        }
    }
}