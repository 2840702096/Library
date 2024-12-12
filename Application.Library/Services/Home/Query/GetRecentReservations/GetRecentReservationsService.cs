using Library.Application.Interfaces.Context;
using Library.Application.Services.Users_Books.Query.GetUsers_Books;
using System.Collections.Generic;
using System.Linq;

namespace Library.Application.Services.Home.Query.GetRecentReservations
{
    public class GetRecentReservationsService : IGetRecentReservationsService 
    {
        private readonly IDataBaseContext _context;

        public GetRecentReservationsService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<GetUsers_BooksServiceResultDto> Execute()
        {
            return _context.Users_Books.OrderByDescending(u => u.Id).Take(5).Select(u => new GetUsers_BooksServiceResultDto
            {
                Id = u.Id,
                User = u.User,
                Book = u.Book
            }).ToList();
        }
    }
}
