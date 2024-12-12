using Library.Application.Interfaces.Context;
using Library.Common;
using Library.Common.DTOs;
using System;
using System.Linq;

namespace Library.Application.Services.Users_Books.Command.MakeTheBookReturned
{
    public class MakeTheBookReturnedService : IMakeTheBookReturnedService
    {
        private readonly IDataBaseContext _context;

        public MakeTheBookReturnedService(IDataBaseContext context)
        {
            _context = context;
        }

        public MakeTheBookReturnedServiceResultDto Execute(int id)
        {
            try
            {
                DateTime Time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                var UserBook = _context.Users_Books.Find(id);

                if (Time > UserBook.EndTime && UserBook.IsPaid == false)
                {
                    double Delay = DateTimeSettings.GetTheDelayOfReturning(Time, UserBook.EndTime);

                    double Fine = _context.Fine.First().FineValue * Delay;

                    return new MakeTheBookReturnedServiceResultDto()
                    {
                        IsSuccess = 2,
                        Message = $"بازگردانی کتاب با {Delay} روز تاخیر صورت گرفته است. کاربر باید {Fine.ToString("#,0")} تومان جریمه بپردازد ",
                        Title = "نا موفق",
                        Icon = "error"
                    };
                }

                UserBook.IsReturned = true;

                _context.Users_Books.Update(UserBook);

                var Book = _context.Books.Find(UserBook.BookId);

                if (Book.Quantity == 0)
                {
                    Book.IsActive = true;
                }

                Book.Quantity += 1;

                _context.Books.Update(Book);
                _context.SaveChanges();

                return new MakeTheBookReturnedServiceResultDto()
                {
                    IsSuccess = 1,
                    Message = "بازگردانی کتاب با موفقیت ثبت شد",
                    Title = "موفق",
                    Icon = "success"
                };
            }
            catch (Exception)
            {
                return new MakeTheBookReturnedServiceResultDto()
                {
                    IsSuccess = 3,
                    Message = "بازگردانی کتاب با خطا مواجه شد",
                    Title = "ناموفق",
                    Icon = "error"
                };
            }
        }
    }

    public class MakeTheBookReturnedServiceResultDto
    {
        public int IsSuccess { get; set; }
        public string Message { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}
