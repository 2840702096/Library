using Library.Application.Services.Users.Command.AddOrEditUser;
using Library.Common.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Books.Command.AddOrEditBook
{
    public interface IAddOrEditBookService
    {
        ResultDto Execute(AddOrEditBookServiceInputDto input);
    }
}
