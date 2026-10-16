using FitSync.BLL._02.UsersManagement.Dto;

namespace FitSync.BLL._02.UsersManagement
{
    public class UserDto : UserReadDto
    {
        public string Password { get; set; } = string.Empty;
    }
}
