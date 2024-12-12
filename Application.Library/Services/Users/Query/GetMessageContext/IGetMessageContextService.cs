using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Users.Query.GetMessageContext
{
    public interface IGetMessageContextService
    {
        string Execute(int id);
    }
}
