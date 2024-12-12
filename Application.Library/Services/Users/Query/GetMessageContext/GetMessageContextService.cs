using Library.Application.Interfaces.Context;
using System.Linq;

namespace Library.Application.Services.Users.Query.GetMessageContext
{
    public class GetMessageContextService : IGetMessageContextService
    {
        private readonly IDataBaseContext _context;

        public GetMessageContextService(IDataBaseContext context)
        {
            _context = context;
        }

        public string Execute(int id)
        {
            return _context.MessageSettings.SingleOrDefault(m => m.Id == id).MessageContext;
        }
    }
}
