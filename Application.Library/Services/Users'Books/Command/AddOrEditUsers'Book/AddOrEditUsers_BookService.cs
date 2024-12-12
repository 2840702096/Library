using Library.Application.Interfaces.Context;
using Library.Common;
using Library.Common.DTOs;
using System;

namespace Library.Application.Services.Users_Books.Command.AddOrEditUsers_Book
{
    public class AddOrEditUsers_BookService : IAddOrEditUsers_BookService
    {
        private readonly IDataBaseContext _context;

        public AddOrEditUsers_BookService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(AddOrEditUsers_BookServiceInputDto input)
        {
            try
            {
                if (input.EditId == null)
                {
                    Domain.Entities.Users_Books NewUB = new Domain.Entities.Users_Books();
                    NewUB.UserId = input.UserId.Value;
                    NewUB.BookId = input.BookId;
                    NewUB.IsReturned = false;
                    NewUB.IsPaid = false;
                    NewUB.StartTime = DateTimeSettings.ToGeorgianDateTime(input.StartDate);
                    NewUB.EndTime = DateTimeSettings.ToGeorgianDateTime(input.EndDate);
                    NewUB.User = GetUserForRelation(input.UserId.Value);

                    var Book = GetBook(input.BookId);

                    NewUB.Book = Book;

                    _context.Users_Books.Add(NewUB);

                    Book.Quantity -= 1;

                    if (Book.Quantity == 0)
                    {
                        Book.IsActive = false;
                    }

                    _context.Books.Update(Book);

                    _context.SaveChanges();

                    return new ResultDto()
                    {
                        IsSuccess = true,
                        Message = "عملیات موفقیت آمیز بود",
                        Title = "موفق",
                        Icon = "success"
                    };
                }
                else
                {
                    var UB = _context.Users_Books.Find(input.EditId);

                    var PreviousBook = GetBook(UB.BookId);

                    PreviousBook.IsActive = true;

                    _context.Books.Update(PreviousBook);

                    UB.BookId = input.BookId;
                    UB.IsReturned = false;
                    UB.StartTime = DateTimeSettings.ToGeorgianDateTime(input.StartDate);
                    UB.EndTime = DateTimeSettings.ToGeorgianDateTime(input.EndDate);

                    var EditedBook = GetBook(input.BookId);

                    UB.Book = EditedBook;

                    _context.Users_Books.Update(UB);

                    EditedBook.IsActive = false;

                    _context.Books.Update(EditedBook);

                    _context.SaveChanges();

                    return new ResultDto()
                    {
                        IsSuccess = true,
                        Message = "عملیات موفقیت آمیز بود",
                        Title = "موفق",
                        Icon = "success"
                    };
                }
            }
            catch (Exception)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "عملیات با خطا مواجه شد",
                    Title = "ناموفق",
                    Icon = "error"
                };
            }
        }

        private Domain.Entities.Users GetUserForRelation(int id)
        {
            return _context.Users.Find(id);
        }

        private Domain.Entities.Books GetBook(int id)
        {
            return _context.Books.Find(id);
        }
    }
}
