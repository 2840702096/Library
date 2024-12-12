using Library.Application.Interfaces.Context;
using Library.Application.Services.Users.Command.EditFine;

namespace Library.Application.Services.Users.Query.GetFineInfoForEdit
{
    public class GetFineInfoForEditService : IGetFineInfoForEditService
    {
        private readonly IDataBaseContext _context;

        public GetFineInfoForEditService(IDataBaseContext context)
        {
            _context = context;
        }

        public EditFineServiceResultDto Execute(int id)
        {
            var Fine = _context.Fine.Find(id);

            return new EditFineServiceResultDto()
            {
                Id = Fine.Id,
                Fine = Fine.FineValue.ToString()
            };
        }
    }
}
