// Libraries Namespaces
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SkiingStore.Infrastructure.Data
{
  public class SkiingStoreDbFactory : IDesignTimeDbContextFactory<SkiingStoreDb>
  {
    private string _connectionString = "Server=localhost; Database=SkiingStore; User=root; Password=1485YaNaLavOc#keSigu";

    public SkiingStoreDb CreateDbContext(string[] args)
    {
      var optionsBuilder = new DbContextOptionsBuilder<SkiingStoreDb>();
      optionsBuilder.UseMySql(this._connectionString, ServerVersion.AutoDetect(this._connectionString));

      return new SkiingStoreDb(optionsBuilder.Options);
    }
  }
}