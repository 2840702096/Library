using Library.Application.Interfaces.Context;
using Library.Common.DTOs;
using System;
using System.Xml.Schema;

namespace Library.Application.Services.Users.Command.AddOrEditUser
{
    public class AddOrEditUserService : IAddOrEditUserService
    {

        private readonly IDataBaseContext _context;

        public AddOrEditUserService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(AddOrEditUserServiceDto input)
        {
            try
            {
                if (input.EditId == 0)
                {
                    Domain.Entities.Users NewUser = new Domain.Entities.Users();
                    NewUser.Name = input.Name;
                    NewUser.Phone = input.Phone;
                    NewUser.IsAdmin = false;

                    _context.Users.Add(NewUser);
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
                    var User = _context.Users.Find(input.EditId);
                    User.Name = input.Name;
                    User.Phone = input.Phone;

                    _context.Users.Update(User);
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
