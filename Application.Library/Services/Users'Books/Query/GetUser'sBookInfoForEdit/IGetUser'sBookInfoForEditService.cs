using Library.Application.Services.Users_Books.Command.AddOrEditUsers_Book;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Users_Books.Query.GetUser_sBookInfoForEdit
{
    public interface IGetUser_sBookInfoForEditService
    {
        AddOrEditUsers_BookServiceInputDto Execute(int? id);
    }
}
