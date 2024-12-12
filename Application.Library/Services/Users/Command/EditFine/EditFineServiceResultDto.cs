using System.ComponentModel.DataAnnotations;

namespace Library.Application.Services.Users.Command.EditFine
{
    public class EditFineServiceResultDto
    {
        public int Id { get; set; }

        [Display(Name = "مبلغ جریمه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Fine { get; set; }
    }
}
