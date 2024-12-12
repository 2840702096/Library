using Library.Application.Interfaces.Context;
using Library.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Library.Application.Services.Users_Books.Query.GetUsers_Books
{
    public class GetUsers_BooksService : IGetUsers_BooksService
    {
        private readonly IDataBaseContext _context;

        public GetUsers_BooksService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<GetUsers_BooksServiceResultDto> Execute()
        {
            return _context.Users_Books.Select(u => new GetUsers_BooksServiceResultDto
            {
                Id = u.Id,
                IsReturned = u.IsReturned,
                StartTime = u.StartTime,
                EndTime = u.EndTime,
                User = u.User,
                Book = u.Book,
            }).ToList();
        }
    }
}
