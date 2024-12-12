using Library.Application.Interfaces.Context;
using System.Collections.Generic;
using System.Linq;

namespace Library.Application.Services.Messages.Query.GetMessages
{
    public class GetMessagesService : IGetMessagesService
    {
        private readonly IDataBaseContext _context;

        public GetMessagesService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<GetMessagesServiceResultDto> Execute()
        {
            return _context.MessageSettings.Select(m=>new GetMessagesServiceResultDto
            {
                Id = m.Id,
                Name = m.Name,
                MessageContext = m.MessageContext
            }).ToList();
        }
    }
}
