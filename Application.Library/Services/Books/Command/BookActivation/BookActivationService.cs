using Library.Application.Interfaces.Context;
using Library.Common.DTOs;
using System;
using System.Linq;

namespace Library.Application.Services.Books.Command.BookActivation
{
    public class BookActivationService : IBookActivationService
    {
        private readonly IDataBaseContext _context;

        public BookActivationService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                if (_context.Books.SingleOrDefault(b=>b.Id == id).Quantity == 0)
                {
                    return new ResultDto()
                    {
                        IsSuccess = true,
                        Message = "به دلیل موجود نبودن این کتاب، فعالسازی امکانپذیر نیست و زمانی که کتاب برگشت داده شد، به صورت خودکار فعال خواهد شد",
                        Title = "توجه",
                        Icon = "info"
                    };
                }

                var Book = _context.Books.Find(id);

                Book.IsActive = !Book.IsActive;

                _context.Books.Update(Book);
                _context.SaveChanges();

                string Message = (Book.IsActive) ? "فعال سازی" : "غیر فعال سازی";

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = $"{Message} با موفقیت انجام شد",
                    Title = "موفق",
                    Icon = "success"
                };
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
