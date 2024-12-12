using Library.Application.Services.Books.Command.AddOrEditBook;
using Library.Application.Services.Books.Command.BookActivation;
using Library.Application.Services.Books.Command.DeleteBook;
using Library.Application.Services.Books.Query.GetBookInfo;
using Library.Application.Services.Books.Query.GetBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Interfaces.FacadPaterns.BooksFacadPatern
{
    public interface IBooksFacadPatern
    {
        public GetBooksService GetBooksService { get; }
        public GetBookInfoService GetBookInfoService { get; }
        public AddOrEditBookService AddOrEditBookService { get; }
        public BookActivationService BookActivationService { get; }
        public DeleteBookService DeleteBookService { get; }
    }
}
