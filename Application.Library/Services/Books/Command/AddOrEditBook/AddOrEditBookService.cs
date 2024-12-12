using Library.Application.Interfaces.Context;
using Library.Common.DTOs;
using System;

namespace Library.Application.Services.Books.Command.AddOrEditBook
{
    public class AddOrEditBookService : IAddOrEditBookService
    {

        private readonly IDataBaseContext _context;

        public AddOrEditBookService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(AddOrEditBookServiceInputDto input)
        {
            try
            {
                if (input.EditId == null)
                {
                    Domain.Entities.Books NewBook = new Domain.Entities.Books();
                    NewBook.Name = input.Name;

                    int Quantity = input.Quantity;

                    if (Quantity == 0)
                    {
                        NewBook.Quantity = 1;
                    }
                    else
                    {
                        NewBook.Quantity = Quantity;
                    }

                    _context.Books.Add(NewBook);
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
                    var Book = _context.Books.Find(input.EditId);
                    Book.Name = input.Name;

                    Book.Quantity = input.Quantity;

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
    }
}
