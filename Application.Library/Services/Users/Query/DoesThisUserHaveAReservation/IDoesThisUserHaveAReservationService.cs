using System;

namespace Library.Application.Services.Users.Query.DoesThisUserHaveAReservation
{
    public interface IDoesThisUserHaveAReservationService
    {
        bool Execute(int? id);
    }
}
