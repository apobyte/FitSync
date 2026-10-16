using FitSync.BLL._12.FeedEventManagement.Dto;

namespace FitSync.BLL._12.FeedEventManagement
{
    public interface IFeedEventBll
    {
        Task<bool> SyncFeedEvent(FeedEventDto dto);
    }
}
