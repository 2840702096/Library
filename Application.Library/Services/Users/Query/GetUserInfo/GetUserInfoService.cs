using Library.Application.Interfaces.Context;
using Library.Application.Services.Users.Command.AddOrEditUser;
using System;
using System.Linq;

namespace Library.Application.Services.Users.Query.GetUserInfo
{
    public class GetUserInfoService : IGetUserInfoService
    {
        private readonly IDataBaseContext _context;

        public GetUserInfoService(IDataBaseContext context)
        {
            _context = context;
        }

        public AddOrEditUserServiceDto Execute(int? id)
        {
            try
            {
                return _context.Users.Where(u => u.Id == id).Select(u => new AddOrEditUserServiceDto
                {
                    EditId = id.Value,
                    Name = u.Name,
                    Phone = u.Phone
                }).Single();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
