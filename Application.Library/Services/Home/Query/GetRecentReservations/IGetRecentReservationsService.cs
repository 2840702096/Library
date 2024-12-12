using Library.Application.Services.Books.Query.GetBooks;
using Library.Application.Services.Users_Books.Query.GetUsers_Books;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Home.Query.GetRecentReservations
{
    public interface IGetRecentReservationsService
    {
        List<GetUsers_BooksServiceResultDto> Execute();
    }
}
