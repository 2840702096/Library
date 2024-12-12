using Library.Application.Services.Books.Command.AddOrEditBook;
using Library.Application.Services.Users.Command.AddOrEditUser;
using Library.Application.Services.Users.Query.GetUserInfo;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Books.Query.GetBookInfo
{
    public interface IGetBookInfoService
    {
        AddOrEditBookServiceInputDto Execute(int? id);
    }
}
