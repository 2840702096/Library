using Library.Application.Interfaces.Context;
using Library.Application.Services.Users_Books.Command.AddOrEditUsers_Book;
using Library.Common;
using System.Linq;

namespace Library.Application.Services.Users_Books.Query.GetUser_sBookInfoForEdit
{
    public class GetUserSBookInfoForEditService : IGetUser_sBookInfoForEditService
    {
        private readonly IDataBaseContext _context;

        public GetUserSBookInfoForEditService(IDataBaseContext context)
        {
            _context = context;
        }

        public AddOrEditUsers_BookServiceInputDto Execute(int? id)
        {
            return _context.Users_Books.Where(u => u.Id == id).Select(u => new AddOrEditUsers_BookServiceInputDto
            {
                BookId = u.BookId,
                StartDate = DateTimeSettings.ToPersianDateString(u.StartTime),
                EndDate = DateTimeSettings.ToPersianDateString(u.EndTime)
            }).SingleOrDefault();
        }
    }
}
