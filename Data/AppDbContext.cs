using Microsoft.EntityFrameworkCore; // Importing the Entity Framework Core namespace, required for working with DbContext and managing database interactions.
using Microsoft.Extensions.Hosting; // Importing the Hosting namespace, commonly used for building and configuring applications.

namespace MSSQLApp.Data // Defining a namespace to organize related classes and avoid naming conflicts.
{
    public class AppDbContext : DbContext // Creating a class `AppDbContext` that inherits from `DbContext`, representing the application's database context.
    {
        public IConfiguration _config { get; set; } // Defining a property `_config` of type `IConfiguration` to access configuration settings.

        public AppDbContext(IConfiguration config) // Constructor that accepts an `IConfiguration` object, allowing dependency injection of configuration settings.
        {
            _config = config; // Assigning the passed configuration to the `_config` property.
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Overriding the `OnConfiguring` method to set up database connection options.
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection")); 
            // Configuring the context to use SQL Server, retrieving the connection string named "DatabaseConnection" from the configuration.
        }

        public DbSet<Employee> Employees { get; set; } 
        // Defining a `DbSet` property for the `Employee` entity, enabling CRUD operations for the `Employee` table.
    }
}
