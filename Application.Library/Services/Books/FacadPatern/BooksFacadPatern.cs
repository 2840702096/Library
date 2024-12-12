using Library.Application.Interfaces.Context;
using Library.Application.Interfaces.FacadPaterns.BooksFacadPatern;
using Library.Application.Services.Books.Command.AddOrEditBook;
using Library.Application.Services.Books.Command.BookActivation;
using Library.Application.Services.Books.Command.DeleteBook;
using Library.Application.Services.Books.Query.GetBookInfo;
using Library.Application.Services.Books.Query.GetBooks;
using Library.Application.Services.Users.Query.GetUsersService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Books.FacadPatern
{
    public class BooksFacadPatern : IBooksFacadPatern
    {
        private readonly IDataBaseContext _context;

        public BooksFacadPatern(IDataBaseContext context)
        {
            _context = context;
        }

        private GetBooksService _getBooksService;
        public GetBooksService GetBooksService
        {
            get
            {
                return _getBooksService = _getBooksService == null ? new GetBooksService(_context) : _getBooksService;
            }
        }

        private GetBookInfoService _getBookInfoService;
        public GetBookInfoService GetBookInfoService
        {
            get
            {
                return _getBookInfoService = _getBookInfoService == null ? new GetBookInfoService(_context) : _getBookInfoService;
            }
        }

        private AddOrEditBookService _addOrEditBookService;
        public AddOrEditBookService AddOrEditBookService
        {
            get
            {
                return _addOrEditBookService = _addOrEditBookService == null ? new AddOrEditBookService(_context) : _addOrEditBookService;
            }
        }

        private BookActivationService _bookActivationService;
        public BookActivationService BookActivationService
        {
            get
            {
                return _bookActivationService = _bookActivationService == null ? new BookActivationService(_context) : _bookActivationService;
            }
        }

        private DeleteBookService _deleteBookService;
        public DeleteBookService DeleteBookService
        {
            get
            {
                return _deleteBookService = _deleteBookService == null ? new DeleteBookService(_context) : _deleteBookService;
            }
        }
    }
}
