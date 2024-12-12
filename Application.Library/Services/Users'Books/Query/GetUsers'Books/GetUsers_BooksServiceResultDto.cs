using Library.Domain.Entities;
using System;

namespace Library.Application.Services.Users_Books.Query.GetUsers_Books
{
    public class GetUsers_BooksServiceResultDto
    {
        public int Id { get; set; }
        public bool IsReturned { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Domain.Entities.Users User { get; set; }
        public Domain.Entities.Books Book { get; set; }
    }
}
