using FitSync.BLL._02.UserRelationManagement.Dto;

namespace FitSync.BLL._02.UserRelationManagement
{
    public interface IUserRelationBll
    {
        Task<bool> SyncUserRelation(UserRelationDto dto);
        Task<bool> CreateFriendshipAsync(Guid userId, Guid friendId);
    }
}
