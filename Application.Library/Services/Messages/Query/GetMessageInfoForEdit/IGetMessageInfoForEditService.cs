using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Messages.Query.GetMessageInfoForEdit
{
    public interface IGetMessageInfoForEditService
    {
        GetMessageInfoForEditServiceResultDto Execute(int id);
    }
}
