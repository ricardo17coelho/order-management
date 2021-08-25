using Microsoft.EntityFrameworkCore;

namespace order_management.tests.Repos
{
    public class FakeContext : OrderManagementDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "in_memory_test_db");
        }
    }
}
