using System;
using System.Data.Entity.SqlServer;

namespace Secondhand.Domain.Model
{
    public partial class SecondhandModelContainer : ISecondhandContext
    {
        // Do not remove, ensures static reference to System.Data.Entity.SqlServer
        public Type ProviderType { get; } = typeof(SqlProviderServices);
    }
}
