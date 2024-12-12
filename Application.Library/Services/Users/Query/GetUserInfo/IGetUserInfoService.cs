using Library.Application.Services.Users.Command.AddOrEditUser;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library.Application.Services.Users.Query.GetUserInfo
{
    public interface IGetUserInfoService
    {
        AddOrEditUserServiceDto Execute(int? id);
    }
}
