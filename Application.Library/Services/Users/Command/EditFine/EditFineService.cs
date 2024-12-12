using Library.Application.Interfaces.Context;
using System;

namespace Library.Application.Services.Users.Command.EditFine
{
    public class EditFineService : IEditFineServuce
    {
        private readonly IDataBaseContext _context;

        public EditFineService(IDataBaseContext context)
        {
            _context = context;
        }

        public void Execute(EditFineServiceResultDto input)
        {
            var Fine = _context.Fine.Find(input.Id);

            Fine.FineValue = int.Parse(input.Fine);

            _context.Fine.Update(Fine);
            _context.SaveChanges();
        }
    }
}
