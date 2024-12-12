using Library.Common;
using Library.Application.Interfaces.FacadPaterns.UsersFacadPatern;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Library.Application.Services.Users.Command.AddOrEditUser;
using Library.Application.Interfaces.FacadPaterns.Users_BooksFacadPatern;
using Library.Application.Services.Users_Books.Command.AddOrEditUsers_Book;
using Library.Application.Services.Users.Command.EditFine;

namespace EndPoint.Library.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersFacadPatern _usersFacadPatern;
        private readonly IUsers_BooksFacadPatern _users_BooksFacadPatern;

        public UsersController(IUsersFacadPatern usersFacadPatern, IUsers_BooksFacadPatern users_BooksFacadPatern)
        {
            _usersFacadPatern = usersFacadPatern;
            _users_BooksFacadPatern = users_BooksFacadPatern;
        }

        [Route("Users")]
        public IActionResult Index()
        {
            return View(_usersFacadPatern.GetUsersService.Execute());
        }

        #region AddOrEditUser

        [Route("Users/AddUser")]
        public IActionResult AddUser(int? editId)
        {
            ViewBag.EditId = editId;
            return PartialView(_usersFacadPatern.GetUserInfoService.Execute(editId));
        }

        [HttpPost]
        [Route("Users/AddUser")]
        public IActionResult AddUser(AddOrEditUserServiceDto input)
        {
            var Result = _usersFacadPatern.AddOrEditUserService.Execute(input);
            return Json(Result);
        }

        #endregion

        #region Activation

        [Route("Users/Activation")]
        public IActionResult Activation(int id)
        {
            var Result = _usersFacadPatern.UserActivationService.Execute(id);
            return Json(Result);
        }

        #endregion

        #region DeleteUser

        [HttpPost]
        [Route("Users/DeleteUser")]
        public IActionResult DeleteUser(int id)
        {
            var Result = _usersFacadPatern.DeleteUserService.Execute(id);
            return Json(Result);
        }

        #endregion

        #region AddOrEditUser'sBook

        [Route("Users_BooksTest")]
        public IActionResult Users_BooksTest(int? id, int? editId)
        {
            if(_usersFacadPatern.DoesThisUserHaveAReservationService.Execute(id))
            {
                ViewBag.ThisUserHasAlreadyReservedABook = true;
                return View(_users_BooksFacadPatern.GetUserSBookInfoForEditService.Execute(editId));
            }
            ViewBag.UserId = id;
            ViewBag.EditId = editId;
            var Books = _users_BooksFacadPatern.GetBooksForSelectListService.Execute(editId);
            ViewBag.Books = new SelectList(Books, "Value", "Text");
            return View(_users_BooksFacadPatern.GetUserSBookInfoForEditService.Execute(editId));
        }

        [HttpPost]
        [Route("Users_BooksTest")]
        public IActionResult Users_BooksTest(AddOrEditUsers_BookServiceInputDto input)
        {
            _users_BooksFacadPatern.AddOrEditUsers_BookService.Execute(input);
            return Redirect("Users_Books");
        }

        #endregion

        #region Fine

        [Route("Fine")]
        public IActionResult Fine()
        {
            return View(_usersFacadPatern.GetFineInfoForEditService.Execute(1));
        }

        [HttpPost]
        [Route("Fine")]
        public IActionResult Fine(EditFineServiceResultDto input)
        {
            _usersFacadPatern.EditFineService.Execute(input);
            return Redirect("/Fine");
        }

        #endregion
    }
}
