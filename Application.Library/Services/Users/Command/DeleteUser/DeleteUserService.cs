using Library.Application.Interfaces.Context;
using Library.Common.DTOs;
using System;

namespace Library.Application.Services.Users.Command.DeleteUser
{
    public class DeleteUserService : IDeleteUserService
    {
        private readonly IDataBaseContext _context;

        public DeleteUserService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                var User = _context.Users.Find(id);

                User.IsDelete = true;

                _context.Users.Update(User);
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
