// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkiingStore.Infrastructure.Data;

#nullable disable

namespace SkiingStore.Infrastructure.Data.Migrations
{
  [DbContext(typeof(SkiingStoreDb))]
  [Migration("20220609222629_InitialMigration")]
  partial class InitialMigration
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "6.0.5")
          .HasAnnotation("Relational:MaxIdentifierLength", 64);

      modelBuilder.Entity("SkiingStore.Core.Models.Product", b =>
          {
            b.Property<string>("Id")
                      .HasColumnType("varchar(255)");

            b.Property<string>("Category")
                      .HasColumnType("longtext");

            b.Property<string>("Description")
                      .HasColumnType("longtext");

            b.Property<string>("ImageUrl")
                      .HasColumnType("longtext");

            b.Property<string>("Name")
                      .HasColumnType("longtext");

            b.Property<float>("Price")
                      .HasColumnType("float");

            b.HasKey("Id");

            b.ToTable("Products");
          });
#pragma warning restore 612, 618
    }
  }
}
