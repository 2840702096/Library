using Library.Application.Interfaces.Context;
using Library.Application.Services.Messages.Query.GetMessageInfoForEdit;
using Library.Common.DTOs;
using System;

namespace Library.Application.Services.Messages.Command.EditMessageContext
{
    public class EditMessageContextService : IEditMessageContextService
    {
        private readonly IDataBaseContext _context;

        public EditMessageContextService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(GetMessageInfoForEditServiceResultDto input)
        {
            try
            {
                var Message = _context.MessageSettings.Find(input.EditId);

                Message.MessageContext = input.MessageContext;

                _context.MessageSettings.Update(Message);
                _context.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "ویرایش پیام با موفقیت انحام شد",
                    Title = "موفق",
                    Icon = "success"
                };
            }
            catch (Exception)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "ویرایش پیام با خطا مواجه شد",
                    Title = "ناموفق",
                    Icon = "error"
                };
            }
        }
    }
}
