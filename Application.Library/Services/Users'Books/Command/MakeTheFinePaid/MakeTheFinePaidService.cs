using Library.Application.Interfaces.Context;
using Library.Common.DTOs;
using System;

namespace Library.Application.Services.Users_Books.Command.MakeTheFinePaid
{
    public class MakeTheFinePaidService : IMakeTheFinePaidService
    {
        private readonly IDataBaseContext _context;

        public MakeTheFinePaidService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                var Users_Book = _context.Users_Books.Find(id);

                Users_Book.IsPaid = true;

                _context.Users_Books.Update(Users_Book);
                _context.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "جریمه کاربر دریافت شد",
                    Title = "موفق",
                    Icon = "success"
                };
            }
            catch (Exception)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "دریافت جریمه کاربر با خطا مواجه شد",
                    Title = "ناموفق",
                    Icon = "error"
                };
            }
        }
    }
}
