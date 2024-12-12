using Library.Application.Interfaces.Context;
using Library.Application.Services.Users.Query.GetUsersService;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetCountOfFurnitures
{
    public class GetCountOfUsersService : IGetCountOfUsersService
    {
        private readonly IDataBaseContext _context;

        public GetCountOfUsersService(IDataBaseContext context)
        {
            _context = context;
        }
        public int Execute()
        {
            return _context.Users.Count();
        }
    }
}
