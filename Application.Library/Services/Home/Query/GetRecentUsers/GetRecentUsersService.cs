using Library.Application.Interfaces.Context;
using Library.Application.Services.Users.Query.GetUsersService;
using System.Collections.Generic;
using System.Linq;

namespace Library.Application.Services.Home.Query.GetRecentUsers
{
    public class GetRecentUsersService : IGetRecentUsersService
    {
        private readonly IDataBaseContext _context;

        public GetRecentUsersService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<GetUsersServiceResultDto> Execute()
        {
            return _context.Users.OrderByDescending(u => u.Id).Take(5).Select(u => new GetUsersServiceResultDto
            {
                Id = u.Id,
                Name = u.Name,
                Phone = u.Phone
            }).ToList();
        }
    }
}
