using FitSync.BLL._02.UsersManagement.Dto;

namespace FitSync.BLL._1.Security
{
    public interface IAuthService
    {
        Task<LoginResponseDto?> AuthenticateAsync(string email, string password);
    }
}
