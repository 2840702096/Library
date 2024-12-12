using Library.Application.Interfaces.Context;
using System;
using System.Linq;

namespace Library.Application.Services.Users.Query.DoesThisUserHaveAReservation
{
    public class DoesThisUserHaveAReservationService : IDoesThisUserHaveAReservationService
    {
        private readonly IDataBaseContext _context;

        public DoesThisUserHaveAReservationService(IDataBaseContext context)
        {
            _context = context;
        }

        public bool Execute(int? id)
        {
            if (id != 0)
            {
                DateTime Now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                if (_context.Users_Books.Any(u => u.UserId == id && u.IsReturned == false && u.EndTime < Now))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}
