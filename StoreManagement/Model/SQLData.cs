using Microsoft.EntityFrameworkCore;

namespace StoreManagement.Model
{
    public class SQLData: DbContext
    {
        public SQLData(DbContextOptions<SQLData> option) : base(option)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Input> Inputs { get; set; }

        public DbSet<InputInfo> InputInfos { get; set; }

        public DbSet<ObjectTable> ObjectTables { get; set; }

        public DbSet<Output> Outputs { get; set; }

        public DbSet<OutputInfo> OutputInfos { get; set; }

        public DbSet<Suplier> Supliers { get; set; }

        public DbSet<Unit> Units { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }
    }
}
