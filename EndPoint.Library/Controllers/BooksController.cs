using Library.Application.Interfaces.FacadPaterns.BooksFacadPatern;
using Library.Application.Services.Books.Command.AddOrEditBook;
using Library.Application.Services.Users.Command.AddOrEditUser;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Library.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksFacadPatern _booksFacadPatern;

        public BooksController(IBooksFacadPatern booksFacadPatern)
        {
            _booksFacadPatern = booksFacadPatern;
        }

        [Route("Books")]
        public IActionResult Index()
        {
            return View(_booksFacadPatern.GetBooksService.Execute());
        }

        #region AddOrEditBook

        [Route("Books/AddOrEditBook")]
        public IActionResult AddOrEditBook(int? editId)
        {
            ViewBag.EditId = editId;
            return PartialView(_booksFacadPatern.GetBookInfoService.Execute(editId));
        }

        [HttpPost]
        [Route("Books/AddOrEditBook")]
        public IActionResult AddOrEditBook(AddOrEditBookServiceInputDto input)
        {
            var Result = _booksFacadPatern.AddOrEditBookService.Execute(input);
            return Json(Result);
        }

        #endregion

        #region Activation

        [Route("Books/Activation")]
        public IActionResult Activation(int id)
        {
            var Result = _booksFacadPatern.BookActivationService.Execute(id);
            return Json(Result);
        }

        #endregion

        #region DeleteBook

        [HttpPost]
        [Route("Books/DeleteBook")]
        public IActionResult DeleteBook(int id)
        {
            var Result = _booksFacadPatern.DeleteBookService.Execute(id);
            return Json(Result);
        }

        #endregion
    }
}
