using Library.Application.Interfaces.Context;
using Library.Application.Interfaces.FacadPaterns.HomeFacadPatern;
using Library.Application.Services.Books.Query.GetBooks;
using Library.Application.Services.Home.Query.GetRecentBooks;
using Library.Application.Services.Home.Query.GetRecentReservations;
using Library.Application.Services.Home.Query.GetRecentUsers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Home.FacadPtern
{
    public class HomeFacadPatern : IHomeFacadPatern
    {
        private readonly IDataBaseContext _context;

        public HomeFacadPatern(IDataBaseContext context)
        {
            _context = context;
        }

        private GetRecentUsersService _getRecentUsersService;
        public GetRecentUsersService GetRecentUsersService
        {
            get
            {
                return _getRecentUsersService = _getRecentUsersService == null ? new GetRecentUsersService(_context) : _getRecentUsersService;
            }
        }

        private GetRecentBooksService _getRecentBooksService;
        public GetRecentBooksService GetRecentBooksService
        {
            get
            {
                return _getRecentBooksService = _getRecentBooksService == null ? new GetRecentBooksService(_context) : _getRecentBooksService;
            }
        }

        private GetRecentReservationsService _getRecentReservationsService;
        public GetRecentReservationsService GetRecentReservationsService
        {
            get
            {
                return _getRecentReservationsService = _getRecentReservationsService == null ? new GetRecentReservationsService(_context) : _getRecentReservationsService;
            }
        }
    }
}
