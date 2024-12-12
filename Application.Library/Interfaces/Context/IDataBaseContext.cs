using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.Interfaces.Context
{
    public interface IDataBaseContext
    {
        DbSet<Books> Books { get; set; }
        DbSet<Users> Users { get; set; }
        DbSet<Users_Books> Users_Books { get; set; }
        DbSet<MessageSettings> MessageSettings { get; set; }
        DbSet<Fine> Fine { get; set; }

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
