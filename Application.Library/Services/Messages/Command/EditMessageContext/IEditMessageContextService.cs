using Library.Application.Services.Messages.Query.GetMessageInfoForEdit;
using Library.Common.DTOs;

namespace Library.Application.Services.Messages.Command.EditMessageContext
{
    public interface IEditMessageContextService
    {
        ResultDto Execute(GetMessageInfoForEditServiceResultDto input);
    }
}
