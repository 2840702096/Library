using Library.Application.Services.Users.Command.EditFine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Users.Query.GetFineInfoForEdit
{
    public interface IGetFineInfoForEditService
    {
        EditFineServiceResultDto Execute(int id);
    }
}
