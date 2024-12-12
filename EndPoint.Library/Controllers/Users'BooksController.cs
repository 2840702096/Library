using Library.Application.Interfaces.FacadPaterns.Users_BooksFacadPatern;
using Library.Common;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EndPoint.Library.Controllers
{
    public class Users_BooksController : Controller
    {
        private readonly IUsers_BooksFacadPatern _users_BooksFacadPatern;

        public Users_BooksController(IUsers_BooksFacadPatern users_BooksFacadPatern)
        {
            _users_BooksFacadPatern = users_BooksFacadPatern;
        }

        [Route("Users_Books")]
        public IActionResult Index()
        {
            var date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            ViewBag.Now = date;

            return View(_users_BooksFacadPatern.GetUsers_BooksService.Execute());
        }

        #region TheBookIsBack

        [Route("Users_Books/TheBookIsBack")]
        public IActionResult TheBookIsBack(int id)
        {
            var Result = _users_BooksFacadPatern.MakeTheBookReturnedService.Execute(id);
            return Json(Result);
        }

        #endregion

        #region MakeTheFinePaid

        [Route("Users_Books/MakeTheFinePaid")]
        public IActionResult MakeTheFinePaid(int id)
        {
            _users_BooksFacadPatern.MakeTheFinePaidService.Execute(id);
            return Redirect("/Users_Books");
        }

        #endregion

        #region ObserverMessageContext

        [Route("Users_Books/ObserverMessageContext")]
        public IActionResult ObserverMessageContext(int id)
        {
            ViewBag.MessageContext = _users_BooksFacadPatern.GetMessageContextService.Execute(id);
            return PartialView();
        }

        #endregion
    }
}
