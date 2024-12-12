using Library.Application.Services.Users.Query.GetMessageContext;
using Library.Application.Services.Users_Books.Command.AddOrEditUsers_Book;
using Library.Application.Services.Users_Books.Command.MakeTheBookReturned;
using Library.Application.Services.Users_Books.Command.MakeTheFinePaid;
using Library.Application.Services.Users_Books.Query.GetBooksForSelectList;
using Library.Application.Services.Users_Books.Query.GetUser_sBookInfoForEdit;
using Library.Application.Services.Users_Books.Query.GetUsers_Books;

namespace Library.Application.Interfaces.FacadPaterns.Users_BooksFacadPatern
{
    public interface IUsers_BooksFacadPatern
    {
        GetUsers_BooksService GetUsers_BooksService { get; }
        GetBooksForSelectListService GetBooksForSelectListService { get; }
        AddOrEditUsers_BookService AddOrEditUsers_BookService { get; }
        GetUserSBookInfoForEditService GetUserSBookInfoForEditService { get; }
        MakeTheBookReturnedService MakeTheBookReturnedService { get; }
        MakeTheFinePaidService MakeTheFinePaidService { get; }
        GetMessageContextService GetMessageContextService { get; }
    }
}
