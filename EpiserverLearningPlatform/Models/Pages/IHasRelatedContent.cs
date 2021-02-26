using EPiServer.Core;

namespace EpiserverLearningPlatform.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
