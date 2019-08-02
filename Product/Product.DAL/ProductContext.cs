using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Product.DAL.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Product.DAL
{

    // Enable-Migrations
    // Add-Migration init
    // Update-Database

    public class ProductContext : DbContext
    {
        public virtual DbSet<Products> Products { get; set; }

        public virtual DbSet<ProductType> ProductTypes { get; set; }

        public ProductContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ProductContext>
    {
        public ProductContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()

                .SetBasePath(Directory.GetCurrentDirectory()) // nuget : Microsoft.Extensions.configuration.FileExtensions
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)  // nuget : Microsoft.Extensions.configuration.Json
                .AddEnvironmentVariables()  // requires Microsoft.Extensions.Configuration.EnvironmentVariables
                .Build();


            var builder = new DbContextOptionsBuilder<ProductContext>();
            var connectionString = configuration.GetConnectionString("SqlServerConnection");//SqlServerConnection là name của ConnectionStrings trong file json
            builder.UseSqlServer(connectionString);

            return new ProductContext(builder.Options);
        }
    }
}
