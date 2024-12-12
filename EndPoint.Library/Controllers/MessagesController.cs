using Library.Application.Interfaces.FacadPaterns.MessagesFacadPatern;
using Library.Application.Services.Messages.Query.GetMessageInfoForEdit;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Library.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMessagesFacadPaternService _messagesFacadPaternService;

        public MessagesController(IMessagesFacadPaternService messagesFacadPaternService)
        {
            _messagesFacadPaternService = messagesFacadPaternService;   
        }

        [Route("Messages")]
        public IActionResult Index()
        {
            return View(_messagesFacadPaternService.GetMessagesService.Execute());
        }

        #region ObserveOrEditMessageContext

        [Route("Messages/ObserveOrEditMessageContext")]
        public IActionResult ObserveOrEditMessageContext(int id)
        {
            ViewBag.EditId = id;
            return PartialView(_messagesFacadPaternService.GetMessageInfoForEditService.Execute(id));
        }

        [HttpPost]
        [Route("Messages/ObserveOrEditMessageContext")]
        public IActionResult ObserveOrEditMessageContext(GetMessageInfoForEditServiceResultDto input)
        {
            var Result = _messagesFacadPaternService.EditMessageContextService.Execute(input);
            return Json(Result);
        }

        #endregion
    }
}
