[DbContext(typeof(AppDbContext))] 
// Specifies that this migration is for the `AppDbContext`.

[Migration("20230403105921_Add_Employees_Table")] 
// Assigns a unique identifier ("20230403105921_Add_Employees_Table") to the migration.

partial class Add_Employees_Table 
// Defines the migration class that contains database schema changes.

protected override void BuildTargetModel(ModelBuilder modelBuilder) 
// Builds the database model during migration.
{
    modelBuilder
        .HasAnnotation("ProductVersion", "7.0.4") 
        // Specifies the Entity Framework Core version used.

        .HasAnnotation("Relational:MaxIdentifierLength", 128); 
        // Sets the maximum identifier length for the database.

    SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder); 
    // Configures SQL Server to use identity columns for primary keys.

    modelBuilder.Entity("MSSQLApp.Data.Employee", b => 
    // Defines the schema for the `Employee` entity.
    {
        b.Property<int>("Id")
            .ValueGeneratedOnAdd() 
            // Configures `Id` as the primary key and auto-generated.

            .HasColumnType("int"); 
            // Specifies the SQL type.

        SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id")); 
        // Configures the identity column for SQL Server.

        b.Property<string>("Name")
            .IsRequired() 
            // Makes the `Name` column mandatory.

            .HasColumnType("nvarchar(max)"); 
            // Sets the SQL type as variable-length string.

        b.Property<string>("Title")
            .IsRequired()
            .HasColumnType("nvarchar(max)"); 
            // Similar to `Name`, mandatory and of type string.

        b.HasKey("Id"); 
        // Defines `Id` as the primary key.

        b.ToTable("Employees"); 
        // Maps this entity to the `Employees` table.
    });
}
