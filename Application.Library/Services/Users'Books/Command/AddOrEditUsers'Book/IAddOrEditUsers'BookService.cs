using Library.Common.DTOs;
using Library.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Users_Books.Command.AddOrEditUsers_Book
{
    public interface IAddOrEditUsers_BookService
    {
        ResultDto Execute(AddOrEditUsers_BookServiceInputDto input);
    }
}
