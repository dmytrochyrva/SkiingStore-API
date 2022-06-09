// Libraries Namespaces
using Microsoft.EntityFrameworkCore;

// Local Namespaces
using SkiingStore.Core.Models;

namespace SkiingStore.Infrastructure.Data
{
  public class SkiingStoreDb : DbContext
  {
    public SkiingStoreDb(DbContextOptions<SkiingStoreDb> options) : base(options) { }

    public DbSet<TestModel> TestColumn { get; set; }
  }
}