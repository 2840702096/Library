using Library.Application.Services.Books.Query.GetBooks;
using Library.Application.Services.Home.Query.GetRecentUsers;
using Library.Application.Services.Users.Query.GetUsersService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Home.Query.GetRecentBooks
{
    public interface IGetRecentBooksService
    {
        List<GetBooksServiceResultDto> Execute();
    }
}
