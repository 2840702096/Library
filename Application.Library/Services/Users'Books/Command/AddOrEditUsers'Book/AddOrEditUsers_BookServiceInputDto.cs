using System;

namespace Library.Application.Services.Users_Books.Command.AddOrEditUsers_Book
{
    public class AddOrEditUsers_BookServiceInputDto
    {
        public int? EditId { get; set; }
        public int? UserId { get; set; }
        public int BookId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
