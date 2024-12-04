[DbContext(typeof(AppDbContext))]
// Specifies the `AppDbContext` for which this snapshot is generated.

partial class AppDbContextModelSnapshot : ModelSnapshot
// Defines the snapshot class for the `AppDbContext`.
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    // Describes the database schema for comparison during migration.
    {
        modelBuilder
            .HasAnnotation("ProductVersion", "7.0.4")
            // Specifies the Entity Framework Core version.

            .HasAnnotation("Relational:MaxIdentifierLength", 128);
            // Sets the max identifier length for the relational database.

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);
        // Configures identity columns for SQL Server.

        modelBuilder.Entity("MSSQLApp.Data.Employee", b =>
        // Describes the `Employee` entity schema.
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                // Configures `Id` as an auto-generated column.

                .HasColumnType("int");
                // Sets the SQL type.

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));
            // Configures identity column properties for SQL Server.

            b.Property<string>("Name")
                .IsRequired()
                // Marks `Name` as required.

                .HasColumnType("nvarchar(max)");
                // Sets the SQL type as variable-length string.

            b.Property<string>("Title")
                .IsRequired()
                // Marks `Title` as required.

                .HasColumnType("nvarchar(max)");
                // Sets the SQL type.

            b.HasKey("Id");
            // Sets `Id` as the primary key.

            b.ToTable("Employees");
            // Maps the entity to the `Employees` table.
        });
    }
}
