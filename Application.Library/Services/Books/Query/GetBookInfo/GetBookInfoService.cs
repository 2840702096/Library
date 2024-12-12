using Library.Application.Interfaces.Context;
using Library.Application.Services.Books.Command.AddOrEditBook;
using System;
using System.Linq;

namespace Library.Application.Services.Books.Query.GetBookInfo
{
    public class GetBookInfoService : IGetBookInfoService
    {
        private readonly IDataBaseContext _context;

        public GetBookInfoService(IDataBaseContext context)
        {
            _context = context;
        }

        public AddOrEditBookServiceInputDto Execute(int? id)
        {
            try
            {
                return _context.Books.Where(u => u.Id == id).Select(u => new AddOrEditBookServiceInputDto
                {
                    Name = u.Name,
                    Quantity = u.Quantity
                }).Single();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
