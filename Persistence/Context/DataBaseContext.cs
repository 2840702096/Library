using Library.Application.Interfaces.Context;
using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Library.Persistence.Context
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Users_Books> Users_Books { get; set; }
        public DbSet<MessageSettings> MessageSettings { get; set; }
        public DbSet<Fine> Fine { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            #region QueryFilters

            modelBuilder.Entity<Users>().HasQueryFilter(u => !u.IsDelete);
            modelBuilder.Entity<Books>().HasQueryFilter(b => !b.IsDelete);

            #endregion
        }
    }
}
