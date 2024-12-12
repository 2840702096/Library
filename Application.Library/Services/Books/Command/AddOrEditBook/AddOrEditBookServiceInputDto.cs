using System.ComponentModel.DataAnnotations;

namespace Library.Application.Services.Books.Command.AddOrEditBook
{
    public class AddOrEditBookServiceInputDto
    {
        [Display(Name = "نام کتاب")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int? EditId { get; set; }
    }
}
