using Library.Common.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Users_Books.Command.MakeTheBookReturned
{
    public interface IMakeTheBookReturnedService
    {
        MakeTheBookReturnedServiceResultDto Execute(int id);
    }
}
