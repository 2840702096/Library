using Library.Application.Interfaces.Context;
using System.Collections.Generic;
using System.Linq;

namespace Library.Application.Services.Books.Query.GetBooks
{
    public class GetBooksService : IGetBooksService
    {
        private readonly IDataBaseContext _context;

        public GetBooksService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<GetBooksServiceResultDto> Execute()
        {
            return _context.Books.Select(b => new GetBooksServiceResultDto
            {
                Id = b.Id,
                Name = b.Name,
                IsActive = b.IsActive
            }).ToList();
        }
    }
}
