using EPiServer.Core;
using EPiServer.PlugIn;
using EpiserverLearningPlatform.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverLearningPlatform.Models.Pages
{
    [PropertyDefinitionTypePlugIn]
    public class CourseOverviewProperty : PropertyList<CourseModel>
    {
        

    }
}