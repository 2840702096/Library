using Library.Common.DTOs;
using Library.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Users.Command.AddOrEditUser
{
    public interface IAddOrEditUserService
    {
        ResultDto Execute(AddOrEditUserServiceDto input);
    }
}
