using Library.Application.Interfaces.Context;

namespace Library.Application.Services.Messages.Query.GetMessageInfoForEdit
{
    public class GetMessageInfoForEditService : IGetMessageInfoForEditService
    {
        private readonly IDataBaseContext _context;

        public GetMessageInfoForEditService(IDataBaseContext context)
        {
            _context = context;
        }

        public GetMessageInfoForEditServiceResultDto Execute(int id)
        {
            var Message = _context.MessageSettings.Find(id);

            return new GetMessageInfoForEditServiceResultDto()
            {
                EditId = id,
                MessageContext = Message.MessageContext
            };
        }
    }
}
