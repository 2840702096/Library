using Library.Application.Services.Users.Command.DeleteUser;
using Library.Common.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Books.Command.DeleteBook
{
    public interface IDeleteBookService
    {
        ResultDto Execute(int id);
    }
}
