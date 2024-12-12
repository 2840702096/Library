using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Users_Books.Query.GetUsers_Books
{
    public interface IGetUsers_BooksService
    {
        List<GetUsers_BooksServiceResultDto> Execute();
    }
}
