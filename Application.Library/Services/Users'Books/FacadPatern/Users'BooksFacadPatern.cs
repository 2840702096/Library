using Library.Application.Interfaces.Context;
using Library.Application.Interfaces.FacadPaterns.Users_BooksFacadPatern;
using Library.Application.Services.Users.Query.GetMessageContext;
using Library.Application.Services.Users_Books.Command.AddOrEditUsers_Book;
using Library.Application.Services.Users_Books.Command.MakeTheBookReturned;
using Library.Application.Services.Users_Books.Command.MakeTheFinePaid;
using Library.Application.Services.Users_Books.Query.GetBooksForSelectList;
using Library.Application.Services.Users_Books.Query.GetUser_sBookInfoForEdit;
using Library.Application.Services.Users_Books.Query.GetUsers_Books;

namespace Library.Application.Services.Users_Books.FacadPatern
{
    public class Users_BooksFacadPatern : IUsers_BooksFacadPatern
    {
        private readonly IDataBaseContext _context;

        public Users_BooksFacadPatern(IDataBaseContext context)
        {
            _context = context;
        }

        private GetUsers_BooksService _getUsers_BooksService;
        public GetUsers_BooksService GetUsers_BooksService
        {
            get
            {
                return _getUsers_BooksService = _getUsers_BooksService == null ? new GetUsers_BooksService(_context) : _getUsers_BooksService;
            }
        }

        private GetBooksForSelectListService _getBooksForSelectListService;
        public GetBooksForSelectListService GetBooksForSelectListService
        {
            get
            {
                return _getBooksForSelectListService = _getBooksForSelectListService == null ? new GetBooksForSelectListService(_context) : _getBooksForSelectListService;
            }
        }

        private AddOrEditUsers_BookService _addOrEditUsers_BookService;
        public AddOrEditUsers_BookService AddOrEditUsers_BookService
        {
            get
            {
                return _addOrEditUsers_BookService = _addOrEditUsers_BookService == null ? new AddOrEditUsers_BookService(_context) : _addOrEditUsers_BookService;
            }
        }

        private GetUserSBookInfoForEditService _getUserSBookInfoForEditService;
        public GetUserSBookInfoForEditService GetUserSBookInfoForEditService
        {
            get
            {
                return _getUserSBookInfoForEditService = _getUserSBookInfoForEditService == null ? new GetUserSBookInfoForEditService(_context) : _getUserSBookInfoForEditService;
            }
        }

        private MakeTheBookReturnedService _makeTheBookReturnedService;
        public MakeTheBookReturnedService MakeTheBookReturnedService
        {
            get
            {
                return _makeTheBookReturnedService = _makeTheBookReturnedService == null ? new MakeTheBookReturnedService(_context) : _makeTheBookReturnedService;
            }
        }

        private GetMessageContextService _getMessageContextService;
        public GetMessageContextService GetMessageContextService
        {
            get
            {
                return _getMessageContextService = _getMessageContextService == null ? new GetMessageContextService(_context) : _getMessageContextService;
            }
        }

        private MakeTheFinePaidService _makeTheFinePaidService;
        public MakeTheFinePaidService MakeTheFinePaidService
        {
            get
            {
                return _makeTheFinePaidService = _makeTheFinePaidService == null ? new MakeTheFinePaidService(_context) : _makeTheFinePaidService;
            }
        }
    }
}
