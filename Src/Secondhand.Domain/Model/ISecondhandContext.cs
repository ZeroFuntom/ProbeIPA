using System.Data.Entity;

namespace Secondhand.Domain.Model
{
    public interface ISecondhandContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Item> Items { get; set; }
        int SaveChanges();
    }
}
