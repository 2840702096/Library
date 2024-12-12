using Library.Application.Interfaces.Context;
using System.Collections.Generic;
using System.Linq;

namespace Library.Application.Services.Users.Query.GetUsersService
{
    public class GetUsersService : IGetUsersService
    {

        private readonly IDataBaseContext _context;

        public GetUsersService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<GetUsersServiceResultDto> Execute()
        {
            return _context.Users.Where(u=>!u.IsAdmin).Select(u => new GetUsersServiceResultDto
            {
                Id = u.Id,
                Name = u.Name,
                Phone = u.Phone,
                IsActive = u.IsActive
            }).ToList();
        }
    }
}
