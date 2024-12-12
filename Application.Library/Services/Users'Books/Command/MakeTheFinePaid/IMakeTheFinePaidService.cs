using Library.Application.Services.Users_Books.Command.MakeTheBookReturned;
using Library.Common.DTOs;

namespace Library.Application.Services.Users_Books.Command.MakeTheFinePaid
{
    public interface IMakeTheFinePaidService
    {
        ResultDto Execute(int id);
    }
}
