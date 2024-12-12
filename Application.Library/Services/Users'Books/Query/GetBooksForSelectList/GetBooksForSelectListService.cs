using Library.Application.Interfaces.Context;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Library.Application.Services.Users_Books.Query.GetBooksForSelectList
{
    public class GetBooksForSelectListService : IGetBooksForSelectListService
    {
        private readonly IDataBaseContext _context;

        public GetBooksForSelectListService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<SelectListItem> Execute(int? editId)
        {
            if (editId == null)
            {
                return _context.Books.Where(b => b.IsActive).Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                }).ToList();
            }
            else
            {
                List<SelectListItem> List = _context.Books.Where(b => b.IsActive).Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                }).ToList();

                int BookId = _context.Users_Books.Find(editId).BookId;

                SelectListItem Item = _context.Books.Where(b => b.Id == BookId).Select(b => new SelectListItem
                {
                    Text = b.Name,
                    Value = b.Id.ToString()
                }).Single();

                List.Add(Item);

                return List;
            }
        }
    }
}
