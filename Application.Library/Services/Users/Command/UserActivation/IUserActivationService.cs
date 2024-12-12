using Library.Common.DTOs;

namespace Library.Application.Services.Users.Command.UserActivation
{
    public interface IUserActivationService
    {
        ResultDto Execute(int id);
    }
}
