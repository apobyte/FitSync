using FitSync.BLL._02.UsersManagement.Dto;

namespace FitSync.BLL._1.Security
{
    public interface ITokenService
    {
        string CreateToken(UserReadDto user);
    }
}
