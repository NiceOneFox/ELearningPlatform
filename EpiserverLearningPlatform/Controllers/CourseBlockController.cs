using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EpiserverLearningPlatform.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiserverLearningPlatform.Controllers
{
    public class CourseBlockController : BlockController<CourseBlock>
    {
        public override ActionResult Index(CourseBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
