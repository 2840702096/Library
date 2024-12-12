using Library.Application.Services.Messages.Command.EditMessageContext;
using Library.Application.Services.Messages.Query.GetMessageInfoForEdit;
using Library.Application.Services.Messages.Query.GetMessages;

namespace Library.Application.Interfaces.FacadPaterns.MessagesFacadPatern
{
    public interface IMessagesFacadPaternService
    {
        public GetMessagesService GetMessagesService { get; }
        public GetMessageInfoForEditService GetMessageInfoForEditService { get; }
        public EditMessageContextService EditMessageContextService { get; }
    }
}
