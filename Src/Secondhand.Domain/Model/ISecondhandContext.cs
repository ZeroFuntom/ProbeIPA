using System.Data.Entity;

namespace Secondhand.Domain.Model
{
    public interface IWiwaContext
    {
        DbSet<Item> Items { get; set; }
        DbSet<User> Users { get; set; }
        int SaveChanges();
    }
}
