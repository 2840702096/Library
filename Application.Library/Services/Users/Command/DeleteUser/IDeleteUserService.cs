using Library.Common.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Users.Command.DeleteUser
{
    public interface IDeleteUserService
    {
        ResultDto Execute(int id);
    }
}
