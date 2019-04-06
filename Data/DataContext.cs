using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BestProductFindsApi.Data
{
  public class DataContext : DbContext
  {
    private readonly IConfiguration _config;

    public DataContext(DbContextOptions options, IConfiguration config) : base(options)
    {
      _config = config;
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Seller> Sellers { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      // optionsBuilder.UseMySql(_config.GetConnectionString("DefaultConnection"));
      // optionsBuilder.UseSqlite(_config.GetConnectionString("DefaultConnection"));
      optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      PopulateData.PopulateTableData(builder);
    }
  }
}