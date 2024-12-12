using Library.Application.Interfaces.Context;
using Library.Common.DTOs;
using System;

namespace Library.Application.Services.Books.Command.DeleteBook
{
    public class DeleteBookService : IDeleteBookService
    {
        private readonly IDataBaseContext _context;

        public DeleteBookService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                var Book = _context.Books.Find(id);

                Book.IsDelete = true;

                _context.Books.Update(Book);
                _context.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "عملیات با موفقیت انجام شد",
                    Title = "موفق",
                    Icon = "success"
                };
            }
            catch (Exception)
            {
                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "عملیات با خطا مواجه شد",
                    Title = "ناموفق",
                    Icon = "error"
                };
            }
        }
    }
}
