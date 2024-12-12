using Library.Application.Services.Users.Query.GetUsersService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Home.Query.GetRecentUsers
{
    public interface IGetRecentUsersService
    {
        List<GetUsersServiceResultDto> Execute();
    }
}
