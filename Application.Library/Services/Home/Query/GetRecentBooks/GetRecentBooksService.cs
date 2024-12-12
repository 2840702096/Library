using Library.Application.Interfaces.Context;
using Library.Application.Services.Books.Query.GetBooks;
using System.Collections.Generic;
using System.Linq;

namespace Library.Application.Services.Home.Query.GetRecentBooks
{
    public class GetRecentBooksService : IGetRecentBooksService
    {
        private readonly IDataBaseContext _context;

        public GetRecentBooksService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<GetBooksServiceResultDto> Execute()
        {
            return _context.Books.OrderByDescending(u => u.Id).Take(5).Select(u => new GetBooksServiceResultDto
            {
                Id = u.Id,
                Name = u.Name,
                IsActive = u.IsActive
            }).ToList();
        }
    }
}
