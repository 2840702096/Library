using Library.Application.Services.Users.Command.UserActivation;
using Library.Common.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Books.Command.BookActivation
{
    public interface IBookActivationService
    {
        ResultDto Execute(int id);
    }
}
