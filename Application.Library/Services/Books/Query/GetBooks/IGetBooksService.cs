using System.Collections.Generic;

namespace Library.Application.Services.Books.Query.GetBooks
{
    public interface IGetBooksService
    {
        List<GetBooksServiceResultDto> Execute();
    }
}
