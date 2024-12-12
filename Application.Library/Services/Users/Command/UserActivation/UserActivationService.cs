using Library.Application.Interfaces.Context;
using Library.Common.DTOs;
using System;

namespace Library.Application.Services.Users.Command.UserActivation
{
    public class UserActivationService : IUserActivationService
    {
        private readonly IDataBaseContext _context;

        public UserActivationService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                var User = _context.Users.Find(id);

                User.IsActive = !User.IsActive;

                _context.Users.Update(User);
                _context.SaveChanges();

                string Message = (User.IsActive) ? "فعال سازی" : "غیر فعال سازی";

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
