using Library.Application.Interfaces.Context;
using Library.Application.Interfaces.FacadPaterns.MessagesFacadPatern;
using Library.Application.Services.Books.Query.GetBooks;
using Library.Application.Services.Messages.Command.EditMessageContext;
using Library.Application.Services.Messages.Query.GetMessageInfoForEdit;
using Library.Application.Services.Messages.Query.GetMessages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Messages.FacadPatern
{
    public class MessagesFacadPaternService : IMessagesFacadPaternService
    {
        private readonly IDataBaseContext _context;

        public MessagesFacadPaternService(IDataBaseContext context)
        {
            _context = context;
        }

        private GetMessagesService _getMessagesService;
        public GetMessagesService GetMessagesService
        {
            get
            {
                return _getMessagesService = _getMessagesService == null ? new GetMessagesService(_context) : _getMessagesService;
            }
        }

        private GetMessageInfoForEditService _getMessageInfoForEditService;
        public GetMessageInfoForEditService GetMessageInfoForEditService
        {
            get
            {
                return _getMessageInfoForEditService = _getMessageInfoForEditService == null ? new GetMessageInfoForEditService(_context) : _getMessageInfoForEditService;
            }
        }

        private EditMessageContextService _editMessageContextService;
        public EditMessageContextService EditMessageContextService
        {
            get
            {
                return _editMessageContextService = _editMessageContextService == null ? new EditMessageContextService(_context) : _editMessageContextService;
            }
        }
    }
}
