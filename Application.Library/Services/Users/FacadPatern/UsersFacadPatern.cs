using FurnitureCatalog.Application.Services.Furnitures.Query.GetCountOfFurnitures;
using Library.Application.Interfaces.Context;
using Library.Application.Interfaces.FacadPaterns.UsersFacadPatern;
using Library.Application.Services.Users.Command.AddOrEditUser;
using Library.Application.Services.Users.Command.DeleteUser;
using Library.Application.Services.Users.Command.EditFine;
using Library.Application.Services.Users.Command.UserActivation;
using Library.Application.Services.Users.Query.DoesThisUserHaveAReservation;
using Library.Application.Services.Users.Query.GetFineInfoForEdit;
using Library.Application.Services.Users.Query.GetMessageContext;
using Library.Application.Services.Users.Query.GetUserInfo;
using Library.Application.Services.Users.Query.GetUsersService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Users.FacadPatern
{
    public class UsersFacadPatern : IUsersFacadPatern
    {
        private readonly IDataBaseContext _context;

        public UsersFacadPatern(IDataBaseContext context)
        {
            _context = context;
        }

        private GetUsersService _getUsersService;
        public GetUsersService GetUsersService
        {
            get
            {
                return _getUsersService = _getUsersService == null ? new GetUsersService(_context) : _getUsersService;
            }
        }

        private GetCountOfUsersService _getCountOfUsersService;
        public GetCountOfUsersService GetCountOfUsersService
        {
            get
            {
                return _getCountOfUsersService = _getCountOfUsersService == null ? new GetCountOfUsersService(_context) : _getCountOfUsersService;
            }
        }

        private AddOrEditUserService _addOrEditUserService;
        public AddOrEditUserService AddOrEditUserService
        {
            get
            {
                return _addOrEditUserService = _addOrEditUserService == null ? new AddOrEditUserService(_context) : _addOrEditUserService;
            }
        }

        private GetUserInfoService _getUserInfoService;
        public GetUserInfoService GetUserInfoService
        {
            get
            {
                return _getUserInfoService = _getUserInfoService == null ? new GetUserInfoService(_context) : _getUserInfoService;
            }
        }

        private DeleteUserService _deleteUserService;
        public DeleteUserService DeleteUserService
        {
            get
            {
                return _deleteUserService = _deleteUserService == null ? new DeleteUserService(_context) : _deleteUserService;
            }
        }

        private UserActivationService _userActivationService;
        public UserActivationService UserActivationService
        {
            get
            {
                return _userActivationService = _userActivationService == null ? new UserActivationService(_context) : _userActivationService;
            }
        }

        private EditFineService _editFineService;
        public EditFineService EditFineService
        {
            get
            {
                return _editFineService = _editFineService == null ? new EditFineService(_context) : _editFineService;
            }
        }

        private GetFineInfoForEditService _getFineInfoForEditService;
        public GetFineInfoForEditService GetFineInfoForEditService
        {
            get
            {
                return _getFineInfoForEditService = _getFineInfoForEditService == null ? new GetFineInfoForEditService(_context) : _getFineInfoForEditService;
            }
        }

        private DoesThisUserHaveAReservationService _doesThisUserHaveAReservationService;
        public DoesThisUserHaveAReservationService DoesThisUserHaveAReservationService
        {
            get
            {
                return _doesThisUserHaveAReservationService = _doesThisUserHaveAReservationService == null ? new DoesThisUserHaveAReservationService(_context) : _doesThisUserHaveAReservationService;
            }
        }
    }
}
