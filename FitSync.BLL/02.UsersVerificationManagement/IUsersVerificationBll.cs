using FitSync.BLL._02.UsersManagement.Dto;
using FitSync.BLL._02.UsersVerificationManagement.Dto;

namespace FitSync.BLL._02.UsersVerificationManagement
{
    public interface IUsersVerificationBll
    {
        Task<bool> CreateAndSendInvitationAsync(UsersInvitationDto dto);
        Task<bool> CreateAndSendValidateAsync(string email);
        Task<LoginResponseDto?> AcceptInvitationAsync(Guid token, string fullName, string password);
    }
}
