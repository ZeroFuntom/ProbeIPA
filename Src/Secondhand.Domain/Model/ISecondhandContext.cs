using System.Data.Entity;

namespace Secondhand.Domain.Model
{
    public interface ISecondhandContext
    {
        DbSet<User> Users { get; }
        DbSet<Item> Items { get; }
    }
}
