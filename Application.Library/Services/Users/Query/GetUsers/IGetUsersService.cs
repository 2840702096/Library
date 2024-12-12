using System.Collections.Generic;

namespace Library.Application.Services.Users.Query.GetUsersService
{
    public interface IGetUsersService
    {
        List<GetUsersServiceResultDto> Execute();
    }
}
