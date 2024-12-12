using FurnitureCatalog.Application.Services.Furnitures.Query.GetCountOfFurnitures;
using Library.Application.Services.Users.Command.AddOrEditUser;
using Library.Application.Services.Users.Command.DeleteUser;
using Library.Application.Services.Users.Command.EditFine;
using Library.Application.Services.Users.Command.UserActivation;
using Library.Application.Services.Users.Query.DoesThisUserHaveAReservation;
using Library.Application.Services.Users.Query.GetFineInfoForEdit;
using Library.Application.Services.Users.Query.GetMessageContext;
using Library.Application.Services.Users.Query.GetUserInfo;
using Library.Application.Services.Users.Query.GetUsersService;

namespace Library.Application.Interfaces.FacadPaterns.UsersFacadPatern
{
    public interface IUsersFacadPatern
    {
        GetUsersService GetUsersService { get; }
        GetCountOfUsersService GetCountOfUsersService { get; }
        AddOrEditUserService AddOrEditUserService { get; }
        GetUserInfoService GetUserInfoService { get; }
        DeleteUserService DeleteUserService { get; }
        UserActivationService UserActivationService { get; }
        GetFineInfoForEditService GetFineInfoForEditService { get; }
        EditFineService EditFineService { get; }
        DoesThisUserHaveAReservationService DoesThisUserHaveAReservationService { get; }
    }
}
