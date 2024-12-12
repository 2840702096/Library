using System;
using System.Collections.Generic;

namespace Library.Application.Services.Messages.Query.GetMessages
{
    public interface IGetMessagesService
    {
        List<GetMessagesServiceResultDto> Execute();
    }
}
