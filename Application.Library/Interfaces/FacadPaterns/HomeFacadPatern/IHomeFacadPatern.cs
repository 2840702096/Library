using Library.Application.Services.Home.Query.GetRecentBooks;
using Library.Application.Services.Home.Query.GetRecentReservations;
using Library.Application.Services.Home.Query.GetRecentUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Interfaces.FacadPaterns.HomeFacadPatern
{
    public interface IHomeFacadPatern
    {
        public GetRecentUsersService GetRecentUsersService { get; }
        public GetRecentBooksService GetRecentBooksService { get; }
        public GetRecentReservationsService GetRecentReservationsService { get; }
    }
}
