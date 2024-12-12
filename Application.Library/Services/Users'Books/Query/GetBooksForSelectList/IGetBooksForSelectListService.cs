using System.Collections.Generic;
using System.Web.Mvc;

namespace Library.Application.Services.Users_Books.Query.GetBooksForSelectList
{
    public interface IGetBooksForSelectListService
    {
        List<SelectListItem> Execute(int? editId);
    }
}
